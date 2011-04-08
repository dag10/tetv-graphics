using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TETV_ScoreBar {
    public partial class Display : Form {
        Game game;
        Settings controls;
        static Screen[] screens;
        public int screen;
        Object dragTarget = null;
        Timer creditsTimer = null;
        Point dragOffset = new Point();
        public bool showInfoText = true;
        public bool showScores = true;
        public bool showTimeouts = true;
        public bool showBug = true;
        public bool showStats = false;
        public bool halftime = false;
        public const int ScreenPadding = 60;
        public string creditsRTF = "";
        string replayImage = "";
        string boardImage = "";
        bool screenSet = false;
        public string[] statFields = { " ", " ", " ", " " };
        public string[] statValues = { " ", " ", " ", " " };

        #region Constructors

        public Display(Game game, Settings controls) {
            this.game = game;
            this.controls = controls;
            InitializeComponent();
            editMode = true;
            showStats = game.gameType == GameType.Basketball;

            // Get screen from config
            screen = Config.GetInt(ConfigKey.DisplayScreen);

            // Hide match (alt) scores if needed
            pAltScoreLeft.Visible = pAltScoreRight.Visible = game.gameType == GameType.Wrestling;

            // Update display
            UpdateDisplay();

            // Hook events
            this.FormClosed += new FormClosedEventHandler(handleClose);
            this.MouseEnter += new EventHandler(HandleMouseEnter);
            this.MouseLeave += new EventHandler(HandleMouseLeave);

            // Make labels transparent
            lQuarter.BackColor = Color.Transparent;
            lInfoText.BackColor = Color.Transparent;
            lAbbr1.BackColor = Color.Transparent;
            lAbbr2.BackColor = Color.Transparent;
            lScore1.BackColor = Color.Transparent;
            lScore2.BackColor = Color.Transparent;
            lAltScore1.BackColor = Color.Transparent;
            lAltScore2.BackColor = Color.Transparent;
            pReplay.BackColor = Color.Transparent;

            // Set label colors
            lQuarter.ForeColor = Color.Gold;
            lInfoText.ForeColor = Color.FromArgb(10, 10, 10);
            lAbbr1.ForeColor = Color.FromArgb(10, 10, 10);
            lAbbr2.ForeColor = Color.FromArgb(10, 10, 10);
            lScore1.ForeColor = Color.FromArgb(10, 10, 10);
            lScore2.ForeColor = Color.FromArgb(10, 10, 10);
            lAltScore1.ForeColor = Color.FromArgb(10, 10, 10);
            lAltScore2.ForeColor = Color.FromArgb(10, 10, 10);
        }

        #endregion

        #region Display Updating

        bool _editMode = false;
        public bool editMode {
            get {
                return _editMode;
            }
            set {
                _editMode = value;
                if (value) {
                    pReplay.BorderStyle = BorderStyle.Fixed3D; 
                    pBar.BorderStyle = BorderStyle.Fixed3D;
                    pBug.BorderStyle = BorderStyle.Fixed3D;
                    pStat.BorderStyle = BorderStyle.Fixed3D;
                    halftime = true;
                } else {
                    pReplay.BorderStyle = BorderStyle.None;
                    pBar.BorderStyle = BorderStyle.None;
                    pBug.BorderStyle = BorderStyle.None;
                    pStat.BorderStyle = BorderStyle.None;
                }
            }
        }

        void SetScreen() {
            if (screens == null)
                screens = Screen.AllScreens;
            if (screens.Length < 2)
                return;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = screens[screen].Bounds.Location;
            this.WindowState = FormWindowState.Normal;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Height = screens[screen].Bounds.Height;
            this.Width = screens[screen].Bounds.Width;
            //this.Height = 768;
            //this.Width = 1024;

            screenSet = true;
        }

        public void UpdateDisplay() {
            // Display on proper screen
            if (!screenSet)
                SetScreen();

            // Set stat bar elements
            lStatValue0.Text = statValues[0];
            lStatValue1.Text = statValues[1];
            lStatValue2.Text = statValues[2];
            lStatValue3.Text = statValues[3];
            lStatField0.Text = statFields[0];
            lStatField1.Text = statFields[1];
            lStatField2.Text = statFields[2];
            lStatField3.Text = statFields[3];

            // Set ScoreBar elements
            this.lAbbr1.Text = game.TeamAbbr[0];
            this.lAbbr2.Text = game.TeamAbbr[1];
            this.lScore1.Text = game.TeamScore[0].ToString();
            this.lScore2.Text = game.TeamScore[1].ToString();
            this.lAltScore1.Text = game.AltScore[0].ToString();
            this.lAltScore2.Text = game.AltScore[1].ToString();
            this.lQuarter.Text = game.Quarter.ToString();
            this.lInfoText.Text = game.infoText.Replace("&", "&&");
            if (game.Quarter == -1)
                this.lQuarter.Text = "OT";
            else
                this.lQuarter.Text = Utils.ToOrderedString(game.Quarter);
            this.pBar.Location = game.ScoreBoardPosition;

            // Set positions
            this.pReplay.Location = game.ReplayPosition;
            this.pBug.Location = game.BugPosition;
            this.pStat.Location = game.StatPosition;
            this.pCredits.Location = new Point((this.Width / 2) - (this.pCredits.Width / 2),
                                               (this.Height / 2) - (this.pCredits.Height / 2));

            // Set images
            string imgStr = "";
            if (showInfoText) imgStr += "B";
            if (showScores) imgStr += "S";
            if (game.BallPossession == 1) imgStr += "L";
            if (game.BallPossession == 2) imgStr += "R";
            if (imgStr.Length > 0)
                imgStr = "main_" + imgStr;
            else
                imgStr = "main";
            if (!boardImage.Equals(imgStr))
                pMain.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject(imgStr);
            boardImage = string.Copy(imgStr);

            pLeftScore.Visible = showScores;
            pRightScore.Visible = showScores;
            pBug.Visible = showBug;
            pStat.Visible = showStats;

            if (showTimeouts)
                pLeftScore.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject("score_left_" + game.Timeouts[0]);
            else
                pLeftScore.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject("score_left");

            if (showTimeouts)
                pRightScore.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject("score_right_" + game.Timeouts[1]);
            else
                pRightScore.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject("score_right");

            if (halftime)
                if (game.ReplayPosition.X < (this.Width / 2) - (pReplay.Width / 2))
                    imgStr = "halftime_L";
                else
                    imgStr = "halftime_R";
            else
                if (game.ReplayPosition.X < (this.Width / 2) - (pReplay.Width / 2))
                    imgStr = "replay_L";
                else
                    imgStr = "replay_R";

            if (!replayImage.Equals(imgStr))
                pReplay.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject(imgStr);
            replayImage = string.Copy(imgStr);


            // Set credits
            tCredits.Rtf = creditsRTF;
        }

        public void HideButtons() {
            bOtherSide.Hide();
            editMode = false;
        }

        #endregion

        #region GUI Information

        public Point BoardSize {
            get { return new Point(pBar.Size.Width, pBar.Size.Height); }
        }

        public Point ReplaySize {
            get { return new Point(pReplay.Size.Width, pReplay.Size.Height); }
        }

        public Point BugSize {
            get { return new Point(pBug.Size.Width, pBug.Size.Height); }
        }

        public Point StatSize {
            get { return new Point(pStat.Size.Width, pStat.Size.Height); }
        }

        #endregion

        #region Event Handlers

        void handleClose(object param, EventArgs e) {
            controls.Close();
        }

        void HandleMouseEnter(object param, EventArgs e) {
            if (game.active) Cursor.Hide();
        }

        void HandleMouseLeave(object param, EventArgs e) {
            if (game.active) Cursor.Show();
        }

        #endregion

        #region Show/Hide Modes

        public void ShowScoreBar() {
            pBar.Visible = true;
        }

        public void ShowReplay() {
            pReplay.Visible = true;
            halftime = false;
            UpdateDisplay();
        }

        public void ShowHalfTime() {
            pReplay.Visible = true;
            halftime = true;
            UpdateDisplay();
        }

        public void ShowStats() {
            pStat.Visible = true;
        }

        public void HideStats() {
            pStat.Visible = false;
        }

        public void ShowCredits() {
            if (creditsTimer == null) {
                creditsTimer = new Timer();
                creditsTimer.Interval = 10;
                creditsTimer.Tick += new EventHandler(creditsTimer_Tick);
            }
            creditsTimer.Enabled = true;

            tCredits.Height = 35565;
            tCredits.Top = pCredits.Height;
            pCredits.Visible = true;
        }

        void creditsTimer_Tick(object sender, EventArgs e) {
            tCredits.Top--;
        }

        public void HideAll() {
            pBar.Visible = false;
            pReplay.Visible = false;
            pCredits.Visible = false;
            pBug.Visible = false;
            pStat.Visible = false;

            if (creditsTimer != null)
                creditsTimer.Enabled = false;
        }

        #endregion

        #region Button Handlers

        private void bOtherSide_Click(object sender, EventArgs e) {
            controls.SwapControlsAndDisplay();
        }

        #endregion

        #region Draw and Drop

        void DragBoard(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - pBar.Location.X, p.Y - pBar.Location.Y);
            dragTarget = pBar;
        }

        void DragReplay(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - pReplay.Location.X, p.Y - pReplay.Location.Y);
            dragTarget = pReplay;
        }

        void DragBug(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - pBug.Location.X, p.Y - pBug.Location.Y);
            dragTarget = pBug;
        }

        void DragStat(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - pStat.Location.X, p.Y - pStat.Location.Y);
            dragTarget = pStat;
        }

        void DragStop(object sender, MouseEventArgs e) {
            dragTarget = null;

            controls.ReloadValues();
        }

        void display_MouseMove(object sender, MouseEventArgs e) {
            if (dragTarget == null) return;
            if (!editMode) {
                dragTarget = null;
                return;
            }

            Point p = PointToClient(Cursor.Position);

            if (dragTarget == pBar) {
                game.ScoreBoardPosition.X = p.X - dragOffset.X;
                game.ScoreBoardPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pReplay) {
                game.ReplayPosition.X = p.X - dragOffset.X;
                game.ReplayPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pBug) {
                game.BugPosition.X = p.X - dragOffset.X;
                game.BugPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pStat) {
                game.StatPosition.X = p.X - dragOffset.X;
                game.StatPosition.Y = p.Y - dragOffset.Y;
            } else return;

            UpdateDisplay();
        }


        #endregion
    }
}
