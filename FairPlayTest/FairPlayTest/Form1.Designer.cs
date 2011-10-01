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
            this.sScoreboard = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tClock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tPeriod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tShot = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lSerialStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // tGameType
            // 
            this.tGameType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tGameType.Location = new System.Drawing.Point(346, 20);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clock";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Period";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Shot";
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
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lSerialStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(473, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lSerialStatus
            // 
            this.lSerialStatus.ForeColor = System.Drawing.Color.Red;
            this.lSerialStatus.Name = "lSerialStatus";
            this.lSerialStatus.Size = new System.Drawing.Size(79, 17);
            this.lSerialStatus.Text = "Disconnected";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Connection Status:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Info";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
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
    }
}

