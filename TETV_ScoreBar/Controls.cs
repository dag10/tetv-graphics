using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Scoreboard_Communication;
using System.Threading;

namespace TETV_ScoreBar {
    public partial class Controls : Form {
        GraphicsMode _mode;
        Game game;
        Display display;
        Stats stats;
        Screen[] screens;
        bool[] editingPreset = { false, false, false, false, false, false };
        int screen;
        ScoreboardInterface controller = null;
        bool connected = false;
        
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

            // Initialize controller
            controller = new ScoreboardInterface();
            controller.StatusChanged += new SerialConnectionStatusChanged(StatusChanged);
            controller.GameClockUpdated += new GameClockRecordUpdated(GameClockRecordUpdated);
            controller.FootballUpdated += new FootballRecordUpdated(FootballRecordUpdated);
            controller.SoccerUpdated += new SoccerRecordUpdated(SoccerRecordUpdated);
            controller.DisplayException += new PassException(PassException);
            Thread controllerThread = new Thread(new ThreadStart(controller.StartThread));
            controllerThread.Start();

            // Hide stats stuff if needed
            bUseStats.Visible = game.gameType == GameType.Basketball || game.gameType == GameType.Wrestling;

            // Show stats window if needed
            if (game.gameType == GameType.Basketball || game.gameType == GameType.Wrestling) {
                stats = new Stats(game, display, this);
                stats.Show();
            }
            tabPage.TabPages.Remove(tStats);
            
            // Set version label
            bVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            // Set default info text
            tCustomInfoText.Text = game.infoText;
            DeselectInfoTextPresets();
            bUpdateInfoText.BackColor = Color.LightGreen;

            // Highlight quarter buttons
            bQuarter1.BackColor = Color.LightGreen;
            bQuarter2.BackColor = Color.FromName("Control");
            bQuarter3.BackColor = Color.FromName("Control");
            bQuarter4.BackColor = Color.FromName("Control");
            bQuarterOT.BackColor = Color.FromName("Control");

            // Set scorebar appearance
            showInfoText = Config.GetBool(ConfigKey.ShowInfoText);
            showScores = Config.GetBool(ConfigKey.ShowScores);
            showTimeouts = Config.GetBool(ConfigKey.ShowTimeouts);
            showBug = Config.GetBool(ConfigKey.ShowBug);
            showHalfTimeClock = Config.GetBool(ConfigKey.ShowHalfTimeClock);
            showClock = Config.GetBool(ConfigKey.ShowClock);

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

            // Load default Serial Port
            cSerialPort.Text = Config.GetString(ConfigKey.SerialPort);

            // Set timeout's default value
            setHomeTimeouts(bHomeTimeouts0, null);
            setVisitingTimeouts(bVisitingTimeouts0, null);

            // Set window title
            Text += " - " + game.gameType.ToString();

            // Alter controls for game type
            switch (game.gameType) {
                case GameType.Football:
                    RemoveGroup(tabScores, gMatchScores);
                    iUseForMatchScore.Visible = false;
                    iUseForPeriod.Text = "Quarter";
                    bInfoPreset1.Text = "Flag";
                    bInfoPreset2.Text = "Touchdown";
                    bInfoPreset3.Text = "Kickoff";
                    bInfoPreset4.Text = "Field Goal";
                    bInfoPreset5.Text = "Timeout";
                    bIncHome1.Text = "+1";
                    bIncHome2.Text = "+2";
                    bIncHome3.Text = "+3";
                    bIncHome4.Text = "+6";
                    bIncVisiting1.Text = "+1";
                    bIncVisiting2.Text = "+2";
                    bIncVisiting3.Text = "+3";
                    bIncVisiting4.Text = "+6";
                    break;
                case GameType.Generic:
                    RemoveGroup(tabScores, gMatchScores);
                    RemoveGroup(tabScores, gTimeouts);
                    iUseForMatchScore.Visible = false;
                    iUseForDownYards.Visible = false;
                    iUseForTimeouts.Visible = false;
                    iUseForPossession.Visible = false;
                    pDownYards.Visible = false;
                    display.showTimeouts = false;
                    bInfoPreset5.Location = new Point(303, 19);
                    bEditPreset5.Location = new Point(417, 19);
                    bInfoPreset6.Location = new Point(303, 48);
                    bEditPreset6.Location = new Point(417, 48);
                    lCustomText.Location = new Point(lCustomText.Location.X, lCustomText.Location.Y - 29);
                    tCustomInfoText.Location = new Point(tCustomInfoText.Location.X, tCustomInfoText.Location.Y - 29);
                    bUpdateInfoText.Location = new Point(bUpdateInfoText.Location.X, bUpdateInfoText.Location.Y - 29);
                    bHideInfoText.Location = new Point(bHideInfoText.Location.X, bHideInfoText.Location.Y - 29);
                    gInfoText.Height -= 29;
                    break;
                case GameType.Hockey:
                    lQuarter.Text = "Period";
                    //bQuarterOT.Visible = false;
                    bToggleTimeouts.Visible = false;
                    iUseForDownYards.Visible = false;
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    RemoveGroup(tabScores, gMatchScores);
                    iUseForTimeouts.Visible = false;
                    iUseForMatchScore.Visible = false;
                    gPossession.Text = "Power Play";
                    bConestogaBall.Text = "Conestoga Power Play";
                    bVisitingBall.Text = "Visitor Power Play";
                    bNobodysBall.Text = "None";
                    pDownYards.Visible = false;
                    bInfoPreset5.Location = new Point(303, 19);
                    bEditPreset5.Location = new Point(417, 19);
                    bInfoPreset6.Location = new Point(303, 48);
                    bEditPreset6.Location = new Point(417, 48);
                    lCustomText.Location = new Point(lCustomText.Location.X, lCustomText.Location.Y - 29);
                    tCustomInfoText.Location = new Point(tCustomInfoText.Location.X, tCustomInfoText.Location.Y - 29);
                    bUpdateInfoText.Location = new Point(bUpdateInfoText.Location.X, bUpdateInfoText.Location.Y - 29);
                    bHideInfoText.Location = new Point(bHideInfoText.Location.X, bHideInfoText.Location.Y - 29);
                    gInfoText.Height -= 29;
                    bInfoPreset1.Text = "Penalty";
                    bInfoPreset2.Text = "Goal";
                    bInfoPreset3.Text = "Face Off";
                    bInfoPreset4.Text = "Timeout";
                    break;
                case GameType.Basketball:
                    //bQuarterOT.Visible = false;
                    bToggleTimeouts.Visible = false;
                    iUseForDownYards.Visible = false;
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    RemoveGroup(tabScores, gPossession);
                    RemoveGroup(tabScores, gMatchScores);
                    iUseForTimeouts.Visible = false;
                    iUseForPossession.Visible = false;
                    iUseForMatchScore.Visible = false;
                    pDownYards.Visible = false;
                    bInfoPreset5.Location = new Point(303, 19);
                    bEditPreset5.Location = new Point(417, 19);
                    bInfoPreset6.Location = new Point(303, 48);
                    bEditPreset6.Location = new Point(417, 48);
                    lCustomText.Location = new Point(lCustomText.Location.X, lCustomText.Location.Y - 29);
                    tCustomInfoText.Location = new Point(tCustomInfoText.Location.X, tCustomInfoText.Location.Y - 29);
                    bUpdateInfoText.Location = new Point(bUpdateInfoText.Location.X, bUpdateInfoText.Location.Y - 29);
                    bHideInfoText.Location = new Point(bHideInfoText.Location.X, bHideInfoText.Location.Y - 29);
                    gInfoText.Height -= 29;
                    bInfoPreset1.Text = "Foul";
                    bInfoPreset2.Text = "Timeout";
                    bInfoPreset3.Text = "Free Throw";
                    bInfoPreset4.Text = "3 Points";
                    break;
                case GameType.Wrestling:
                    gScores.Text = "Team Score";
                    iUseForScore.Text = "Team Score";
                    bToggleTimeouts.Visible = false;
                    iUseForDownYards.Visible = false;
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    RemoveGroup(tabScores, gPossession);
                    iUseForTimeouts.Visible = false;
                    iUseForPossession.Visible = false;
                    pDownYards.Visible = false;
                    bInfoPreset5.Location = new Point(303, 19);
                    bEditPreset5.Location = new Point(417, 19);
                    bInfoPreset6.Location = new Point(303, 48);
                    bEditPreset6.Location = new Point(417, 48);
                    lCustomText.Location = new Point(lCustomText.Location.X, lCustomText.Location.Y - 29);
                    tCustomInfoText.Location = new Point(tCustomInfoText.Location.X, tCustomInfoText.Location.Y - 29);
                    bUpdateInfoText.Location = new Point(bUpdateInfoText.Location.X, bUpdateInfoText.Location.Y - 29);
                    bHideInfoText.Location = new Point(bHideInfoText.Location.X, bHideInfoText.Location.Y - 29);
                    gInfoText.Height -= 29;
                    bInfoPreset1.Text = "Timeout";
                    bInfoPreset2.Text = "Injury Timeout";
                    bInfoPreset3.Text = "Forfeit";
                    bInfoPreset4.Text = "Pin";
                    bIncHome1.Text = "+3";
                    bIncHome2.Text = "+4";
                    bIncHome3.Text = "+5";
                    bIncHome4.Text = "+6";
                    bIncVisiting1.Text = "+3";
                    bIncVisiting2.Text = "+4";
                    bIncVisiting3.Text = "+5";
                    bIncVisiting4.Text = "+6";
                    break;
                case GameType.Volleyball:
                    gScores.Text = "Game Score";
                    bToggleTimeouts.Visible = false;
                    iUseForDownYards.Visible = false;
                    iUseForScore.Text = "Game Score";
                    showTimeouts = false;
                    RemoveGroup(tabScores, gTimeouts);
                    RemoveGroup(tabScores, gPeriod);
                    iUseForTimeouts.Visible = false;
                    iUseForPeriod.Visible = false;
                    pDownYards.Visible = false;
                    bInfoPreset5.Location = new Point(303, 19);
                    bEditPreset5.Location = new Point(417, 19);
                    bInfoPreset6.Location = new Point(303, 48);
                    bEditPreset6.Location = new Point(417, 48);
                    lCustomText.Location = new Point(lCustomText.Location.X, lCustomText.Location.Y - 29);
                    tCustomInfoText.Location = new Point(tCustomInfoText.Location.X, tCustomInfoText.Location.Y - 29);
                    bUpdateInfoText.Location = new Point(bUpdateInfoText.Location.X, bUpdateInfoText.Location.Y - 29);
                    bHideInfoText.Location = new Point(bHideInfoText.Location.X, bHideInfoText.Location.Y - 29);
                    gInfoText.Height -= 29;
                    bIncHome1.Text = "+1";
                    bIncHome2.Text = "+2";
                    bIncHome3.Text = "+3";
                    bIncHome4.Text = "+4";
                    bIncVisiting1.Text = "+1";
                    bIncVisiting2.Text = "+2";
                    bIncVisiting3.Text = "+3";
                    bIncVisiting4.Text = "+4";
                    
                    break;
                default:
                    break;
            }

            // Hide preset edit boxes
            tPreset1.Visible = false;
            tPreset2.Visible = false;
            tPreset3.Visible = false;
            tPreset4.Visible = false;
            tPreset5.Visible = false;
            tPreset6.Visible = false;
            bInfoPreset1.Visible = true;
            bInfoPreset2.Visible = true;
            bInfoPreset3.Visible = true;
            bInfoPreset4.Visible = true;
            bInfoPreset5.Visible = true;
            bInfoPreset6.Visible = true;

            GameUpdated();
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
                Config.SetValue(ConfigKey.ShowInfoText, value);
                Config.Save();
                display.showInfoText = value;
                display.UpdateDisplay();
                bHideInfoText.Enabled = value;
                bHideInfoText.Text = (value ? "Hide Text" : "( Text Hidden )");
                bHideInfoText.BackColor = (value ? Color.FromName("Control") : Color.Yellow);
                if (!value) DeselectInfoTextPresets();
            }
        }

        bool _showScores;
        public bool showScores {
            get {
                return _showScores;
            }
            set {
                _showScores = value;
                //bToggleScores.Text = (value ? "Hide Scores" : "Show Scores");
                Config.SetValue(ConfigKey.ShowScores, value);
                Config.Save();
                display.showScores = value;
                display.UpdateDisplay();
                //gScores.Enabled = value;
                //bToggleScores.BackColor = (value ? Color.LightGreen : Color.Yellow);
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

        bool _showHalfTimeClock;
        public bool showHalfTimeClock {
            get {
                return _showHalfTimeClock;
            }
            set {
                _showHalfTimeClock = value;
                bShowHalfTimeClock.Text = (value ? "Hide Scoreboard Clock" : "Show Scoreboard Clock");
                Config.SetValue(ConfigKey.ShowHalfTimeClock, value);
                Config.Save();
                display.showHalfTimeClock = value && showGraphics;
                display.UpdateDisplay();
                bShowHalfTimeClock.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        bool _showClock;
        public bool showClock {
            get {
                return _showClock;
            }
            set {
                _showClock = value;
                bToggleClock.Text = (value ? "Hide Clock" : "Show Clock");
                Config.SetValue(ConfigKey.ShowClock, value);
                Config.Save();
                display.showClock = value && showGraphics;
                display.UpdateDisplay();
                bToggleClock.BackColor = (value ? Color.LightGreen : Color.Yellow);
            }
        }

        GraphicsMode mode {
            get {
                return _mode;
            }
            set {
                Color inUseColor = Color.Lime;
                Color notInUseColor = Color.LightGray;

                _mode = value;
                display.HideAll();
                bUseScoreBar.BackColor = notInUseColor;
                bUseReplay.BackColor = notInUseColor;
                bUseHalfTime.BackColor = notInUseColor;
                bUseEndOfGame.BackColor = notInUseColor;
                bUseCustomShow.BackColor = notInUseColor;
                bUseBeforeGame.BackColor = notInUseColor;
                bUseCredits.BackColor = notInUseColor;

                display.showBug = showGraphics && showBug;
                display.UpdateDisplay();

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
            bUseStats.Text = (display.showStats ? "Hide Stats" : "Show Stats");
            bUseStats.BackColor = display.showStats ? Color.Cyan : Color.Yellow;
        }

        #endregion

        #region Bottom Buttons

        private void bToggleGraphics_Click(object sender, EventArgs e) {
            showGraphics = !showGraphics;
        }

        private void bToggleBug_Click(object sender, EventArgs e) {
            showBug = !showBug;
        }

        private void bVersion_Click(object sender, EventArgs e) {
            MessageBox.Show(TETV_ScoreBar.Program.AboutText, "About This Program");
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

        private void incConestogaScore(object sender, EventArgs e) {
            game.TeamScore[0] += Int16.Parse(((Button)sender).Text.Substring(1));
            display.UpdateDisplay();
            nHomeScore.Value = game.TeamScore[0];
            bUpdateScores.Enabled = false;
        }

        private void incVisitingScore(object sender, EventArgs e) {
            game.TeamScore[1] += Int16.Parse(((Button)sender).Text.Substring(1));
            display.UpdateDisplay();
            nVisitingScore.Value = game.TeamScore[1];
            bUpdateScores.Enabled = false;
        }

        private void bUpdateAltScores_Click(object sender, EventArgs e) {
            game.AltScore[0] = (int)nHomeAltScore.Value;
            game.AltScore[1] = (int)nVisitingAltScore.Value;
            display.UpdateDisplay();
            bUpdateAltScores.Enabled = false;
        }

        private void nVisitingAltScore_ValueChanged(object sender, EventArgs e) {
            bUpdateAltScores.Enabled = true;
        }

        private void nHomeAltScore_ValueChanged(object sender, EventArgs e) {
            bUpdateAltScores.Enabled = true;
        }

        private void incConestogaAltScore(object sender, EventArgs e) {
            game.AltScore[0] += Int32.Parse(((Button)sender).Text.Substring(1));
            display.UpdateDisplay();
            nHomeAltScore.Value = game.AltScore[0];
            bUpdateAltScores.Enabled = false;
        }

        private void incVisitingAltScore(object sender, EventArgs e) {
            game.AltScore[1] += Int32.Parse(((Button)sender).Text.Substring(1));
            display.UpdateDisplay();
            nVisitingAltScore.Value = game.AltScore[1];
            bUpdateAltScores.Enabled = false;
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

        private void setHomeTimeouts(object sender, EventArgs e) {
            game.Timeouts[0] = Int32.Parse(((Button)sender).Text);
            bHomeTimeouts0.BackColor = Color.FromName("Control");
            bHomeTimeouts1.BackColor = Color.FromName("Control");
            bHomeTimeouts2.BackColor = Color.FromName("Control");
            bHomeTimeouts3.BackColor = Color.FromName("Control");
            ((Button)sender).BackColor = Color.LightGreen;
            display.UpdateDisplay();
        }

        private void setVisitingTimeouts(object sender, EventArgs e) {
            game.Timeouts[1] = Int32.Parse(((Button)sender).Text);
            bVisitingTimeouts0.BackColor = Color.FromName("Control");
            bVisitingTimeouts1.BackColor = Color.FromName("Control");
            bVisitingTimeouts2.BackColor = Color.FromName("Control");
            bVisitingTimeouts3.BackColor = Color.FromName("Control");
            ((Button)sender).BackColor = Color.LightGreen;
            display.UpdateDisplay();
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
                game.infoText = "<- Power Play  ";
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
                game.infoText = "Power Play ->";
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

        private void bQuarter_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            string qtVal = btn.Text;
            game.Quarter = qtVal == "Overtime" ? -1 : Int16.Parse(qtVal);

            bQuarter1.BackColor = Color.FromName("Control");
            bQuarter2.BackColor = Color.FromName("Control");
            bQuarter3.BackColor = Color.FromName("Control");
            bQuarter4.BackColor = Color.FromName("Control");
            bQuarterOT.BackColor = Color.FromName("Control");
            btn.BackColor = Color.LightGreen;

            display.UpdateDisplay();
        }

        #endregion

        #region Info Text

        private void bToggleText(object sender, EventArgs e) {
            showInfoText = !showInfoText;
        }

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
            bInfoPreset6.BackColor = Color.FromName("Control");
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
            //if (!group.Visible) return;

            bool foundSideGroup = group.Width == 555;

            group.Visible = false;
            foreach (GroupBox g in tabScores.Controls.OfType<GroupBox>().OrderBy(box => box.Location.Y).ToList<GroupBox>())
                if (g == group) continue;
                else if (g.Location.Y > group.Location.Y && group.Width == 555) {
                    g.Location = new Point(g.Location.X, g.Location.Y - (group.Height + group.Margin.Top));
                } else if (g.Location.Y == group.Location.Y && g.Width < 555) {
                    g.Width = 555;
                    g.Location = new Point(6, g.Location.Y);
                    foundSideGroup = true;
                }

            if (!foundSideGroup) {
                group.Width = 555;
                group.Visible = true;
                group.Location = new Point(6, group.Location.Y);
                RemoveGroup(page, group);
            }
        }

        void HideBarSegment(Panel segment, Panel bar) {
            if (!bar.Visible || !segment.Visible) return;

            foreach (Panel g in bar.Controls.OfType<Panel>().OrderBy(box => box.Location.X).ToList<Panel>())
                if (g.Location.X > (segment.Location.X))
                    g.Location = new Point(g.Location.X - (segment.Width), g.Location.Y);
            bar.Width -= segment.Width;

            segment.Visible = false;

            this.Update();
        }

        #endregion

        #region Preset Editing

        private void bEditPreset1_Click(object sender, EventArgs e) {
            StartEditing(0);
        }

        private void bEditPreset2_Click(object sender, EventArgs e) {
            StartEditing(1);
        }

        private void bEditPreset3_Click(object sender, EventArgs e) {
            StartEditing(2);
        }

        private void bEditPreset4_Click(object sender, EventArgs e) {
            StartEditing(3);
        }

        private void bEditPreset5_Click(object sender, EventArgs e) {
            StartEditing(4);
        }

        private void bEditPreset6_Click(object sender, EventArgs e) {
            StartEditing(5);
        }

        void StartEditing(int preset) {
            if (preset < 0 || preset >= editingPreset.Length) return;

            if (editingPreset[preset]) {
                StopEditing(preset);
                return;
            }

            for (int i = 0; i < editingPreset.Length; i++)
                if (editingPreset[i])
                    StopEditing(i);

            Button presetButton = null;
            TextBox presetBox = null;

            switch (preset) {
                case 0:
                    presetButton = bInfoPreset1;
                    presetBox = tPreset1;
                    break;
                case 1:
                    presetButton = bInfoPreset2;
                    presetBox = tPreset2;
                    break;
                case 2:
                    presetButton = bInfoPreset3;
                    presetBox = tPreset3;
                    break;
                case 3:
                    presetButton = bInfoPreset4;
                    presetBox = tPreset4;
                    break;
                case 4:
                    presetButton = bInfoPreset5;
                    presetBox = tPreset5;
                    break;
                case 5:
                    presetButton = bInfoPreset6;
                    presetBox = tPreset6;
                    break;
            }

            presetBox.Bounds = presetButton.Bounds;
            presetBox.Text = presetButton.Text;
            presetButton.Visible = false;
            presetBox.Visible = true;

            editingPreset[preset] = true;
        }

        void StopEditing(int preset) {
            if (preset < 0 || preset >= editingPreset.Length) return;

            Button presetButton = null;
            TextBox presetBox = null;

            switch (preset) {
                case 0:
                    presetButton = bInfoPreset1;
                    presetBox = tPreset1;
                    break;
                case 1:
                    presetButton = bInfoPreset2;
                    presetBox = tPreset2;
                    break;
                case 2:
                    presetButton = bInfoPreset3;
                    presetBox = tPreset3;
                    break;
                case 3:
                    presetButton = bInfoPreset4;
                    presetBox = tPreset4;
                    break;
                case 4:
                    presetButton = bInfoPreset5;
                    presetBox = tPreset5;
                    break;
                case 5:
                    presetButton = bInfoPreset6;
                    presetBox = tPreset6;
                    break;
            }

            presetButton.Text = presetBox.Text;

            presetBox.Visible = false;
            presetButton.Visible = true;

            editingPreset[preset] = false;
        }

        #endregion

        #region Scoreboard Controller Controls

        private void cSerialPort_TextUpdate(object sender, EventArgs e) {
            Config.SetValue(ConfigKey.SerialPort, cSerialPort.Text);
            Config.Save();
        }

        private void bStartStop_Click(object sender, EventArgs e) {
            if (connected) {
                controller.StopSerialConnection();
            } else {
                controller.StartSerialConnection(cSerialPort.Text);
            }
        }

        private void bToggleClock_Click(object sender, EventArgs e) {
            showClock = !showClock;
        }

        private void Controls_FormClosing(object sender, FormClosingEventArgs e) {
            controller.StopThread();
        }

        #endregion

        #region Scoreboard Controller Delegates

        void PassException(Exception e) {
            MessageBox.Show(e.Message, "Error");
        }

        public void StatusChanged(bool status) {
            try {
                connected = status;

                lStatus.Text = (status ? "Connected" : "Disconnected");
                lStatus.ForeColor = (status ? Color.Green : Color.Red);
                bStartStop.Text = (status ? "Disconnect" : "Connect");
                cSerialPort.Enabled = !status;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        private delegate void GameClockRecordUpdatedCallback(Game_Clock_Record record);
        public void GameClockRecordUpdated(Game_Clock_Record record) {
            if (InvokeRequired) {
                GameClockRecordUpdatedCallback callback = new GameClockRecordUpdatedCallback(GameClockRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                if (record.ClockChanged) {
                    game.Clock = record.Clock;
                    tClockPreview.Text = (game.Clock[0].ToString("D2") + ":" + game.Clock[1].ToString("D2") + (game.Clock[0] == 0 ? ":" + game.Clock[2] : ""));
                } if (record.PeriodChanged && game.AutoPeriod) {
                    game.Quarter = record.Period < 5 ? record.Period : -1;
                    bQuarter1.BackColor = Color.FromName("Control");
                    bQuarter2.BackColor = Color.FromName("Control");
                    bQuarter3.BackColor = Color.FromName("Control");
                    bQuarter4.BackColor = Color.FromName("Control");
                    bQuarterOT.BackColor = Color.FromName("Control");
                    if (record.Period == 1)
                        bQuarter1.BackColor = Color.LightGreen;
                    else if (record.Period == 2)
                        bQuarter2.BackColor = Color.LightGreen;
                    else if (record.Period == 3)
                        bQuarter3.BackColor = Color.LightGreen;
                    else if (record.Period == 4)
                        bQuarter4.BackColor = Color.LightGreen;
                    else if (record.Period == 5)
                        bQuarterOT.BackColor = Color.LightGreen;
                }

                display.DataWasUpdated();
            }
        }

        private delegate void FootballRecordUpdatedCallback(Football_Record record);
        public void FootballRecordUpdated(Football_Record record) {
            if (InvokeRequired) {
                FootballRecordUpdatedCallback callback = new FootballRecordUpdatedCallback(FootballRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                bStartStop.ToolTipText = "Game Detected: Football";

                if (record.ScoreChanged && game.AutoScore) {
                    nHomeScore.Value = record.Score[0];
                    nVisitingScore.Value = record.Score[1];
                    game.TeamScore[0] = record.Score[0];
                    game.TeamScore[1] = record.Score[1];
                } else if (record.TimeoutsLeftChanged && game.AutoTimeouts) {
                    game.Timeouts[0] = record.TimeoutsLeft[0];
                    game.Timeouts[1] = record.TimeoutsLeft[1];

                    bHomeTimeouts0.BackColor = Color.FromName("Control");
                    bHomeTimeouts1.BackColor = Color.FromName("Control");
                    bHomeTimeouts2.BackColor = Color.FromName("Control");
                    bHomeTimeouts3.BackColor = Color.FromName("Control");

                    bVisitingTimeouts0.BackColor = Color.FromName("Control");
                    bVisitingTimeouts1.BackColor = Color.FromName("Control");
                    bVisitingTimeouts2.BackColor = Color.FromName("Control");
                    bVisitingTimeouts3.BackColor = Color.FromName("Control");

                    if (record.TimeoutsLeft[0] == 0)
                        bHomeTimeouts0.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[0] == 1)
                        bHomeTimeouts1.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[0] == 2)
                        bHomeTimeouts2.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[0] == 3)
                        bHomeTimeouts3.BackColor = Color.LightGreen;

                    if (record.TimeoutsLeft[1] == 0)
                        bVisitingTimeouts0.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[1] == 1)
                        bVisitingTimeouts1.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[1] == 2)
                        bVisitingTimeouts2.BackColor = Color.LightGreen;
                    else if (record.TimeoutsLeft[1] == 3)
                        bVisitingTimeouts3.BackColor = Color.LightGreen;

                } else if ((record.DownChanged || record.ToGoChanged) && game.AutoDownYards) {
                    nDown.Value = record.Down;
                    nYards.Value = record.ToGo;
                    if (bDisplayDownYards.BackColor == Color.LightGreen)
                        bDisplayDownYards_Click(bDisplayDownYards, null);
                } else if (record.PossessionChanged && game.AutoPossession) {
                    game.BallPossession = record.Possession == Football_Record.FootballPossession.Home ? 1 :
                        record.Possession == Football_Record.FootballPossession.Visitor ? 2 : 0;
                }

                display.DataWasUpdated();
            }
        }

        private delegate void SoccerRecordUpdatedCallback(Soccer_Record record);
        public void SoccerRecordUpdated(Soccer_Record record) {
            if (InvokeRequired) {
                SoccerRecordUpdatedCallback callback = new SoccerRecordUpdatedCallback(SoccerRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                bStartStop.ToolTipText = "Game Detected: Soccer";

                if (record.ScoreChanged && game.AutoScore) {
                    nHomeScore.Value = record.Score[0];
                    nVisitingScore.Value = record.Score[1];
                    game.TeamScore[0] = record.Score[0];
                    game.TeamScore[1] = record.Score[1];
                }

                display.DataWasUpdated();
            }
        }

        private delegate void GameUpdatedCallback();
        public void GameUpdated() {
            if (InvokeRequired) {
                GameUpdatedCallback callback = new GameUpdatedCallback(GameUpdated);
                Invoke(callback, new object[] { });
            } else {
                // TODO: Update ALL the things!
                
                // Scores
                nHomeScore.Value = game.TeamScore[0];
                nVisitingScore.Value = game.TeamScore[1];

                // Set toggle buttons' default backgrounds
                bUseStats.BackColor = display.showStats ? Color.Cyan : Color.Yellow;
                bUseStats.Text = (display.showStats ? "Hide Stats" : "Show Stats");

                // Update display
                display.UpdateDisplay();
            }
        }

        #endregion

        #region Half-Time Settings

        private void bShowScoreboardClock_Click(object sender, EventArgs e) {
            showHalfTimeClock = !showHalfTimeClock;
        }

        #endregion

        #region Automatic (Controller-Controlled) Toggling

        private void iUseForScore_Click(object sender, EventArgs e) {
            gScores.Enabled = !iUseForScore.Checked;
            game.AutoScore = iUseForScore.Checked;
        }

        private void iUseForMatchScore_Click(object sender, EventArgs e) {
            gMatchScores.Enabled = !iUseForMatchScore.Checked;
            game.AutoMatchScore = iUseForMatchScore.Checked;
        }

        private void iUseForPossession_Click(object sender, EventArgs e) {
            gPossession.Enabled = !iUseForPossession.Checked;
            game.AutoPossession = iUseForPossession.Checked;
        }

        private void iUseForPeriod_Click(object sender, EventArgs e) {
            gPeriod.Enabled = !iUseForPeriod.Checked;
            game.AutoPeriod = iUseForPeriod.Checked;
        }

        private void iUseForTimeouts_Click(object sender, EventArgs e) {
            gTimeouts.Enabled = !iUseForTimeouts.Checked;
            game.AutoTimeouts = iUseForTimeouts.Checked;
        }

        private void iUseForDownYards_Click(object sender, EventArgs e) {
            bResetDownYards.Enabled = nDown.Enabled = nYards.Enabled = !iUseForDownYards.Checked;
            game.AutoDownYards = iUseForDownYards.Checked;
        }

        #endregion
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