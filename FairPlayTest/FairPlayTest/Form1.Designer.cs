namespace FairPlayTest {
    partial class fMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tGameType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bStartStopSerial = new System.Windows.Forms.Button();
            this.cScoreboardPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tShot = new System.Windows.Forms.TextBox();
            this.tPeriod = new System.Windows.Forms.TextBox();
            this.tClock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sScoreboard = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lSerialStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tHomeTimeoutsLeft = new System.Windows.Forms.TextBox();
            this.tScoreHome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tHomeTeamName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tVisitingTeamName = new System.Windows.Forms.TextBox();
            this.tHomeScore = new System.Windows.Forms.TextBox();
            this.tScoreVisiting = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tVisitingScore = new System.Windows.Forms.TextBox();
            this.tVisitingTimeoutsLeft = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tPossession = new System.Windows.Forms.TextBox();
            this.tToGo = new System.Windows.Forms.TextBox();
            this.tDown = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // tGameType
            // 
            this.tGameType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tGameType.Location = new System.Drawing.Point(330, 19);
            this.tGameType.Name = "tGameType";
            this.tGameType.ReadOnly = true;
            this.tGameType.Size = new System.Drawing.Size(97, 20);
            this.tGameType.TabIndex = 1;
            this.tGameType.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tGameType);
            this.groupBox1.Controls.Add(this.bStartStopSerial);
            this.groupBox1.Controls.Add(this.cScoreboardPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // bStartStopSerial
            // 
            this.bStartStopSerial.Location = new System.Drawing.Point(189, 18);
            this.bStartStopSerial.Name = "bStartStopSerial";
            this.bStartStopSerial.Size = new System.Drawing.Size(75, 23);
            this.bStartStopSerial.TabIndex = 2;
            this.bStartStopSerial.Text = "Connect";
            this.bStartStopSerial.UseVisualStyleBackColor = true;
            this.bStartStopSerial.Click += new System.EventHandler(this.bStartStopSerial_Click);
            // 
            // cScoreboardPort
            // 
            this.cScoreboardPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cScoreboardPort.FormattingEnabled = true;
            this.cScoreboardPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cScoreboardPort.Location = new System.Drawing.Point(96, 19);
            this.cScoreboardPort.Name = "cScoreboardPort";
            this.cScoreboardPort.Size = new System.Drawing.Size(87, 21);
            this.cScoreboardPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scoreboard Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tShot);
            this.groupBox2.Controls.Add(this.tPeriod);
            this.groupBox2.Controls.Add(this.tClock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clock Info";
            // 
            // tShot
            // 
            this.tShot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tShot.Location = new System.Drawing.Point(285, 22);
            this.tShot.Name = "tShot";
            this.tShot.ReadOnly = true;
            this.tShot.Size = new System.Drawing.Size(53, 20);
            this.tShot.TabIndex = 1;
            this.tShot.WordWrap = false;
            // 
            // tPeriod
            // 
            this.tPeriod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tPeriod.Location = new System.Drawing.Point(178, 22);
            this.tPeriod.Name = "tPeriod";
            this.tPeriod.ReadOnly = true;
            this.tPeriod.Size = new System.Drawing.Size(38, 20);
            this.tPeriod.TabIndex = 1;
            this.tPeriod.WordWrap = false;
            // 
            // tClock
            // 
            this.tClock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tClock.Location = new System.Drawing.Point(46, 22);
            this.tClock.Name = "tClock";
            this.tClock.ReadOnly = true;
            this.tClock.Size = new System.Drawing.Size(58, 20);
            this.tClock.TabIndex = 1;
            this.tClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tClock.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Shot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clock";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lSerialStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(473, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Connection Status:";
            // 
            // lSerialStatus
            // 
            this.lSerialStatus.ForeColor = System.Drawing.Color.Red;
            this.lSerialStatus.Name = "lSerialStatus";
            this.lSerialStatus.Size = new System.Drawing.Size(79, 17);
            this.lSerialStatus.Text = "Disconnected";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tHomeTimeoutsLeft);
            this.groupBox3.Controls.Add(this.tScoreHome);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tHomeTeamName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Home Team";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Timeouts Left";
            // 
            // tHomeTimeoutsLeft
            // 
            this.tHomeTimeoutsLeft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tHomeTimeoutsLeft.Location = new System.Drawing.Point(108, 71);
            this.tHomeTimeoutsLeft.Name = "tHomeTimeoutsLeft";
            this.tHomeTimeoutsLeft.ReadOnly = true;
            this.tHomeTimeoutsLeft.Size = new System.Drawing.Size(38, 20);
            this.tHomeTimeoutsLeft.TabIndex = 1;
            this.tHomeTimeoutsLeft.WordWrap = false;
            // 
            // tScoreHome
            // 
            this.tScoreHome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tScoreHome.Location = new System.Drawing.Point(108, 45);
            this.tScoreHome.Name = "tScoreHome";
            this.tScoreHome.ReadOnly = true;
            this.tScoreHome.Size = new System.Drawing.Size(38, 20);
            this.tScoreHome.TabIndex = 1;
            this.tScoreHome.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Score";
            // 
            // tHomeTeamName
            // 
            this.tHomeTeamName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tHomeTeamName.Location = new System.Drawing.Point(108, 19);
            this.tHomeTeamName.Name = "tHomeTeamName";
            this.tHomeTeamName.ReadOnly = true;
            this.tHomeTeamName.Size = new System.Drawing.Size(75, 20);
            this.tHomeTeamName.TabIndex = 1;
            this.tHomeTeamName.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Home Team Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Visiting Team Name";
            // 
            // tVisitingTeamName
            // 
            this.tVisitingTeamName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tVisitingTeamName.Location = new System.Drawing.Point(108, 19);
            this.tVisitingTeamName.Name = "tVisitingTeamName";
            this.tVisitingTeamName.ReadOnly = true;
            this.tVisitingTeamName.Size = new System.Drawing.Size(75, 20);
            this.tVisitingTeamName.TabIndex = 1;
            this.tVisitingTeamName.WordWrap = false;
            // 
            // tHomeScore
            // 
            this.tHomeScore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tHomeScore.Location = new System.Drawing.Point(108, 45);
            this.tHomeScore.Name = "tHomeScore";
            this.tHomeScore.ReadOnly = true;
            this.tHomeScore.Size = new System.Drawing.Size(38, 20);
            this.tHomeScore.TabIndex = 1;
            this.tHomeScore.WordWrap = false;
            // 
            // tScoreVisiting
            // 
            this.tScoreVisiting.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tScoreVisiting.Location = new System.Drawing.Point(108, 45);
            this.tScoreVisiting.Name = "tScoreVisiting";
            this.tScoreVisiting.ReadOnly = true;
            this.tScoreVisiting.Size = new System.Drawing.Size(38, 20);
            this.tScoreVisiting.TabIndex = 1;
            this.tScoreVisiting.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Score";
            // 
            // tVisitingScore
            // 
            this.tVisitingScore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tVisitingScore.Location = new System.Drawing.Point(108, 45);
            this.tVisitingScore.Name = "tVisitingScore";
            this.tVisitingScore.ReadOnly = true;
            this.tVisitingScore.Size = new System.Drawing.Size(38, 20);
            this.tVisitingScore.TabIndex = 1;
            this.tVisitingScore.WordWrap = false;
            // 
            // tVisitingTimeoutsLeft
            // 
            this.tVisitingTimeoutsLeft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tVisitingTimeoutsLeft.Location = new System.Drawing.Point(108, 71);
            this.tVisitingTimeoutsLeft.Name = "tVisitingTimeoutsLeft";
            this.tVisitingTimeoutsLeft.ReadOnly = true;
            this.tVisitingTimeoutsLeft.Size = new System.Drawing.Size(38, 20);
            this.tVisitingTimeoutsLeft.TabIndex = 1;
            this.tVisitingTimeoutsLeft.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Timeouts Left";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tVisitingTeamName);
            this.groupBox4.Controls.Add(this.tVisitingTimeoutsLeft);
            this.groupBox4.Controls.Add(this.tScoreVisiting);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tVisitingScore);
            this.groupBox4.Location = new System.Drawing.Point(234, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visiting Team";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tPossession);
            this.groupBox5.Controls.Add(this.tToGo);
            this.groupBox5.Controls.Add(this.tDown);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(12, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 51);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Game Info";
            // 
            // tPossession
            // 
            this.tPossession.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tPossession.Location = new System.Drawing.Point(315, 22);
            this.tPossession.Name = "tPossession";
            this.tPossession.ReadOnly = true;
            this.tPossession.Size = new System.Drawing.Size(112, 20);
            this.tPossession.TabIndex = 1;
            this.tPossession.WordWrap = false;
            // 
            // tToGo
            // 
            this.tToGo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tToGo.Location = new System.Drawing.Point(175, 22);
            this.tToGo.Name = "tToGo";
            this.tToGo.ReadOnly = true;
            this.tToGo.Size = new System.Drawing.Size(38, 20);
            this.tToGo.TabIndex = 1;
            this.tToGo.WordWrap = false;
            // 
            // tDown
            // 
            this.tDown.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tDown.Location = new System.Drawing.Point(44, 22);
            this.tDown.Name = "tDown";
            this.tDown.ReadOnly = true;
            this.tDown.Size = new System.Drawing.Size(58, 20);
            this.tDown.TabIndex = 1;
            this.tDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tDown.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Possession";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "To Go";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Down";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "Fair-Play Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tGameType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort sScoreboard;
        private System.Windows.Forms.ComboBox cScoreboardPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStartStopSerial;
        private System.Windows.Forms.TextBox tClock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tShot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lSerialStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tHomeTeamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tVisitingTeamName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tHomeTimeoutsLeft;
        private System.Windows.Forms.TextBox tScoreHome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tHomeScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tVisitingTimeoutsLeft;
        private System.Windows.Forms.TextBox tVisitingScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tScoreVisiting;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tPossession;
        private System.Windows.Forms.TextBox tToGo;
        private System.Windows.Forms.TextBox tDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

