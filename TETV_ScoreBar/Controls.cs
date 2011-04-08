using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TETV_ScoreBar {
    public partial class Controls : Form {
        GraphicsMode _mode;
        Game game;
        Display display;
        Screen[] screens;
        int screen;
        
        #region Constructors

        public Controls(Game game, Display display) {
            InitializeComponent();
            this.game = game;
            this.display = display;

            // Set screen
            screen = Config.GetInt(ConfigKey.ControlScreen);
            SetScreen();

            // Set mode
            mode = GraphicsMode.ScoreBar;
            showGraphics = true;

            // Hide stats stuff if needed
            bUseStats.Enabled = game.gameType == GameType.Basketball;

            // Init gridview for player db
            conestogaPlayerGrid.DataSource = conestogaPlayersDataSet.Tables["Conestoga"].DefaultView;
            
            // Set version label
            lVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            // Set default info text
            tCustomInfoText.Text = game.infoText;
            DeselectInfoTextPresets();
            bUpdateInfoText.BackColor = Color.LightGreen;

            // Set scorebar appearance
            showInfoText = Config.GetBool(ConfigKey.ShowInfoText);
            showScores = Config.GetBool(ConfigKey.ShowScores);
            showTimeouts = Config.GetBool(ConfigKey.ShowTimeouts);
            showBug = Config.GetBool(ConfigKey.ShowBug);

            // Set default control values
            nHomeTimeouts.Value = game.Timeouts[0];
            nVisitingTimeouts.Value = game.Timeouts[1];
            bNobodysBall_Click(null, null);

            // Load default credits
            string creditsFile = Config.GetString(ConfigKey.CreditsFile);
            if (creditsFile != null && File.Exists(creditsFile)) {
                tCredits.LoadFile(creditsFile);
                creditsLocation = creditsFile;
            }

            // Alter controls for game type
            switch (game.gameType) {
                case GameType.Hockey:
                    lQuarter.Text = "Period";
                    cOT.Visible = false;
                    bToggleTimeouts.Visible = false;
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    gPossession.Text = "Power Play";
                    bConestogaBall.Text = "Conestoga Power Play";
                    bVisitingBall.Text = "Visitor Power Play";
                    bNobodysBall.Text = "No Power Play";
                    pDownYards.Visible = false;
                    bInfoPreset1.Text = "Penalty";
                    bInfoPreset2.Text = "Goal";
                    bInfoPreset3.Text = "Face Off";
                    bInfoPreset4.Text = "Timeout";
                    bInfoPreset5.Visible = false;
                    gInfoText.Height -= (bInfoPreset5.Height + bInfoPreset5.Margin.Bottom);
                    break;
                case GameType.Basketball:
                    cOT.Visible = false;
                    bToggleTimeouts.Visible = false;
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    RemoveGroup(tabScores, gPossession);
                    pDownYards.Visible = false;
                    bInfoPreset1.Text = "Foul";
                    bInfoPreset2.Text = "Timeout";
                    bInfoPreset3.Text = "Free Throw";
                    bInfoPreset4.Text = "3 Points";
                    bInfoPreset5.Visible = false;
                    gInfoText.Height -= (bInfoPreset5.Height + bInfoPreset5.Margin.Bottom);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Properties

        bool _showGraphics;
        bool showGraphics {
            get {
                return _showGraphics;
            }
            set {
                _showGraphics = value;
                mode = mode;
                bToggleGraphics.Text = (value ? "Hide Graphics" : "Show Graphics");
                bToggleGraphics.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        bool _showInfoText;
        public bool showInfoText {
            get {
                return _showInfoText;
            }
            set {
                _showInfoText = value;
                bToggleInfoBar.Text = (value ? "Hide Text Bar" : "Show Text Bar");
                Config.SetValue(ConfigKey.ShowInfoText, value);
                Config.Save();
                display.showInfoText = value;
                display.UpdateDisplay();
                //gInfoText.Enabled = value;
                bToggleInfoBar.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        bool _showScores;
        public bool showScores {
            get {
                return _showScores;
            }
            set {
                _showScores = value;
                bToggleScores.Text = (value ? "Hide Scores" : "Show Scores");
                Config.SetValue(ConfigKey.ShowScores, value);
                Config.Save();
                display.showScores = value;
                display.UpdateDisplay();
                //gScores.Enabled = value;
                bToggleScores.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        bool _showTimeouts;
        public bool showTimeouts {
            get {
                return _showTimeouts;
            }
            set {
                _showTimeouts = value;
                bToggleTimeouts.Text = (value ? "Hide Timeouts" : "Show Timeouts");
                Config.SetValue(ConfigKey.ShowTimeouts, value);
                Config.Save();
                display.showTimeouts = value;
                display.UpdateDisplay();
                //gTimeouts.Enabled = value;
                bToggleTimeouts.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        bool _showBug;
        public bool showBug {
            get {
                return _showBug;
            }
            set {
                _showBug = value;
                bToggleBug.Text = (value ? "Hide Bug" : "Show Bug");
                Config.SetValue(ConfigKey.ShowBug, value);
                Config.Save();
                display.showBug = value && showGraphics;
                display.UpdateDisplay();
                bToggleBug.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        GraphicsMode mode {
            get {
                return _mode;
            }
            set {
                _mode = value;
                display.HideAll();
                bUseScoreBar.BackColor = Color.FromName("Control");
                bUseReplay.BackColor = Color.FromName("Control");
                bUseHalfTime.BackColor = Color.FromName("Control");
                bUseEndOfGame.BackColor = Color.FromName("Control");
                bUseCustomShow.BackColor = Color.FromName("Control");
                bUseBeforeGame.BackColor = Color.FromName("Control");
                bUseCredits.BackColor = Color.FromName("Control");

                display.showBug = showGraphics && showBug;
                display.UpdateDisplay();

                Color inUseColor = Color.LightGreen;
                switch (_mode) {
                    case GraphicsMode.ScoreBar:
                        bUseScoreBar.BackColor = inUseColor;
                        if (!showGraphics) break;
                        display.ShowScoreBar();
                        break;

                    case GraphicsMode.Replay:
                        bUseReplay.BackColor = inUseColor;
                        if (!showGraphics) break;
                        display.ShowReplay();
                        break;

                    case GraphicsMode.HalfTime:
                        bUseHalfTime.BackColor = inUseColor;
                        if (!showGraphics) break;
                        display.ShowHalfTime();
                        break;

                    case GraphicsMode.GameEnd:
                        bUseEndOfGame.BackColor = inUseColor;
                        if (!showGraphics) break;
                        break;

                    case GraphicsMode.CustomShow:
                        bUseCustomShow.BackColor = inUseColor;
                        if (!showGraphics) break;
                        break;

                    case GraphicsMode.ComingUp:
                        bUseBeforeGame.BackColor = inUseColor;
                        if (!showGraphics) break;
                        break;

                    case GraphicsMode.Credits:
                        bUseCredits.BackColor = inUseColor;
                        if (!showGraphics) break;
                        display.ShowCredits();
                        break;
                }
            }
        }

        #endregion

        #region Screen

        void SetScreen() {
            if (screens == null)
                screens = Screen.AllScreens;
            if (screens.Length < 2)
                return;
            bool wasMaximized = false;
            if (this.WindowState == FormWindowState.Maximized) {
                wasMaximized = true;
                this.WindowState = FormWindowState.Normal;
            }
            this.StartPosition = FormStartPosition.Manual;
            this.Location = screens[screen].Bounds.Location;
            this.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            if (wasMaximized)
                this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Use Graphics Mode

        public void bUseScoreBar_Click(object sender, EventArgs e) {
            mode = GraphicsMode.ScoreBar;
        }

        public void bUseReplay_Click(object sender, EventArgs e) {
            mode = GraphicsMode.Replay;
        }

        public void bUseBeforeGame_Click(object sender, EventArgs e) {
            mode = GraphicsMode.ComingUp;
        }

        public void bUseEndOfGame_Click(object sender, EventArgs e) {
            mode = GraphicsMode.GameEnd;
        }

        public void bUseHalfTime_Click(object sender, EventArgs e) {
            mode = GraphicsMode.HalfTime;
        }

        public void bUseCustomShow_Click(object sender, EventArgs e) {
            mode = GraphicsMode.CustomShow;
        }

        public void bUseCredits_Click(object sender, EventArgs e) {
            mode = GraphicsMode.Credits;
        }

        private void bUseStats_Click(object sender, EventArgs e) {
            display.showStats = !display.showStats;
            display.UpdateDisplay();
            bUseStats.BackColor = display.showStats ? Color.Cyan : Color.FromName("Control");
        }

        #endregion

        #region Bottom Buttons

        private void bToggleGraphics_Click(object sender, EventArgs e) {
            showGraphics = !showGraphics;
        }

        private void bToggleBug_Click(object sender, EventArgs e) {
            showBug = !showBug;
        }

        #endregion

        #region Scores
        
        private void bUpdateScores_Click(object sender, EventArgs e) {
            game.TeamScore[0] = (int)nHomeScore.Value;
            game.TeamScore[1] = (int)nVisitingScore.Value;
            display.UpdateDisplay();
            bUpdateScores.Enabled = false;
        }

        private void nHomeScore_ValueChanged(object sender, EventArgs e) {
            bUpdateScores.Enabled = true;
        }

        private void nVisitingScore_ValueChanged(object sender, EventArgs e) {
            bUpdateScores.Enabled = true;
        }

        #endregion

        #region Timeouts

        private void bResetTimeouts_Click(object sender, EventArgs e) {
            nHomeTimeouts.Value = 3;
            nVisitingTimeouts.Value = 3;

            game.Timeouts = new int[] { (int)nHomeTimeouts.Value, (int)nVisitingTimeouts.Value };
            display.UpdateDisplay();
            bUpdateTimeouts.Enabled = false;
        }

        private void bUpdateTimeouts_Click(object sender, EventArgs e) {
            game.Timeouts = new int[] { (int)nHomeTimeouts.Value, (int)nVisitingTimeouts.Value };
            display.UpdateDisplay();
            bUpdateTimeouts.Enabled = false;
        }

        private void nHomeTimeouts_ValueChanged(object sender, EventArgs e) {
            bUpdateTimeouts.Enabled = true;
        }

        private void nVisitingTimeouts_ValueChanged(object sender, EventArgs e) {
            bUpdateTimeouts.Enabled = true;
        }

        #endregion

        #region Ball Possession

        private string oldInfoText = "";
        private bool showOldInfoText = false;
        private void bConestogaBall_Click(object sender, EventArgs e) {
            bConestogaBall.BackColor = Color.LightGreen;
            bVisitingBall.BackColor = Color.FromName("Control");
            bNobodysBall.BackColor = Color.FromName("Control");
            game.BallPossession = 1;
            if (game.gameType == GameType.Hockey) {
                if (oldInfoText == null) {
                    oldInfoText = game.infoText;
                    showOldInfoText = showInfoText;
                }
                showInfoText = true;
                game.infoText = "^ Power Play  ";
            }
            display.UpdateDisplay();
        }

        private void bVisitingBall_Click(object sender, EventArgs e) {
            bConestogaBall.BackColor = Color.FromName("Control");
            bVisitingBall.BackColor = Color.LightGreen;
            bNobodysBall.BackColor = Color.FromName("Control");
            game.BallPossession = 2;
            if (game.gameType == GameType.Hockey) {
                if (oldInfoText == null) {
                    oldInfoText = game.infoText;
                    showOldInfoText = showInfoText;
                }
                showInfoText = true;
                game.infoText = "  Power Play ^";
            }
            display.UpdateDisplay();
        }

        private void bNobodysBall_Click(object sender, EventArgs e) {
            bConestogaBall.BackColor = Color.FromName("Control");
            bVisitingBall.BackColor = Color.FromName("Control");
            bNobodysBall.BackColor = Color.LightGreen;
            game.BallPossession = 0;
            if (game.gameType == GameType.Hockey) {
                if (oldInfoText == null) return;
                game.infoText = oldInfoText;
                showInfoText = showOldInfoText;
                oldInfoText = null;
            }
            display.UpdateDisplay();
        }

        #endregion

        #region Game info

        private void nQuarter_ValueChanged(object sender, EventArgs e) {
            bUpdateGameInfo.Enabled = true;
        }

        private void cOT_CheckedChanged(object sender, EventArgs e) {
            nQuarter.Enabled = !cOT.Checked;
            bUpdateGameInfo.Enabled = true;
        }

        private void bUpdateGameInfo_Click(object sender, EventArgs e) {
            game.Quarter = (int)nQuarter.Value;
            if (cOT.Checked)
                game.Quarter = -1;
            display.UpdateDisplay();
            bUpdateGameInfo.Enabled = false;
        }

        #endregion

        #region Info Text

        private void bUpdateInfoText_Click(object sender, EventArgs e) {
            game.infoText = tCustomInfoText.Text;
            display.UpdateDisplay();
            DeselectInfoTextPresets();
            bUpdateInfoText.BackColor = Color.LightGreen;
            showInfoText = true;
        }

        private void bDisplayDownYards_Click(object sender, EventArgs e) {
            game.infoText = Utils.ToOrderedString((int)nDown.Value) + " & " + nYards.Value.ToString();
            display.UpdateDisplay();
            DeselectInfoTextPresets();
            bDisplayDownYards.BackColor = Color.LightGreen;
            showInfoText = true;
        }

        private void bInfoPreset_Click(object sender, EventArgs e) {
            game.infoText = ((Button)sender).Text;
            DeselectInfoTextPresets();
            ((Button)sender).BackColor = Color.LightGreen;
            display.UpdateDisplay();
            showInfoText = true;
        }

        private void DeselectInfoTextPresets() {
            bInfoPreset1.BackColor = Color.FromName("Control");
            bInfoPreset2.BackColor = Color.FromName("Control");
            bInfoPreset3.BackColor = Color.FromName("Control");
            bInfoPreset4.BackColor = Color.FromName("Control");
            bInfoPreset5.BackColor = Color.FromName("Control");
            bUpdateInfoText.BackColor = Color.FromName("Control");
            bDisplayDownYards.BackColor = Color.FromName("Control");
        }

        private void bResetDownYards_Click(object sender, EventArgs e) {
            nDown.Value = 1;
            nYards.Value = 10;
            game.infoText = Utils.ToOrderedString((int)nDown.Value) + " & " + nYards.Value.ToString();
            DeselectInfoTextPresets();
            bDisplayDownYards.BackColor = Color.LightGreen;
            display.UpdateDisplay();
            showInfoText = true;
        }

        #endregion

        #region Appearance

        private void bToggleInfoBar_Click(object sender, EventArgs e) {
            showInfoText = !showInfoText;
        }

        private void bToggleScores_Click(object sender, EventArgs e) {
            showScores = !showScores;
        }

        private void bToggleTimeouts_Click(object sender, EventArgs e) {
            showTimeouts = !showTimeouts;
        }

        #endregion

        #region Credits Editor

        string creditsLocation = "";

        private void InsertImage(object sender, EventArgs e) {
            if (MessageBox.Show("Inserting an image will clear your clipboard. Proceed?", "Warning: Clipboard will be cleared",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            if (dImageBrowser.ShowDialog() == DialogResult.Cancel)
                return;

            Clipboard.SetImage(Utils.GetImage(dImageBrowser.FileName));

            if (!Clipboard.ContainsImage())
                return;

            if (tCredits.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                tCredits.Paste();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            if (creditsLocation.Length > 0) {
                tCredits.SaveFile(creditsLocation);
                return;
            }

            if (dSaveCredits.ShowDialog() == DialogResult.Cancel)
                return;

            tCredits.SaveFile(dSaveCredits.FileName);

            Config.SetValue(ConfigKey.CreditsFile, dSaveCredits.FileName);
            Config.Save();

            creditsLocation = dSaveCredits.FileName;
        }

        private void openToolStripButton_Click(object sender, EventArgs e) {
            if (dOpenCredits.ShowDialog() == DialogResult.Cancel)
                return;

            tCredits.LoadFile(dOpenCredits.FileName);

            Config.SetValue(ConfigKey.CreditsFile, dOpenCredits.FileName);
            Config.Save();

            creditsLocation = dOpenCredits.FileName;
        }

        private void newToolStripButton_Click(object sender, EventArgs e) {
            tCredits.Clear();

            creditsLocation = "";
        }

        private void cutToolStripButton_Click(object sender, EventArgs e) {
            tCredits.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e) {
            tCredits.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e) {
            tCredits.Paste();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            tCredits.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton4_Click(object sender, EventArgs e) {
            tCredits.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton5_Click(object sender, EventArgs e) {
            tCredits.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tCredits_TextChanged(object sender, EventArgs e) {
            display.creditsRTF = tCredits.Rtf;
            display.UpdateDisplay();
        }

        #endregion

        #region Credits

        #endregion

        #region Group Management

        void RemoveGroup(TabPage page, GroupBox group) {
            group.Visible = false;
            foreach (GroupBox g in tabScores.Controls.OfType<GroupBox>().OrderBy(box => box.Location.Y).ToList<GroupBox>())
                if (g.Location.Y > group.Location.Y)
                    g.Location = new Point(g.Location.X, g.Location.Y - (group.Height + group.Margin.Top));
        }

        #endregion

        private void playerGrid_SelectionChanged(object sender, EventArgs e) {
            display.plyNumber = ((DataGridView)sender).CurrentRow.Cells[0].Value.ToString();
            display.plyName = ((DataGridView)sender).CurrentRow.Cells[1].Value.ToString();
            display.plyPoints = ((DataGridView)sender).CurrentRow.Cells[2].Value.ToString();
            display.plyFouls = ((DataGridView)sender).CurrentRow.Cells[3].Value.ToString();
            display.UpdateDisplay();
        }
    }

    public enum GraphicsMode {
        ScoreBar,
        Replay,
        ComingUp,
        GameEnd,
        HalfTime,
        CustomShow,
        Credits
    }
}
