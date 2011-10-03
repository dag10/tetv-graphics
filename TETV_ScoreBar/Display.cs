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
        private bool wasShowingTimeouts = false;
        public bool showTimeouts = true;
        public bool showBug = true;
        public bool showStats = false;
        public bool showHalfTimeClock = true;
        public bool halftime = false;
        public bool usingDoubleScores = false;
        public bool showPeriod = true;
        public bool showClock = true;
        public const int ScreenPadding = 60;
        public string creditsRTF = "";
        string leftTipImage = "";
        string rightTipImage = "";
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
            lQuarter.ForeColor = Color.FromArgb(102, 0, 0);
            lInfoText.ForeColor = Color.FromArgb(102, 0, 0);
            lAbbr1.ForeColor = Color.FromArgb(102, 0, 0);
            lAbbr2.ForeColor = Color.FromArgb(102, 0, 0);
            lScore1.ForeColor = Color.FromArgb(51, 51, 51);
            lScore2.ForeColor = Color.FromArgb(51, 51, 51);
            lScoreLP.ForeColor = Color.FromArgb(51, 51, 51);
            lScoreLS.ForeColor = Color.FromArgb(51, 51, 51);
            lScoreRP.ForeColor = Color.FromArgb(51, 51, 51);
            lScoreRS.ForeColor = Color.FromArgb(51, 51, 51);
            lHalfTime.ForeColor = Color.FromArgb(102, 0, 0);
            lHalfTimeClock.ForeColor = Color.FromArgb(102, 0, 0);
            lReplay.ForeColor = Color.FromArgb(102, 0, 0);
            lClock.ForeColor = Color.FromArgb(102, 0, 0);
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
                    pHalfTime.BorderStyle = BorderStyle.Fixed3D;
                    halftime = false;
                } else {
                    pReplay.BorderStyle = BorderStyle.None;
                    pBar.BorderStyle = BorderStyle.None;
                    pBug.BorderStyle = BorderStyle.None;
                    pStat.BorderStyle = BorderStyle.None;
                    pHalfTime.BorderStyle = BorderStyle.None;
                }

                // Adjust per game
                /*switch (game.gameType) {
                    case GameType.Volleyball:
                    case GameType.Wrestling:
                        usingDoubleScores = true;
                        break;
                    default:
                        usingDoubleScores = false;
                        break;
                }*/
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
            this.lScoreLP.Text = game.TeamScore[0].ToString();
            this.lScoreRP.Text = game.TeamScore[1].ToString();
            this.lScoreLS.Text = game.AltScore[0].ToString();
            this.lScoreRS.Text = game.AltScore[1].ToString();
            this.lQuarter.Text = game.Quarter.ToString();
            this.lInfoText.Text = game.infoText.Replace("&", "&&");
            if (game.Quarter == -1)
                this.lQuarter.Text = "OT";
            else
                this.lQuarter.Text = Utils.ToOrderedString(game.Quarter);

            // Set positions
            this.pBar.Location = new Point(game.ScoreBoardPosition.X - (this.pBar.Width / 2), game.ScoreBoardPosition.Y);
            this.pReplay.Location = game.ReplayPosition;
            this.pHalfTime.Location = game.HalfTimePosition;
            this.pBug.Location = game.BugPosition;
            this.pStat.Location = game.StatPosition;
            this.pCredits.Location = new Point((this.Width / 2) - (this.pCredits.Width / 2),
                                               (this.Height / 2) - (this.pCredits.Height / 2));

            // Set images
            string imgStr = "";
            imgStr = "tip_l" + (game.BallPossession == 1 ? "p" : "");
            if (!leftTipImage.Equals(imgStr))
                pLeftTip.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject(imgStr);
            leftTipImage = string.Copy(imgStr);

            imgStr = "tip_r" + (game.BallPossession == 2 ? "p" : "");
            if (!rightTipImage.Equals(imgStr))
                pRightTip.BackgroundImage = (Image)TETV_ScoreBar.Properties.Resources.ResourceManager.GetObject(imgStr);
            rightTipImage = string.Copy(imgStr);

            pBug.Visible = showBug;
            pStat.Visible = showStats;

            // Show left score
            if (usingDoubleScores) {
                ShowBarSegment(pScoreLD, pBar);
                HideBarSegment(pScoreLS, pBar);
            } else {
                HideBarSegment(pScoreLD, pBar);
                ShowBarSegment(pScoreLS, pBar);
            }

            // Show period
            if (showPeriod) {
                ShowBarSegment(pPeriodDivider, pBar);
                ShowBarSegment(pPeriod, pBar);
            } else {
                HideBarSegment(pPeriodDivider, pBar);
                HideBarSegment(pPeriod, pBar);
            }

            // Show clock
            if (showClock) {
                ShowBarSegment(pClockDivider, pBar);
                ShowBarSegment(pClock, pBar);
            } else {
                HideBarSegment(pClockDivider, pBar);
                HideBarSegment(pClock, pBar);
            }

            // Show text
            if (showInfoText) {
                ShowBarSegment(pInfoTextDivider, pBar);
                ShowBarSegment(pInfoText, pBar);
            } else {
                HideBarSegment(pInfoTextDivider, pBar);
                HideBarSegment(pInfoText, pBar);
            }

            // Show right score
            if (usingDoubleScores) {
                ShowBarSegment(pScoreRD, pBar);
                HideBarSegment(pScoreRS, pBar);
            } else {
                HideBarSegment(pScoreRD, pBar);
                ShowBarSegment(pScoreRS, pBar);
            }

            // Update clocks
            lClock.Text = (game.Clock[0].ToString("D2") + ":" + game.Clock[1].ToString("D2") + (game.Clock[0] == 0 ? ":" + game.Clock[2] : ""));
            lHalfTimeClock.Text = (game.Clock[0].ToString("D2") + ":" + game.Clock[1].ToString("D2"));

            if (showTimeouts != wasShowingTimeouts) {
                pLT1.Visible = showTimeouts;
                pLT2.Visible = showTimeouts;
                pLT3.Visible = showTimeouts;
                pRT1.Visible = showTimeouts;
                pRT2.Visible = showTimeouts;
                pRT3.Visible = showTimeouts;

                if (showTimeouts) {
                    lAbbr1.Location = new Point(lAbbr1.Location.X, 5);
                    lAbbr2.Location = new Point(lAbbr2.Location.X, 5);
                } else {
                    lAbbr1.Location = new Point(lAbbr1.Location.X, 9);
                    lAbbr2.Location = new Point(lAbbr2.Location.X, 9);
                }

                wasShowingTimeouts = showTimeouts;
            }

            pLT1.BackColor = game.Timeouts[0] < 1 ? Color.Red : Color.Lime;
            pLT2.BackColor = game.Timeouts[0] < 2 ? Color.Red : Color.Lime;
            pLT3.BackColor = game.Timeouts[0] < 3 ? Color.Red : Color.Lime;

            pRT1.BackColor = game.Timeouts[1] < 1 ? Color.Red : Color.Lime;
            pRT2.BackColor = game.Timeouts[1] < 2 ? Color.Red : Color.Lime;
            pRT3.BackColor = game.Timeouts[1] < 3 ? Color.Red : Color.Lime;

            // Set credits
            tCredits.Rtf = creditsRTF;

            // Show / Hide Half Time clock
            if (showHalfTimeClock) {
                ShowBarSegment(pHalfTimeClockDivider, pHalfTime);
                ShowBarSegment(pHalfTimeClock, pHalfTime);
            } else {
                HideBarSegment(pHalfTimeClockDivider, pHalfTime);
                HideBarSegment(pHalfTimeClock, pHalfTime);
            }

            // Only update layout here (prevents redundant updates, speeds up updating)
            this.ResumeLayout(false);
            this.SuspendLayout();
        }

        public void HideButtons() {
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

        public Point HalfTimeSize {
            get { return new Point(pHalfTime.Size.Width, pHalfTime.Size.Height); }
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
            pHalfTime.Visible = true;
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
            pHalfTime.Visible = false;
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

        #region Drag and Drop

        void DragBoard(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - (pBar.Location.X + (pBar.Width / 2)), p.Y - pBar.Location.Y);
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

        void DragHalfTime(object sender, MouseEventArgs e) {
            if (!editMode) return;

            Point p = PointToClient(Cursor.Position);

            dragOffset = new Point(p.X - pHalfTime.Location.X, p.Y - pHalfTime.Location.Y);
            dragTarget = pHalfTime;
        }

        void DragStop(object sender, MouseEventArgs e) {
            if (((Control)dragTarget).Location.X < 0) ((Control)dragTarget).Location = new Point(0, ((Control)dragTarget).Location.Y);
            if (((Control)dragTarget).Location.Y < 0) ((Control)dragTarget).Location = new Point(((Control)dragTarget).Location.X, 0);

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

            if (p.X - dragOffset.X < 0) p.X = dragOffset.X;
            if (p.Y - dragOffset.Y < 0) p.Y = dragOffset.Y;
            if (dragTarget == pBar && p.X < dragOffset.X + (pBar.Width / 2)) p.X = dragOffset.X + (pBar.Width / 2);

            if (dragTarget == pBar) {
                game.ScoreBoardPosition.X = p.X - dragOffset.X;
                game.ScoreBoardPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pReplay) {
                game.ReplayPosition.X = p.X - dragOffset.X;
                game.ReplayPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pHalfTime) {
                game.HalfTimePosition.X = p.X - dragOffset.X;
                game.HalfTimePosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pBug) {
                game.BugPosition.X = p.X - dragOffset.X;
                game.BugPosition.Y = p.Y - dragOffset.Y;
            } else if (dragTarget == pStat) {
                game.StatPosition.X = p.X - dragOffset.X;
                game.StatPosition.Y = p.Y - dragOffset.Y;
            } else return;

            UpdateDisplay();
            controls.ReloadValues();
        }


        #endregion

        #region Scoreboard / Half-Time Manipulation

        void HideBarSegment(Panel segment, Panel bar) {
            if (!bar.Visible || !segment.Visible) return;

            foreach (Panel g in bar.Controls.OfType<Panel>().OrderBy(box => box.Location.X).ToList<Panel>())
                if (g.Location.X > (segment.Location.X))
                    g.Location = new Point(g.Location.X - (segment.Width), g.Location.Y);

            bar.Width -= segment.Width;

            segment.Visible = false;

            this.UpdateDisplay();
        }

        void ShowBarSegment(Panel segment, Panel bar) {
            if (!bar.Visible || segment.Visible) return;

            foreach (Panel g in bar.Controls.OfType<Panel>().OrderBy(box => box.Location.X).ToList<Panel>())
                if (g.Location.X >= (segment.Location.X) && g.Name != segment.Name)
                    g.Location = new Point(g.Location.X + (segment.Width), g.Location.Y);

            bar.Width += segment.Width;

            segment.Visible = true;

            this.UpdateDisplay();
        }

        #endregion

        #region Updating

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion

        #region Data Updating

        private delegate void DataWasUpdatedCallback();
        public void DataWasUpdated() {
            if (InvokeRequired) {
                DataWasUpdatedCallback callback = new DataWasUpdatedCallback(DataWasUpdated);
                Invoke(callback, new object[] {});
            } else {
                UpdateDisplay();
            }
        }

        #endregion
    }
}
