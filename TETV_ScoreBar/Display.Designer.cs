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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.bOtherSide = new System.Windows.Forms.Button();
            this.pBarOLD = new System.Windows.Forms.Panel();
            this.pAltScoreLeft = new System.Windows.Forms.Panel();
            this.lAltScore1 = new System.Windows.Forms.Label();
            this.pAltScoreRight = new System.Windows.Forms.Panel();
            this.lAltScore2 = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.pLeftScore = new System.Windows.Forms.Panel();
            this.pRightScore = new System.Windows.Forms.Panel();
            this.lInfoText = new System.Windows.Forms.Label();
            this.lQuarter = new System.Windows.Forms.Label();
            this.lAbbr1 = new System.Windows.Forms.Label();
            this.lScore1 = new System.Windows.Forms.Label();
            this.pCredits = new System.Windows.Forms.Panel();
            this.pInnerCredits = new System.Windows.Forms.Panel();
            this.tCredits = new System.Windows.Forms.RichTextBox();
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
            this.pReplay = new System.Windows.Forms.Panel();
            this.pBar = new System.Windows.Forms.Panel();
            this.pRightTip = new System.Windows.Forms.Panel();
            this.pLeftTip = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lScore2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pRT3 = new System.Windows.Forms.Panel();
            this.lAbbr2 = new System.Windows.Forms.Label();
            this.pRT2 = new System.Windows.Forms.Panel();
            this.pRT1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pLT3 = new System.Windows.Forms.Panel();
            this.pLT2 = new System.Windows.Forms.Panel();
            this.pLT1 = new System.Windows.Forms.Panel();
            this.pBarOLD.SuspendLayout();
            this.pAltScoreLeft.SuspendLayout();
            this.pAltScoreRight.SuspendLayout();
            this.pCredits.SuspendLayout();
            this.pInnerCredits.SuspendLayout();
            this.pStat.SuspendLayout();
            this.pBar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOtherSide
            // 
            this.bOtherSide.Location = new System.Drawing.Point(12, 12);
            this.bOtherSide.Name = "bOtherSide";
            this.bOtherSide.Size = new System.Drawing.Size(126, 39);
            this.bOtherSide.TabIndex = 1;
            this.bOtherSide.Text = "Don\'t use this monitor for Display";
            this.bOtherSide.UseVisualStyleBackColor = true;
            this.bOtherSide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.bOtherSide.Click += new System.EventHandler(this.bOtherSide_Click);
            this.bOtherSide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            // 
            // pBarOLD
            // 
            this.pBarOLD.Controls.Add(this.pAltScoreLeft);
            this.pBarOLD.Controls.Add(this.pAltScoreRight);
            this.pBarOLD.Controls.Add(this.pMain);
            this.pBarOLD.Controls.Add(this.pLeftScore);
            this.pBarOLD.Controls.Add(this.pRightScore);
            this.pBarOLD.Location = new System.Drawing.Point(47, 512);
            this.pBarOLD.Name = "pBarOLD";
            this.pBarOLD.Size = new System.Drawing.Size(757, 112);
            this.pBarOLD.TabIndex = 4;
            this.pBarOLD.Visible = false;
            this.pBarOLD.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBarOLD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBarOLD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pBarOLD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBarOLD.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pAltScoreLeft
            // 
            this.pAltScoreLeft.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.altscore_l;
            this.pAltScoreLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAltScoreLeft.Controls.Add(this.lAltScore1);
            this.pAltScoreLeft.Location = new System.Drawing.Point(3, 1);
            this.pAltScoreLeft.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pAltScoreLeft.Name = "pAltScoreLeft";
            this.pAltScoreLeft.Size = new System.Drawing.Size(95, 87);
            this.pAltScoreLeft.TabIndex = 7;
            // 
            // lAltScore1
            // 
            this.lAltScore1.AutoSize = true;
            this.lAltScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltScore1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAltScore1.Location = new System.Drawing.Point(15, 25);
            this.lAltScore1.MinimumSize = new System.Drawing.Size(50, 0);
            this.lAltScore1.Name = "lAltScore1";
            this.lAltScore1.Size = new System.Drawing.Size(50, 37);
            this.lAltScore1.TabIndex = 5;
            this.lAltScore1.Text = "0";
            this.lAltScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAltScore1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAltScore1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAltScore1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAltScore1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAltScore1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pAltScoreRight
            // 
            this.pAltScoreRight.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.altscore_r;
            this.pAltScoreRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAltScoreRight.Controls.Add(this.lAltScore2);
            this.pAltScoreRight.Location = new System.Drawing.Point(614, 1);
            this.pAltScoreRight.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pAltScoreRight.Name = "pAltScoreRight";
            this.pAltScoreRight.Size = new System.Drawing.Size(95, 87);
            this.pAltScoreRight.TabIndex = 8;
            // 
            // lAltScore2
            // 
            this.lAltScore2.AutoSize = true;
            this.lAltScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltScore2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAltScore2.Location = new System.Drawing.Point(27, 25);
            this.lAltScore2.MinimumSize = new System.Drawing.Size(50, 0);
            this.lAltScore2.Name = "lAltScore2";
            this.lAltScore2.Size = new System.Drawing.Size(50, 37);
            this.lAltScore2.TabIndex = 5;
            this.lAltScore2.Text = "0";
            this.lAltScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAltScore2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAltScore2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAltScore2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAltScore2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAltScore2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pMain
            // 
            this.pMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMain.BackgroundImage")));
            this.pMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMain.Location = new System.Drawing.Point(197, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(318, 112);
            this.pMain.TabIndex = 0;
            this.pMain.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pMain.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pLeftScore
            // 
            this.pLeftScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLeftScore.BackgroundImage")));
            this.pLeftScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLeftScore.Location = new System.Drawing.Point(108, 0);
            this.pLeftScore.Margin = new System.Windows.Forms.Padding(0);
            this.pLeftScore.Name = "pLeftScore";
            this.pLeftScore.Size = new System.Drawing.Size(89, 79);
            this.pLeftScore.TabIndex = 0;
            this.pLeftScore.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pLeftScore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pLeftScore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pLeftScore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pLeftScore.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRightScore
            // 
            this.pRightScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRightScore.BackgroundImage")));
            this.pRightScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pRightScore.Location = new System.Drawing.Point(515, 0);
            this.pRightScore.Margin = new System.Windows.Forms.Padding(0);
            this.pRightScore.Name = "pRightScore";
            this.pRightScore.Size = new System.Drawing.Size(89, 79);
            this.pRightScore.TabIndex = 0;
            this.pRightScore.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pRightScore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pRightScore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pRightScore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pRightScore.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lInfoText
            // 
            this.lInfoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lInfoText.AutoSize = true;
            this.lInfoText.BackColor = System.Drawing.Color.Transparent;
            this.lInfoText.Font = new System.Drawing.Font("Impact", 20.25F);
            this.lInfoText.ForeColor = System.Drawing.Color.Black;
            this.lInfoText.Location = new System.Drawing.Point(1, 9);
            this.lInfoText.Margin = new System.Windows.Forms.Padding(0);
            this.lInfoText.MinimumSize = new System.Drawing.Size(180, 0);
            this.lInfoText.Name = "lInfoText";
            this.lInfoText.Size = new System.Drawing.Size(180, 40);
            this.lInfoText.TabIndex = 5;
            this.lInfoText.Text = "1st & 10";
            this.lInfoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lInfoText.UseCompatibleTextRendering = true;
            this.lInfoText.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lInfoText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lInfoText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lInfoText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lInfoText.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lQuarter
            // 
            this.lQuarter.AutoSize = true;
            this.lQuarter.BackColor = System.Drawing.Color.Transparent;
            this.lQuarter.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuarter.ForeColor = System.Drawing.Color.Black;
            this.lQuarter.Location = new System.Drawing.Point(15, 9);
            this.lQuarter.MinimumSize = new System.Drawing.Size(50, 0);
            this.lQuarter.Name = "lQuarter";
            this.lQuarter.Size = new System.Drawing.Size(50, 34);
            this.lQuarter.TabIndex = 5;
            this.lQuarter.Text = "1st";
            this.lQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lQuarter.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lQuarter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lQuarter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lQuarter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lQuarter.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
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
            // pCredits
            // 
            this.pCredits.BackColor = System.Drawing.Color.DarkGray;
            this.pCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCredits.Controls.Add(this.pInnerCredits);
            this.pCredits.Location = new System.Drawing.Point(987, 12);
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
            // pReplay
            // 
            this.pReplay.BackColor = System.Drawing.Color.Transparent;
            this.pReplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pReplay.BackgroundImage")));
            this.pReplay.ForeColor = System.Drawing.Color.Transparent;
            this.pReplay.Location = new System.Drawing.Point(76, 57);
            this.pReplay.Name = "pReplay";
            this.pReplay.Size = new System.Drawing.Size(243, 48);
            this.pReplay.TabIndex = 5;
            this.pReplay.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pReplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pReplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragReplay);
            this.pReplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pReplay.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pBar
            // 
            this.pBar.Controls.Add(this.pRightTip);
            this.pBar.Controls.Add(this.pLeftTip);
            this.pBar.Controls.Add(this.panel6);
            this.pBar.Controls.Add(this.panel5);
            this.pBar.Controls.Add(this.panel12);
            this.pBar.Controls.Add(this.panel10);
            this.pBar.Controls.Add(this.panel8);
            this.pBar.Controls.Add(this.panel13);
            this.pBar.Controls.Add(this.panel7);
            this.pBar.Controls.Add(this.panel11);
            this.pBar.Controls.Add(this.panel9);
            this.pBar.Controls.Add(this.panel14);
            this.pBar.Controls.Add(this.panel2);
            this.pBar.Location = new System.Drawing.Point(12, 348);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(818, 57);
            this.pBar.TabIndex = 4;
            this.pBar.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBar.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRightTip
            // 
            this.pRightTip.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.tip_r;
            this.pRightTip.Location = new System.Drawing.Point(761, 0);
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
            // panel6
            // 
            this.panel6.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score;
            this.panel6.Controls.Add(this.lScore2);
            this.panel6.Location = new System.Drawing.Point(553, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(117, 57);
            this.panel6.TabIndex = 5;
            this.panel6.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel6.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
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
            // panel5
            // 
            this.panel5.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.score;
            this.panel5.Controls.Add(this.lScore1);
            this.panel5.Location = new System.Drawing.Point(146, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 57);
            this.panel5.TabIndex = 5;
            this.panel5.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel5.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.panel12.Location = new System.Drawing.Point(543, 0);
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
            // panel10
            // 
            this.panel10.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.panel10.Location = new System.Drawing.Point(355, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 57);
            this.panel10.TabIndex = 5;
            this.panel10.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel10.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.divider;
            this.panel8.Location = new System.Drawing.Point(268, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 57);
            this.panel8.TabIndex = 5;
            this.panel8.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel8.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel13.Location = new System.Drawing.Point(548, 0);
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
            this.panel7.Location = new System.Drawing.Point(263, 0);
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
            // panel11
            // 
            this.panel11.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel11.Controls.Add(this.lInfoText);
            this.panel11.Location = new System.Drawing.Point(360, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(183, 57);
            this.panel11.TabIndex = 5;
            this.panel11.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel11.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel9.Controls.Add(this.lQuarter);
            this.panel9.Location = new System.Drawing.Point(273, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(82, 57);
            this.panel9.TabIndex = 5;
            this.panel9.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.panel9.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.center;
            this.panel14.Controls.Add(this.pRT3);
            this.panel14.Controls.Add(this.lAbbr2);
            this.panel14.Controls.Add(this.pRT2);
            this.panel14.Controls.Add(this.pRT1);
            this.panel14.Location = new System.Drawing.Point(670, 0);
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
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1090, 742);
            this.Controls.Add(this.pStat);
            this.Controls.Add(this.pCredits);
            this.Controls.Add(this.pBug);
            this.Controls.Add(this.pReplay);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.pBarOLD);
            this.Controls.Add(this.bOtherSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBarOLD.ResumeLayout(false);
            this.pAltScoreLeft.ResumeLayout(false);
            this.pAltScoreLeft.PerformLayout();
            this.pAltScoreRight.ResumeLayout(false);
            this.pAltScoreRight.PerformLayout();
            this.pCredits.ResumeLayout(false);
            this.pInnerCredits.ResumeLayout(false);
            this.pStat.ResumeLayout(false);
            this.pStat.PerformLayout();
            this.pBar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOtherSide;
        private System.Windows.Forms.Panel pBarOLD;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pRightScore;
        private System.Windows.Forms.Panel pLeftScore;
        private System.Windows.Forms.Label lInfoText;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lAbbr1;
        private System.Windows.Forms.Label lQuarter;
        private System.Windows.Forms.Panel pReplay;
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
        private System.Windows.Forms.Panel pAltScoreLeft;
        private System.Windows.Forms.Panel pAltScoreRight;
        private System.Windows.Forms.Label lAltScore1;
        private System.Windows.Forms.Label lAltScore2;
        private System.Windows.Forms.Panel pBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pLeftTip;
        private System.Windows.Forms.Panel pRightTip;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
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
    }
}