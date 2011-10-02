using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Scoreboard_Communication;

namespace FairPlayTest {
    public partial class fMain : Form {
        private ScoreboardInterface scoreboard;
        private bool connected = false;
        private Thread scoreboardThread = null;

        #region Form Initialization

        public fMain() {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(this.fMain_FormClosing);

            scoreboard = new ScoreboardInterface();
            scoreboard.StatusChanged += new SerialConnectionStatusChanged(this.StatusChanged);
            scoreboard.DisplayException += new PassException(this.DisplayException);
            scoreboard.GameClockUpdated += new GameClockRecordUpdated(this.GameClockRecordUpdated);
            scoreboard.FootballUpdated += new FootballRecordUpdated(this.FootballRecordUpdated);
            scoreboard.SoccerUpdated += new SoccerRecordUpdated(this.SoccerRecordUpdated);
            scoreboardThread = new Thread(scoreboard.StartThread);
            scoreboardThread.Start();

            cScoreboardPort.Text = "COM1";
        }

        #endregion

        #region Delegates

        public void StatusChanged(bool status) {
            try {
                connected = status;

                lSerialStatus.Text = (status ? "Connected" : "Disconnected");
                lSerialStatus.ForeColor = (status ? Color.Green : Color.Red);
                bStartStopSerial.Text = (status ? "Disconnect" : "Connect");
                cScoreboardPort.Enabled = !status;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayException(Exception e) {
            MessageBox.Show(e.Message, "Error (" + e.TargetSite + ")");
        }

        private delegate void GameClockRecordUpdatedCallback(Game_Clock_Record record);
        public void GameClockRecordUpdated(Game_Clock_Record record) {
            if (InvokeRequired) {
                GameClockRecordUpdatedCallback callback = new GameClockRecordUpdatedCallback(GameClockRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                if (record.ClockChanged) {
                    tClock.Text = (record.Clock[0] + ":" + record.Clock[1] + ":" + record.Clock[2]);
                }
                if (record.PeriodChanged) {
                    tPeriod.Text = record.Period.ToString();
                }
                if (record.ShotChanged) {
                    tShot.Text = record.Shot.ToString();
                }
            }
        }

        private delegate void FootballRecordUpdatedCallback(Football_Record record);
        public void FootballRecordUpdated(Football_Record record) {
            if (InvokeRequired) {
                FootballRecordUpdatedCallback callback = new FootballRecordUpdatedCallback(FootballRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                tGameType.Text = "Football";
                if (record.TeamNameChanged) {
                    tHomeTeamName.Text = record.TeamName[0];
                    tVisitingTeamName.Text = record.TeamName[1];
                }
                if (record.ScoreChanged) {
                    tScoreHome.Text = record.Score[0].ToString();
                    tScoreVisiting.Text = record.Score[1].ToString();
                }
                if (record.TimeoutsLeftChanged) {
                    tHomeTimeoutsLeft.Text = record.TimeoutsLeft[0].ToString();
                    tVisitingTimeoutsLeft.Text = record.TimeoutsLeft[1].ToString();
                }
                if (record.DownChanged) {
                    tDown.Text = record.Down.ToString();
                }
                if (record.ToGoChanged) {
                    tToGo.Text = record.ToGo.ToString();
                }
                if (record.PossessionChanged) {
                    tPossession.Text = record.Possession.ToString();
                }
            }
        }

        private delegate void SoccerRecordUpdatedCallback(Soccer_Record record);
        public void SoccerRecordUpdated(Soccer_Record record) {
            if (InvokeRequired) {
                SoccerRecordUpdatedCallback callback = new SoccerRecordUpdatedCallback(SoccerRecordUpdated);
                Invoke(callback, new object[] { record });
            } else {
                tGameType.Text = "Soccer";
            }
        }

        #endregion

        #region Form Events

        public void fMain_FormClosing(Object sender, FormClosingEventArgs e) {
            scoreboard.StopThread();
        }

        private void bStartStopSerial_Click(object sender, EventArgs e) {
            if (connected)
                scoreboard.StopSerialConnection();
            else
                scoreboard.StartSerialConnection(cScoreboardPort.Text);
        }

        #endregion
    }
}