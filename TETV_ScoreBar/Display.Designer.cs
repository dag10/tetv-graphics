namespace TETV_ScoreBar {
    partial class Display {
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
            this.pCredits = new System.Windows.Forms.Panel();
            this.pInnerCredits = new System.Windows.Forms.Panel();
            this.tCredits = new System.Windows.Forms.RichTextBox();
            this.pBar = new System.Windows.Forms.Panel();
            this.pScoreRD = new System.Windows.Forms.Panel();
            this.lScoreRS = new System.Windows.Forms.Label();
            this.lScoreRP = new System.Windows.Forms.Label();
            this.pRightTip = new System.Windows.Forms.Panel();
            this.pLeftTip = new System.Windows.Forms.Panel();
            this.pScoreRS = new System.Windows.Forms.Panel();
            this.lScore2 = new System.Windows.Forms.Label();
            this.pScoreLD = new System.Windows.Forms.Panel();
            this.lScoreLS = new System.Windows.Forms.Label();
            this.lScoreLP = new System.Windows.Forms.Label();
            this.pScoreLS = new System.Windows.Forms.Panel();
            this.lScore1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pClockDivider = new System.Windows.Forms.Panel();
            this.pInfoTextDivider = new System.Windows.Forms.Panel();
            this.pClock = new System.Windows.Forms.Panel();
            this.lClock = new System.Windows.Forms.Label();
            this.pPeriodDivider = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pInfoText = new System.Windows.Forms.Panel();
            this.lInfoText = new System.Windows.Forms.Label();
            this.pPeriod = new System.Windows.Forms.Panel();
            this.lQuarter = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pRT3 = new System.Windows.Forms.Panel();
            this.lAbbr2 = new System.Windows.Forms.Label();
            this.pRT2 = new System.Windows.Forms.Panel();
            this.pRT1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pLT3 = new System.Windows.Forms.Panel();
            this.pLT2 = new System.Windows.Forms.Panel();
            this.pLT1 = new System.Windows.Forms.Panel();
            this.lAbbr1 = new System.Windows.Forms.Label();
            this.pStat = new System.Windows.Forms.Panel();
            this.lStatValue3 = new System.Windows.Forms.Label();
            this.lStatField3 = new System.Windows.Forms.Label();
            this.lStatValue2 = new System.Windows.Forms.Label();
            this.lStatField2 = new System.Windows.Forms.Label();
            this.lStatValue1 = new System.Windows.Forms.Label();
            this.lStatValue0 = new System.Windows.Forms.Label();
            this.lStatField1 = new System.Windows.Forms.Label();
            this.lStatField0 = new System.Windows.Forms.Label();
            this.pBug = new System.Windows.Forms.Panel();
            this.pHalfTime = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pHalfTimeClock = new System.Windows.Forms.Panel();
            this.lHalfTimeClock = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lHalfTime = new System.Windows.Forms.Label();
            this.pHalfTimeClockDivider = new System.Windows.Forms.Panel();
            this.pReplay = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lReplay = new System.Windows.Forms.Label();
            this.pCredits.SuspendLayout();
            this.pInnerCredits.SuspendLayout();
            this.pBar.SuspendLayout();
            this.pScoreRD.SuspendLayout();
            this.pScoreRS.SuspendLayout();
            this.pScoreLD.SuspendLayout();
            this.pScoreLS.SuspendLayout();
            this.pClock.SuspendLayout();
            this.pInfoText.SuspendLayout();
            this.pPeriod.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pStat.SuspendLayout();
            this.pHalfTime.SuspendLayout();
            this.pHalfTimeClock.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pReplay.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCredits
            // 
            this.pCredits.BackColor = System.Drawing.Color.DarkGray;
            this.pCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCredits.Controls.Add(this.pInnerCredits);
            this.pCredits.Location = new System.Drawing.Point(1631, 129);
            this.pCredits.Name = "pCredits";
            this.pCredits.Size = new System.Drawing.Size(441, 537);
            this.pCredits.TabIndex = 7;
            this.pCredits.Visible = false;
            this.pCredits.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pCredits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pCredits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pCredits.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pInnerCredits
            // 
            this.pInnerCredits.BackColor = System.Drawing.Color.LightGray;
            this.pInnerCredits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInnerCredits.Controls.Add(this.tCredits);
            this.pInnerCredits.Location = new System.Drawing.Point(10, 10);
            this.pInnerCredits.Margin = new System.Windows.Forms.Padding(10);
            this.pInnerCredits.Name = "pInnerCredits";
            this.pInnerCredits.Size = new System.Drawing.Size(419, 515);
            this.pInnerCredits.TabIndex = 0;
            this.pInnerCredits.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pInnerCredits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pInnerCredits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pInnerCredits.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // tCredits
            // 
            this.tCredits.BackColor = System.Drawing.Color.LightGray;
            this.tCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.tCredits.DetectUrls = false;
            this.tCredits.ForeColor = System.Drawing.Color.Firebrick;
            this.tCredits.Location = new System.Drawing.Point(10, 0);
            this.tCredits.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tCredits.Name = "tCredits";
            this.tCredits.ReadOnly = true;
            this.tCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tCredits.Size = new System.Drawing.Size(395, 519);
            this.tCredits.TabIndex = 0;
            this.tCredits.Text = "Credits Go Here";
            this.tCredits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.tCredits.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.tCredits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.tCredits.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Controls.Add(this.pScoreRD);
            this.pBar.Controls.Add(this.pRightTip);
            this.pBar.Controls.Add(this.pLeftTip);
            this.pBar.Controls.Add(this.pScoreRS);
            this.pBar.Controls.Add(this.pScoreLD);
            this.pBar.Controls.Add(this.pScoreLS);
            this.pBar.Controls.Add(this.panel12);
            this.pBar.Controls.Add(this.pClockDivider);
            this.pBar.Controls.Add(this.pInfoTextDivider);
            this.pBar.Controls.Add(this.pClock);
            this.pBar.Controls.Add(this.pPeriodDivider);
            this.pBar.Controls.Add(this.panel13);
            this.pBar.Controls.Add(this.panel7);
            this.pBar.Controls.Add(this.pInfoText);
            this.pBar.Controls.Add(this.pPeriod);
            this.pBar.Controls.Add(this.panel14);
            this.pBar.Controls.Add(this.panel2);
            this.pBar.Location = new System.Drawing.Point(1, 362);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1309, 57);
            this.pBar.TabIndex = 4;
            this.pBar.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBar.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pScoreRD
            // 
            this.pScoreRD.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score_dr;
            this.pScoreRD.Controls.Add(this.lScoreRS);
            this.pScoreRD.Controls.Add(this.lScoreRP);
            this.pScoreRD.Location = new System.Drawing.Point(862, 0);
            this.pScoreRD.Margin = new System.Windows.Forms.Padding(0);
            this.pScoreRD.Name = "pScoreRD";
            this.pScoreRD.Size = new System.Drawing.Size(180, 57);
            this.pScoreRD.TabIndex = 7;
            this.pScoreRD.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pScoreRD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pScoreRD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pScoreRD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pScoreRD.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lScoreRS
            // 
            this.lScoreRS.AutoSize = true;
            this.lScoreRS.BackColor = System.Drawing.Color.Transparent;
            this.lScoreRS.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreRS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScoreRS.Location = new System.Drawing.Point(112, 15);
            this.lScoreRS.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScoreRS.Name = "lScoreRS";
            this.lScoreRS.Size = new System.Drawing.Size(50, 25);
            this.lScoreRS.TabIndex = 6;
            this.lScoreRS.Text = "0";
            this.lScoreRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScoreRS.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScoreRS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScoreRS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScoreRS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScoreRS.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lScoreRP
            // 
            this.lScoreRP.AutoSize = true;
            this.lScoreRP.BackColor = System.Drawing.Color.Transparent;
            this.lScoreRP.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreRP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScoreRP.Location = new System.Drawing.Point(34, 11);
            this.lScoreRP.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScoreRP.Name = "lScoreRP";
            this.lScoreRP.Size = new System.Drawing.Size(50, 32);
            this.lScoreRP.TabIndex = 5;
            this.lScoreRP.Text = "0";
            this.lScoreRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScoreRP.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScoreRP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScoreRP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScoreRP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScoreRP.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRightTip
            // 
            this.pRightTip.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_r;
            this.pRightTip.Location = new System.Drawing.Point(1250, 0);
            this.pRightTip.Margin = new System.Windows.Forms.Padding(0);
            this.pRightTip.Name = "pRightTip";
            this.pRightTip.Size = new System.Drawing.Size(55, 57);
            this.pRightTip.TabIndex = 5;
            this.pRightTip.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pRightTip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pRightTip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pRightTip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pRightTip.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pLeftTip
            // 
            this.pLeftTip.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_l;
            this.pLeftTip.Location = new System.Drawing.Point(0, 0);
            this.pLeftTip.Margin = new System.Windows.Forms.Padding(0);
            this.pLeftTip.Name = "pLeftTip";
            this.pLeftTip.Size = new System.Drawing.Size(55, 57);
            this.pLeftTip.TabIndex = 5;
            this.pLeftTip.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pLeftTip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pLeftTip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pLeftTip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pLeftTip.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pScoreRS
            // 
            this.pScoreRS.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score;
            this.pScoreRS.Controls.Add(this.lScore2);
            this.pScoreRS.Location = new System.Drawing.Point(1042, 0);
            this.pScoreRS.Margin = new System.Windows.Forms.Padding(0);
            this.pScoreRS.Name = "pScoreRS";
            this.pScoreRS.Size = new System.Drawing.Size(117, 57);
            this.pScoreRS.TabIndex = 5;
            this.pScoreRS.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pScoreRS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pScoreRS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pScoreRS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pScoreRS.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.BackColor = System.Drawing.Color.Transparent;
            this.lScore2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScore2.Location = new System.Drawing.Point(34, 10);
            this.lScore2.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(50, 32);
            this.lScore2.TabIndex = 5;
            this.lScore2.Text = "0";
            this.lScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScore2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScore2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScore2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScore2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScore2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pScoreLD
            // 
            this.pScoreLD.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score_dl;
            this.pScoreLD.Controls.Add(this.lScoreLS);
            this.pScoreLD.Controls.Add(this.lScoreLP);
            this.pScoreLD.Location = new System.Drawing.Point(146, 0);
            this.pScoreLD.Margin = new System.Windows.Forms.Padding(0);
            this.pScoreLD.Name = "pScoreLD";
            this.pScoreLD.Size = new System.Drawing.Size(180, 57);
            this.pScoreLD.TabIndex = 5;
            this.pScoreLD.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pScoreLD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pScoreLD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pScoreLD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pScoreLD.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lScoreLS
            // 
            this.lScoreLS.AutoSize = true;
            this.lScoreLS.BackColor = System.Drawing.Color.Transparent;
            this.lScoreLS.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreLS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScoreLS.Location = new System.Drawing.Point(18, 15);
            this.lScoreLS.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScoreLS.Name = "lScoreLS";
            this.lScoreLS.Size = new System.Drawing.Size(50, 25);
            this.lScoreLS.TabIndex = 6;
            this.lScoreLS.Text = "0";
            this.lScoreLS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScoreLP
            // 
            this.lScoreLP.AutoSize = true;
            this.lScoreLP.BackColor = System.Drawing.Color.Transparent;
            this.lScoreLP.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreLP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScoreLP.Location = new System.Drawing.Point(96, 10);
            this.lScoreLP.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScoreLP.Name = "lScoreLP";
            this.lScoreLP.Size = new System.Drawing.Size(50, 32);
            this.lScoreLP.TabIndex = 5;
            this.lScoreLP.Text = "0";
            this.lScoreLP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScoreLP.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScoreLP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScoreLP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScoreLP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScoreLP.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pScoreLS
            // 
            this.pScoreLS.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score;
            this.pScoreLS.Controls.Add(this.lScore1);
            this.pScoreLS.Location = new System.Drawing.Point(326, 0);
            this.pScoreLS.Margin = new System.Windows.Forms.Padding(0);
            this.pScoreLS.Name = "pScoreLS";
            this.pScoreLS.Size = new System.Drawing.Size(117, 57);
            this.pScoreLS.TabIndex = 5;
            this.pScoreLS.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pScoreLS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pScoreLS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pScoreLS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pScoreLS.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.BackColor = System.Drawing.Color.Transparent;
            this.lScore1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScore1.Location = new System.Drawing.Point(32, 10);
            this.lScore1.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(50, 32);
            this.lScore1.TabIndex = 5;
            this.lScore1.Text = "0";
            this.lScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScore1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScore1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScore1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScore1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScore1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.panel12.Location = new System.Drawing.Point(852, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 57);
            this.panel12.TabIndex = 5;
            this.panel12.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel12.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pClockDivider
            // 
            this.pClockDivider.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.pClockDivider.Location = new System.Drawing.Point(723, 0);
            this.pClockDivider.Margin = new System.Windows.Forms.Padding(0);
            this.pClockDivider.Name = "pClockDivider";
            this.pClockDivider.Size = new System.Drawing.Size(5, 57);
            this.pClockDivider.TabIndex = 5;
            this.pClockDivider.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pClockDivider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pClockDivider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pClockDivider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pClockDivider.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pInfoTextDivider
            // 
            this.pInfoTextDivider.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.pInfoTextDivider.Location = new System.Drawing.Point(535, 0);
            this.pInfoTextDivider.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoTextDivider.Name = "pInfoTextDivider";
            this.pInfoTextDivider.Size = new System.Drawing.Size(5, 57);
            this.pInfoTextDivider.TabIndex = 5;
            this.pInfoTextDivider.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pInfoTextDivider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pInfoTextDivider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pInfoTextDivider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pInfoTextDivider.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pClock
            // 
            this.pClock.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.pClock.Controls.Add(this.lClock);
            this.pClock.Location = new System.Drawing.Point(728, 0);
            this.pClock.Margin = new System.Windows.Forms.Padding(0);
            this.pClock.Name = "pClock";
            this.pClock.Size = new System.Drawing.Size(124, 57);
            this.pClock.TabIndex = 5;
            this.pClock.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pClock.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lClock
            // 
            this.lClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lClock.BackColor = System.Drawing.Color.Transparent;
            this.lClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClock.ForeColor = System.Drawing.Color.Black;
            this.lClock.Location = new System.Drawing.Point(1, 9);
            this.lClock.Margin = new System.Windows.Forms.Padding(0);
            this.lClock.Name = "lClock";
            this.lClock.Size = new System.Drawing.Size(123, 40);
            this.lClock.TabIndex = 5;
            this.lClock.Text = "00:00:0";
            this.lClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lClock.UseCompatibleTextRendering = true;
            this.lClock.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lClock.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pPeriodDivider
            // 
            this.pPeriodDivider.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.pPeriodDivider.Location = new System.Drawing.Point(448, 0);
            this.pPeriodDivider.Margin = new System.Windows.Forms.Padding(0);
            this.pPeriodDivider.Name = "pPeriodDivider";
            this.pPeriodDivider.Size = new System.Drawing.Size(5, 57);
            this.pPeriodDivider.TabIndex = 5;
            this.pPeriodDivider.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pPeriodDivider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pPeriodDivider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pPeriodDivider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pPeriodDivider.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel13.Location = new System.Drawing.Point(857, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 57);
            this.panel13.TabIndex = 5;
            this.panel13.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel13.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel7.Location = new System.Drawing.Point(443, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 57);
            this.panel7.TabIndex = 5;
            this.panel7.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel7.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pInfoText
            // 
            this.pInfoText.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.pInfoText.Controls.Add(this.lInfoText);
            this.pInfoText.Location = new System.Drawing.Point(540, 0);
            this.pInfoText.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoText.Name = "pInfoText";
            this.pInfoText.Size = new System.Drawing.Size(183, 57);
            this.pInfoText.TabIndex = 5;
            this.pInfoText.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pInfoText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pInfoText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pInfoText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pInfoText.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lInfoText
            // 
            this.lInfoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lInfoText.AutoSize = true;
            this.lInfoText.BackColor = System.Drawing.Color.Transparent;
            this.lInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lInfoText.ForeColor = System.Drawing.Color.Black;
            this.lInfoText.Location = new System.Drawing.Point(1, 9);
            this.lInfoText.Margin = new System.Windows.Forms.Padding(0);
            this.lInfoText.MinimumSize = new System.Drawing.Size(180, 0);
            this.lInfoText.Name = "lInfoText";
            this.lInfoText.Size = new System.Drawing.Size(180, 37);
            this.lInfoText.TabIndex = 5;
            this.lInfoText.Text = "1st && 10";
            this.lInfoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lInfoText.UseCompatibleTextRendering = true;
            this.lInfoText.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lInfoText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lInfoText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lInfoText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lInfoText.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pPeriod
            // 
            this.pPeriod.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.pPeriod.Controls.Add(this.lQuarter);
            this.pPeriod.Location = new System.Drawing.Point(453, 0);
            this.pPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.pPeriod.Name = "pPeriod";
            this.pPeriod.Size = new System.Drawing.Size(82, 57);
            this.pPeriod.TabIndex = 5;
            this.pPeriod.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pPeriod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pPeriod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pPeriod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pPeriod.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lQuarter
            // 
            this.lQuarter.AutoSize = true;
            this.lQuarter.BackColor = System.Drawing.Color.Transparent;
            this.lQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lQuarter.ForeColor = System.Drawing.Color.Black;
            this.lQuarter.Location = new System.Drawing.Point(15, 9);
            this.lQuarter.MinimumSize = new System.Drawing.Size(50, 0);
            this.lQuarter.Name = "lQuarter";
            this.lQuarter.Size = new System.Drawing.Size(54, 31);
            this.lQuarter.TabIndex = 5;
            this.lQuarter.Text = "1st";
            this.lQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lQuarter.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lQuarter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lQuarter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lQuarter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lQuarter.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel14.Controls.Add(this.pRT3);
            this.panel14.Controls.Add(this.lAbbr2);
            this.panel14.Controls.Add(this.pRT2);
            this.panel14.Controls.Add(this.pRT1);
            this.panel14.Location = new System.Drawing.Point(1159, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(91, 57);
            this.panel14.TabIndex = 5;
            this.panel14.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel14.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRT3
            // 
            this.pRT3.BackColor = System.Drawing.Color.Lime;
            this.pRT3.Location = new System.Drawing.Point(61, 41);
            this.pRT3.Name = "pRT3";
            this.pRT3.Size = new System.Drawing.Size(23, 5);
            this.pRT3.TabIndex = 6;
            // 
            // lAbbr2
            // 
            this.lAbbr2.AutoSize = true;
            this.lAbbr2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAbbr2.ForeColor = System.Drawing.Color.Black;
            this.lAbbr2.Location = new System.Drawing.Point(7, 5);
            this.lAbbr2.Name = "lAbbr2";
            this.lAbbr2.Size = new System.Drawing.Size(74, 35);
            this.lAbbr2.TabIndex = 5;
            this.lAbbr2.Text = "CHS";
            this.lAbbr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAbbr2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAbbr2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAbbr2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAbbr2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAbbr2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRT2
            // 
            this.pRT2.BackColor = System.Drawing.Color.Lime;
            this.pRT2.Location = new System.Drawing.Point(32, 41);
            this.pRT2.Name = "pRT2";
            this.pRT2.Size = new System.Drawing.Size(23, 5);
            this.pRT2.TabIndex = 6;
            // 
            // pRT1
            // 
            this.pRT1.BackColor = System.Drawing.Color.Lime;
            this.pRT1.Location = new System.Drawing.Point(3, 41);
            this.pRT1.Name = "pRT1";
            this.pRT1.Size = new System.Drawing.Size(23, 5);
            this.pRT1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel2.Controls.Add(this.pLT3);
            this.panel2.Controls.Add(this.pLT2);
            this.panel2.Controls.Add(this.pLT1);
            this.panel2.Controls.Add(this.lAbbr1);
            this.panel2.Location = new System.Drawing.Point(55, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 57);
            this.panel2.TabIndex = 5;
            this.panel2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pLT3
            // 
            this.pLT3.BackColor = System.Drawing.Color.Lime;
            this.pLT3.Location = new System.Drawing.Point(60, 41);
            this.pLT3.Name = "pLT3";
            this.pLT3.Size = new System.Drawing.Size(23, 5);
            this.pLT3.TabIndex = 6;
            // 
            // pLT2
            // 
            this.pLT2.BackColor = System.Drawing.Color.Lime;
            this.pLT2.Location = new System.Drawing.Point(31, 41);
            this.pLT2.Name = "pLT2";
            this.pLT2.Size = new System.Drawing.Size(23, 5);
            this.pLT2.TabIndex = 6;
            // 
            // pLT1
            // 
            this.pLT1.BackColor = System.Drawing.Color.Lime;
            this.pLT1.Location = new System.Drawing.Point(2, 41);
            this.pLT1.Name = "pLT1";
            this.pLT1.Size = new System.Drawing.Size(23, 5);
            this.pLT1.TabIndex = 6;
            // 
            // lAbbr1
            // 
            this.lAbbr1.AutoSize = true;
            this.lAbbr1.BackColor = System.Drawing.Color.Transparent;
            this.lAbbr1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAbbr1.ForeColor = System.Drawing.Color.Black;
            this.lAbbr1.Location = new System.Drawing.Point(10, 5);
            this.lAbbr1.Name = "lAbbr1";
            this.lAbbr1.Size = new System.Drawing.Size(74, 35);
            this.lAbbr1.TabIndex = 5;
            this.lAbbr1.Text = "CHS";
            this.lAbbr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAbbr1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAbbr1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAbbr1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAbbr1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAbbr1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pStat
            // 
            this.pStat.BackColor = System.Drawing.Color.Transparent;
            this.pStat.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.stats;
            this.pStat.Controls.Add(this.lStatValue3);
            this.pStat.Controls.Add(this.lStatField3);
            this.pStat.Controls.Add(this.lStatValue2);
            this.pStat.Controls.Add(this.lStatField2);
            this.pStat.Controls.Add(this.lStatValue1);
            this.pStat.Controls.Add(this.lStatValue0);
            this.pStat.Controls.Add(this.lStatField1);
            this.pStat.Controls.Add(this.lStatField0);
            this.pStat.ForeColor = System.Drawing.Color.Transparent;
            this.pStat.Location = new System.Drawing.Point(37, 166);
            this.pStat.Name = "pStat";
            this.pStat.Size = new System.Drawing.Size(844, 100);
            this.pStat.TabIndex = 8;
            this.pStat.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pStat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pStat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragStat);
            this.pStat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pStat.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatValue3
            // 
            this.lStatValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatValue3.AutoSize = true;
            this.lStatValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatValue3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatValue3.Location = new System.Drawing.Point(677, 55);
            this.lStatValue3.Margin = new System.Windows.Forms.Padding(0);
            this.lStatValue3.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatValue3.Name = "lStatValue3";
            this.lStatValue3.Size = new System.Drawing.Size(79, 34);
            this.lStatValue3.TabIndex = 5;
            this.lStatValue3.Text = "Field2";
            this.lStatValue3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatValue3.UseCompatibleTextRendering = true;
            this.lStatValue3.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatValue3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatValue3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatValue3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatValue3.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatField3
            // 
            this.lStatField3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatField3.AutoSize = true;
            this.lStatField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatField3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatField3.Location = new System.Drawing.Point(677, 8);
            this.lStatField3.Margin = new System.Windows.Forms.Padding(0);
            this.lStatField3.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatField3.Name = "lStatField3";
            this.lStatField3.Size = new System.Drawing.Size(79, 34);
            this.lStatField3.TabIndex = 5;
            this.lStatField3.Text = "Field2";
            this.lStatField3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatField3.UseCompatibleTextRendering = true;
            this.lStatField3.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatField3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatField3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatField3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatField3.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatValue2
            // 
            this.lStatValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatValue2.AutoSize = true;
            this.lStatValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatValue2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatValue2.Location = new System.Drawing.Point(565, 55);
            this.lStatValue2.Margin = new System.Windows.Forms.Padding(0);
            this.lStatValue2.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatValue2.Name = "lStatValue2";
            this.lStatValue2.Size = new System.Drawing.Size(79, 34);
            this.lStatValue2.TabIndex = 5;
            this.lStatValue2.Text = "Field1";
            this.lStatValue2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatValue2.UseCompatibleTextRendering = true;
            this.lStatValue2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatValue2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatValue2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatValue2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatValue2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatField2
            // 
            this.lStatField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatField2.AutoSize = true;
            this.lStatField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatField2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatField2.Location = new System.Drawing.Point(565, 8);
            this.lStatField2.Margin = new System.Windows.Forms.Padding(0);
            this.lStatField2.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatField2.Name = "lStatField2";
            this.lStatField2.Size = new System.Drawing.Size(79, 34);
            this.lStatField2.TabIndex = 5;
            this.lStatField2.Text = "Field1";
            this.lStatField2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatField2.UseCompatibleTextRendering = true;
            this.lStatField2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatField2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatField2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatField2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatField2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatValue1
            // 
            this.lStatValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatValue1.AutoSize = true;
            this.lStatValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatValue1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatValue1.Location = new System.Drawing.Point(126, 55);
            this.lStatValue1.Margin = new System.Windows.Forms.Padding(0);
            this.lStatValue1.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatValue1.Name = "lStatValue1";
            this.lStatValue1.Size = new System.Drawing.Size(76, 34);
            this.lStatValue1.TabIndex = 5;
            this.lStatValue1.Text = "Name";
            this.lStatValue1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatValue1.UseCompatibleTextRendering = true;
            this.lStatValue1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatValue1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatValue1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatValue1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatValue1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatValue0
            // 
            this.lStatValue0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatValue0.AutoSize = true;
            this.lStatValue0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatValue0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatValue0.Location = new System.Drawing.Point(74, 55);
            this.lStatValue0.Margin = new System.Windows.Forms.Padding(0);
            this.lStatValue0.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatValue0.Name = "lStatValue0";
            this.lStatValue0.Size = new System.Drawing.Size(23, 34);
            this.lStatValue0.TabIndex = 5;
            this.lStatValue0.Text = "#";
            this.lStatValue0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatValue0.UseCompatibleTextRendering = true;
            this.lStatValue0.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatValue0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatValue0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatValue0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatValue0.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatField1
            // 
            this.lStatField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatField1.AutoSize = true;
            this.lStatField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatField1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatField1.Location = new System.Drawing.Point(126, 8);
            this.lStatField1.Margin = new System.Windows.Forms.Padding(0);
            this.lStatField1.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatField1.Name = "lStatField1";
            this.lStatField1.Size = new System.Drawing.Size(76, 34);
            this.lStatField1.TabIndex = 5;
            this.lStatField1.Text = "Name";
            this.lStatField1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatField1.UseCompatibleTextRendering = true;
            this.lStatField1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatField1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatField1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatField1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatField1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lStatField0
            // 
            this.lStatField0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatField0.AutoSize = true;
            this.lStatField0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatField0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatField0.Location = new System.Drawing.Point(74, 8);
            this.lStatField0.Margin = new System.Windows.Forms.Padding(0);
            this.lStatField0.MinimumSize = new System.Drawing.Size(10, 0);
            this.lStatField0.Name = "lStatField0";
            this.lStatField0.Size = new System.Drawing.Size(23, 34);
            this.lStatField0.TabIndex = 5;
            this.lStatField0.Text = "#";
            this.lStatField0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStatField0.UseCompatibleTextRendering = true;
            this.lStatField0.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lStatField0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lStatField0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lStatField0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lStatField0.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pBug
            // 
            this.pBug.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.bug;
            this.pBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBug.Location = new System.Drawing.Point(347, 57);
            this.pBug.Name = "pBug";
            this.pBug.Size = new System.Drawing.Size(112, 80);
            this.pBug.TabIndex = 6;
            this.pBug.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBug.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBug);
            this.pBug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBug.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pHalfTime
            // 
            this.pHalfTime.Controls.Add(this.panel1);
            this.pHalfTime.Controls.Add(this.panel3);
            this.pHalfTime.Controls.Add(this.pHalfTimeClock);
            this.pHalfTime.Controls.Add(this.panel4);
            this.pHalfTime.Controls.Add(this.pHalfTimeClockDivider);
            this.pHalfTime.Location = new System.Drawing.Point(510, 41);
            this.pHalfTime.Name = "pHalfTime";
            this.pHalfTime.Size = new System.Drawing.Size(337, 57);
            this.pHalfTime.TabIndex = 9;
            this.pHalfTime.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pHalfTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pHalfTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.pHalfTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pHalfTime.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_l;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 57);
            this.panel1.TabIndex = 5;
            this.panel1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_r;
            this.panel3.Location = new System.Drawing.Point(276, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 57);
            this.panel3.TabIndex = 5;
            this.panel3.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel3.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pHalfTimeClock
            // 
            this.pHalfTimeClock.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.pHalfTimeClock.Controls.Add(this.lHalfTimeClock);
            this.pHalfTimeClock.Location = new System.Drawing.Point(190, 0);
            this.pHalfTimeClock.Margin = new System.Windows.Forms.Padding(0);
            this.pHalfTimeClock.Name = "pHalfTimeClock";
            this.pHalfTimeClock.Size = new System.Drawing.Size(86, 57);
            this.pHalfTimeClock.TabIndex = 5;
            this.pHalfTimeClock.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pHalfTimeClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pHalfTimeClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.pHalfTimeClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pHalfTimeClock.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lHalfTimeClock
            // 
            this.lHalfTimeClock.BackColor = System.Drawing.Color.Transparent;
            this.lHalfTimeClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lHalfTimeClock.ForeColor = System.Drawing.Color.Black;
            this.lHalfTimeClock.Location = new System.Drawing.Point(3, 8);
            this.lHalfTimeClock.MinimumSize = new System.Drawing.Size(50, 0);
            this.lHalfTimeClock.Name = "lHalfTimeClock";
            this.lHalfTimeClock.Size = new System.Drawing.Size(87, 34);
            this.lHalfTimeClock.TabIndex = 5;
            this.lHalfTimeClock.Text = "00:00";
            this.lHalfTimeClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lHalfTimeClock.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lHalfTimeClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lHalfTimeClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.lHalfTimeClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lHalfTimeClock.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel4.Controls.Add(this.lHalfTime);
            this.panel4.Location = new System.Drawing.Point(55, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 57);
            this.panel4.TabIndex = 5;
            this.panel4.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel4.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lHalfTime
            // 
            this.lHalfTime.AutoSize = true;
            this.lHalfTime.BackColor = System.Drawing.Color.Transparent;
            this.lHalfTime.Font = new System.Drawing.Font("Impact", 20.25F);
            this.lHalfTime.ForeColor = System.Drawing.Color.Black;
            this.lHalfTime.Location = new System.Drawing.Point(7, 9);
            this.lHalfTime.MinimumSize = new System.Drawing.Size(50, 0);
            this.lHalfTime.Name = "lHalfTime";
            this.lHalfTime.Size = new System.Drawing.Size(120, 34);
            this.lHalfTime.TabIndex = 5;
            this.lHalfTime.Text = "HALF TIME";
            this.lHalfTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lHalfTime.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lHalfTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lHalfTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.lHalfTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lHalfTime.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pHalfTimeClockDivider
            // 
            this.pHalfTimeClockDivider.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.pHalfTimeClockDivider.Location = new System.Drawing.Point(185, 0);
            this.pHalfTimeClockDivider.Margin = new System.Windows.Forms.Padding(0);
            this.pHalfTimeClockDivider.Name = "pHalfTimeClockDivider";
            this.pHalfTimeClockDivider.Size = new System.Drawing.Size(5, 57);
            this.pHalfTimeClockDivider.TabIndex = 5;
            this.pHalfTimeClockDivider.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pHalfTimeClockDivider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pHalfTimeClockDivider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHalfTime);
            this.pHalfTimeClockDivider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pHalfTimeClockDivider.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pReplay
            // 
            this.pReplay.Controls.Add(this.panel6);
            this.pReplay.Controls.Add(this.panel8);
            this.pReplay.Controls.Add(this.panel15);
            this.pReplay.Location = new System.Drawing.Point(937, 174);
            this.pReplay.Name = "pReplay";
            this.pReplay.Size = new System.Drawing.Size(220, 57);
            this.pReplay.TabIndex = 9;
            this.pReplay.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pReplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pReplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.pReplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pReplay.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_l;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 57);
            this.panel6.TabIndex = 5;
            this.panel6.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel6.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_r;
            this.panel8.Location = new System.Drawing.Point(161, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(55, 57);
            this.panel8.TabIndex = 5;
            this.panel8.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel8.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel15.Controls.Add(this.lReplay);
            this.panel15.Location = new System.Drawing.Point(55, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(106, 57);
            this.panel15.TabIndex = 5;
            this.panel15.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.panel15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel15.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lReplay
            // 
            this.lReplay.AutoSize = true;
            this.lReplay.BackColor = System.Drawing.Color.Transparent;
            this.lReplay.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReplay.ForeColor = System.Drawing.Color.Black;
            this.lReplay.Location = new System.Drawing.Point(9, 9);
            this.lReplay.MinimumSize = new System.Drawing.Size(50, 0);
            this.lReplay.Name = "lReplay";
            this.lReplay.Size = new System.Drawing.Size(92, 34);
            this.lReplay.TabIndex = 5;
            this.lReplay.Text = "REPLAY";
            this.lReplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lReplay.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lReplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lReplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.lReplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lReplay.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1286, 742);
            this.Controls.Add(this.pReplay);
            this.Controls.Add(this.pHalfTime);
            this.Controls.Add(this.pStat);
            this.Controls.Add(this.pCredits);
            this.Controls.Add(this.pBug);
            this.Controls.Add(this.pBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pCredits.ResumeLayout(false);
            this.pInnerCredits.ResumeLayout(false);
            this.pBar.ResumeLayout(false);
            this.pScoreRD.ResumeLayout(false);
            this.pScoreRD.PerformLayout();
            this.pScoreRS.ResumeLayout(false);
            this.pScoreRS.PerformLayout();
            this.pScoreLD.ResumeLayout(false);
            this.pScoreLD.PerformLayout();
            this.pScoreLS.ResumeLayout(false);
            this.pScoreLS.PerformLayout();
            this.pClock.ResumeLayout(false);
            this.pInfoText.ResumeLayout(false);
            this.pInfoText.PerformLayout();
            this.pPeriod.ResumeLayout(false);
            this.pPeriod.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pStat.ResumeLayout(false);
            this.pStat.PerformLayout();
            this.pHalfTime.ResumeLayout(false);
            this.pHalfTimeClock.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pReplay.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lInfoText;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lAbbr1;
        private System.Windows.Forms.Label lQuarter;
        private System.Windows.Forms.Panel pBug;
        private System.Windows.Forms.Panel pCredits;
        private System.Windows.Forms.RichTextBox tCredits;
        private System.Windows.Forms.Panel pInnerCredits;
        private System.Windows.Forms.Panel pStat;
        private System.Windows.Forms.Label lStatField0;
        private System.Windows.Forms.Label lStatField1;
        private System.Windows.Forms.Label lStatField2;
        private System.Windows.Forms.Label lStatField3;
        private System.Windows.Forms.Label lStatValue3;
        private System.Windows.Forms.Label lStatValue2;
        private System.Windows.Forms.Label lStatValue1;
        private System.Windows.Forms.Label lStatValue0;
        private System.Windows.Forms.Panel pBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pRightTip;
        private System.Windows.Forms.Panel pScoreRS;
        private System.Windows.Forms.Panel pScoreLS;
        private System.Windows.Forms.Panel pPeriodDivider;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pPeriod;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel pInfoTextDivider;
        private System.Windows.Forms.Panel pInfoText;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lAbbr2;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.Panel pLT1;
        private System.Windows.Forms.Panel pLT3;
        private System.Windows.Forms.Panel pLT2;
        private System.Windows.Forms.Panel pRT3;
        private System.Windows.Forms.Panel pRT2;
        private System.Windows.Forms.Panel pRT1;
        private System.Windows.Forms.Panel pLeftTip;
        private System.Windows.Forms.Panel pScoreLD;
        private System.Windows.Forms.Label lScoreLP;
        private System.Windows.Forms.Label lScoreLS;
        private System.Windows.Forms.Panel pScoreRD;
        private System.Windows.Forms.Label lScoreRS;
        private System.Windows.Forms.Label lScoreRP;
        private System.Windows.Forms.Panel pHalfTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lHalfTime;
        private System.Windows.Forms.Panel pHalfTimeClockDivider;
        private System.Windows.Forms.Panel pHalfTimeClock;
        private System.Windows.Forms.Label lHalfTimeClock;
        private System.Windows.Forms.Panel pReplay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lReplay;
        private System.Windows.Forms.Panel pClock;
        private System.Windows.Forms.Label lClock;
        private System.Windows.Forms.Panel pClockDivider;
    }
}