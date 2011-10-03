using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TETV_ScoreBar {
    public partial class Settings : Form {
        Display display;
        Game game;
        int screen;
        static Screen[] screens;
        bool hasLoaded = false;
        Controls controls;

        #region Constructors

        public Settings(Game game) {
            try {
                this.game = game;
                InitializeComponent();

                // Load settings and set fields
                LoadForm();

                // Create and show display
                display = new Display(game, this);
                display.Show();
                HandleValueChange();

                // Initial privew states
                display.showClock = cPreviewClock.Checked = Config.GetBool(ConfigKey.ShowClock);
                display.showInfoText = cPreviewInfoText.Checked = Config.GetBool(ConfigKey.ShowInfoText);
                display.UpdateDisplay();

            } catch (Exception e) {
                MessageBox.Show(e.ToString(), "Unhandled Exception in Settings");
            }
        }

        #endregion

        #region GUI Management

        public void DisableDisplayButtons() {
            //bSwap.Enabled = false;
        }

        void HandleValueChange() {
            display.showStats = pStatPosition.Enabled = cGameType.SelectedItem.Equals("Basketball") || cGameType.SelectedItem.Equals("Wrestling");
            display.usingDoubleScores = cGameType.SelectedItem.Equals("Volleyball") || cGameType.SelectedItem.Equals("Wrestling");
            display.showPeriod = !(cGameType.SelectedItem.Equals("Volleyball"));
            display.showTimeouts = cGameType.SelectedItem.Equals("Football");
            if (display != null)
                display.UpdateDisplay();
            this.Focus();
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

        public void SwapControlsAndDisplay() {
            int DisplayScreen = display.screen;
            display.screen = screen;
            screen = DisplayScreen;
            display.UpdateDisplay();
            SetScreen();
            HandleValueChange();
        }

        #endregion

        #region Saving / Loading form

        void LoadForm() {
            hasLoaded = false;

            // Get screen from config
            screen = Config.GetInt(ConfigKey.ControlScreen);

            // Set screen
            SetScreen();

            // Set form fields
            nBoardX.Value = game.ScoreBoardPosition.X;
            nBoardY.Value = game.ScoreBoardPosition.Y;
            nReplayX.Value = game.ReplayPosition.X;
            nReplayY.Value = game.ReplayPosition.Y;
            nHalfTimeX.Value = game.HalfTimePosition.X;
            nHalfTimeY.Value = game.HalfTimePosition.Y;
            nBugX.Value = game.BugPosition.X;
            nBugY.Value = game.BugPosition.Y;
            nStatX.Value = game.StatPosition.X;
            nStatY.Value = game.StatPosition.Y;
            tAbbr1.Text = game.TeamAbbr[0];
            tAbbr2.Text = game.TeamAbbr[1];

            // Set game type dropdown
            cGameType.ResetText();
            cGameType.DataSource = Enum.GetNames(typeof(GameType));
            cGameType.SelectedIndex = (int)game.gameType;

            hasLoaded = true;
        }

        public void ReloadValues() {
            hasLoaded = false;
            nBoardX.Value = game.ScoreBoardPosition.X;
            nBoardY.Value = game.ScoreBoardPosition.Y;
            nReplayX.Value = game.ReplayPosition.X;
            nReplayY.Value = game.ReplayPosition.Y;
            nHalfTimeX.Value = game.HalfTimePosition.X;
            nHalfTimeY.Value = game.HalfTimePosition.Y;
            nBugX.Value = game.BugPosition.X;
            nBugY.Value = game.BugPosition.Y;
            nStatX.Value = game.StatPosition.X;
            nStatY.Value = game.StatPosition.Y;
            hasLoaded = true;
        }

        void SaveForm() {
            Config.SetValue(ConfigKey.BoardX, game.ScoreBoardPosition.X);
            Config.SetValue(ConfigKey.BoardY, game.ScoreBoardPosition.Y);
            Config.SetValue(ConfigKey.ReplayX, game.ReplayPosition.X);
            Config.SetValue(ConfigKey.ReplayY, game.ReplayPosition.Y);
            Config.SetValue(ConfigKey.HalfTimeX, game.HalfTimePosition.X);
            Config.SetValue(ConfigKey.HalfTimeY, game.HalfTimePosition.Y);
            Config.SetValue(ConfigKey.BugX, game.BugPosition.X);
            Config.SetValue(ConfigKey.BugY, game.BugPosition.Y);
            Config.SetValue(ConfigKey.StatX, game.StatPosition.X);
            Config.SetValue(ConfigKey.StatY, game.StatPosition.Y);
            Config.SetValue(ConfigKey.ControlScreen, screen);
            Config.SetValue(ConfigKey.DisplayScreen, display.screen);
            Config.SetValue(ConfigKey.GameType, (int)game.gameType);
            Config.Save();
        }

        #endregion

        #region Bottom Buttons

        private void bSave_Click(object sender, EventArgs e) {
            // Save and hide Settings form
            SaveForm();
            this.SuspendLayout();
            this.Hide();

            // Set game to active
            game.active = true;

            // Hide swap button on Display
            display.HideButtons();

            // Create and show Controls form
            controls = new Controls(game, display);
            controls.Show();

            // Set Display's owner as Controls so that everything closes with Controls
            display.Owner = controls;
        }

        private void bSwap_Click(object sender, EventArgs e) {
            SwapControlsAndDisplay();
        }

        private void bAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(TETV_ScoreBar.Program.AboutText, "About This Program");
        }

        #endregion

        #region Bar Position

        private void nBarPosition_ValueChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.ScoreBoardPosition.X = (int)nBoardX.Value;
            game.ScoreBoardPosition.Y = (int)nBoardY.Value;
            HandleValueChange();
        }

        private void bPresetTop_Click(object sender, EventArgs e) {
            nBoardY.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void bPresetBottom_Click(object sender, EventArgs e) {
            nBoardY.Value = display.Height - (display.BoardSize.Y + Display.ScreenPadding);
            HandleValueChange();
        }

        private void bPresetLeft_Click(object sender, EventArgs e) {
            nBoardX.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void bPresetCenter_Click(object sender, EventArgs e) {
            nBoardX.Value = (display.Width / 2);
            HandleValueChange();
        }

        private void bPresetRight_Click(object sender, EventArgs e) {
            nBoardX.Value = display.Width - (display.BoardSize.X + Display.ScreenPadding);
            HandleValueChange();
        }

        #endregion

        #region Replay Position

        private void nReplay_ValueChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.ReplayPosition.X = (int)nReplayX.Value;
            game.ReplayPosition.Y = (int)nReplayY.Value;
            HandleValueChange();
        }

        private void bReplayLeft_Click(object sender, EventArgs e) {
            nReplayY.Value = Display.ScreenPadding;
            nReplayX.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void bReplayRight_Click(object sender, EventArgs e) {
            nReplayY.Value = Display.ScreenPadding;
            nReplayX.Value = display.Width - (display.ReplaySize.X + Display.ScreenPadding);
            HandleValueChange();
        }

        #endregion

        #region Half Time Position

        private void nHalfTime_ValueChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.HalfTimePosition.X = (int)nHalfTimeX.Value;
            game.HalfTimePosition.Y = (int)nHalfTimeY.Value;
            HandleValueChange();
        }

        private void bHalfTimeLeft_Click(object sender, EventArgs e) {
            nHalfTimeY.Value = Display.ScreenPadding;
            nHalfTimeX.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void bHalfTimeRight_Click(object sender, EventArgs e) {
            nHalfTimeY.Value = Display.ScreenPadding;
            nHalfTimeX.Value = display.Width - (display.HalfTimeSize.X + Display.ScreenPadding);
            HandleValueChange();
        }

        #endregion

        #region Bug Position

        private void BugPositionValueChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.BugPosition.X = (int)nBugX.Value;
            game.BugPosition.Y = (int)nBugY.Value;
            HandleValueChange();
        }

        private void BugTop(object sender, EventArgs e) {
            nBugY.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void BugBottom(object sender, EventArgs e) {
            nBugY.Value = display.Height - (display.BugSize.Y + Display.ScreenPadding);
            HandleValueChange();
        }

        private void BugLeft(object sender, EventArgs e) {
            nBugX.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void BugRight(object sender, EventArgs e) {
            nBugX.Value = display.Width - (display.BugSize.X + Display.ScreenPadding);
            HandleValueChange();
        }

        #endregion

        #region Player Stat Position

        private void StatPositionValueChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.StatPosition.X = (int)nStatX.Value;
            game.StatPosition.Y = (int)nStatY.Value;
            HandleValueChange();
        }

        private void StatTop(object sender, EventArgs e) {
            nStatY.Value = Display.ScreenPadding;
            HandleValueChange();
        }

        private void StatBottom(object sender, EventArgs e) {
            nStatY.Value = display.Height - (display.StatSize.Y + Display.ScreenPadding);
            HandleValueChange();
        }

        private void StatCenter(object sender, EventArgs e) {
            nStatX.Value = (display.Width / 2) - (display.StatSize.X / 2);
            HandleValueChange();
        }

        #endregion

        #region Game Settings

        private void cGameType_SelectedIndexChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.gameType = (GameType)cGameType.SelectedIndex;
            HandleValueChange();
        }

        #endregion

        #region Team Names

        private void tAbbr1_TextChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.TeamAbbr[0] = tAbbr1.Text;
            HandleValueChange();
        }

        private void tAbbr2_TextChanged(object sender, EventArgs e) {
            if (!hasLoaded) return;
            game.TeamAbbr[1] = tAbbr2.Text;
            HandleValueChange();
        }

        #endregion

        #region Previews

        private void cPreviewClock_CheckedChanged(object sender, EventArgs e) {
            display.showClock = cPreviewClock.Checked;
            display.UpdateDisplay();
        }

        private void cPreviewInfoText_CheckedChanged(object sender, EventArgs e) {
            display.showInfoText = cPreviewInfoText.Checked;
            display.UpdateDisplay();
        }

        #endregion
    }
}
