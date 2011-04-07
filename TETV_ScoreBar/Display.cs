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
        public bool halftime = false;
        public const int ScreenPadding = 60;
        public string creditsRTF = "";
        string replayImage = "";
        string boardImage = "";
        bool screenSet = false;

        #region Constructors

        public Display(Game game, Settings controls) {
            this.game = game;
            this.controls = controls;
            InitializeComponent();
            editMode = true;

            // Get screen from config
            screen = Config.GetInt(ConfigKey.DisplayScreen);

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
            pReplay.BackColor = Color.Transparent;

            // Set label colors
            lQuarter.ForeColor = Color.Gold;
            lInfoText.ForeColor = Color.FromArgb(10, 10, 10);
            lAbbr1.ForeColor = Color.FromArgb(10, 10, 10);
            lAbbr2.ForeColor = Color.FromArgb(10, 10, 10);
            lScore1.ForeColor = Color.FromArgb(10, 10, 10);
            lScore2.ForeColor = Color.FromArgb(10, 10, 10);
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
                    halftime = true;
                } else {
                    pReplay.BorderStyle = BorderStyle.None;
                    pBar.BorderStyle = BorderStyle.None;
                    pBug.BorderStyle = BorderStyle.None;
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

            // Set ScoreBar elements
            this.lAbbr1.Text = game.TeamAbbr[0];
            this.lAbbr2.Text = game.TeamAbbr[1];
            this.lScore1.Text = game.TeamScore[0].ToString();
            this.lScore2.Text = game.TeamScore[1].ToString();
            this.lQuarter.Text = game.Quarter.ToString();
            this.lInfoText.Text = game.infoText.Replace("&", "&&"); ;
            if (game.Quarter == -1)
                this.lQuarter.Text = "OT";
            else
                this.lQuarter.Text = Utils.ToOrderedString(game.Quarter);
            this.pBar.Location = game.ScoreBoardPosition;

            // Set positions
            this.pReplay.Location = game.ReplayPosition;
            this.pBug.Location = game.BugPosition;
            this.pCredits.Location = new Point((this.Width / 2) - (this.pCredits.Width / 2),
                                               (this.Height / 2) - (this.pCredits.Height / 2));

            // Set images
            string imgStr = "";
            if (showInfoText) imgStr += "B";
            if (showScores) imgStr += "S";
            if (game.BallPossession == 1) imgStr += "L";
            if (game.BallPossession == 2) imgStr += "R";
            if (imgStr.Length > 0)
                imgStr = "resources/main_" + imgStr + ".bmp";
            else
                imgStr = "resources/main.bmp";
            if (!boardImage.Equals(imgStr))
                pMain.BackgroundImage = Utils.GetImage(imgStr);
            boardImage = string.Copy(imgStr);

            pLeftScore.Visible = showScores;
            pRightScore.Visible = showScores;
            pBug.Visible = showBug;

            if (showTimeouts)
                pLeftScore.BackgroundImage = Utils.GetImage("resources/score_left_" + game.Timeouts[0] + ".bmp");
            else
                pLeftScore.BackgroundImage = Utils.GetImage("resources/score_left.bmp");

            if (showTimeouts)
                pRightScore.BackgroundImage = Utils.GetImage("resources/score_right_" + game.Timeouts[1] + ".bmp");
            else
                pRightScore.BackgroundImage = Utils.GetImage("resources/score_right.bmp");

            if (halftime)
                if (game.ReplayPosition.X < (this.Width / 2) - (pReplay.Width / 2))
                    imgStr = "resources/halftime_L.bmp";
                else
                    imgStr = "resources/halftime_R.bmp";
            else
                if (game.ReplayPosition.X < (this.Width / 2) - (pReplay.Width / 2))
                    imgStr = "resources/replay_L.bmp";
                else
                    imgStr = "resources/replay_R.bmp";

            if (!replayImage.Equals(imgStr))
                pReplay.BackgroundImage = Utils.GetImage(imgStr);
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
            } else return;

            UpdateDisplay();
        }


        #endregion
    }
}
