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
            this.pBar = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.lQuarter = new System.Windows.Forms.Label();
            this.lInfoText = new System.Windows.Forms.Label();
            this.lAbbr2 = new System.Windows.Forms.Label();
            this.lAbbr1 = new System.Windows.Forms.Label();
            this.pRightScore = new System.Windows.Forms.Panel();
            this.lScore2 = new System.Windows.Forms.Label();
            this.pLeftScore = new System.Windows.Forms.Panel();
            this.lScore1 = new System.Windows.Forms.Label();
            this.pReplay = new System.Windows.Forms.Panel();
            this.pBug = new System.Windows.Forms.Panel();
            this.pCredits = new System.Windows.Forms.Panel();
            this.pInnerCredits = new System.Windows.Forms.Panel();
            this.tCredits = new System.Windows.Forms.RichTextBox();
            this.pBar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pRightScore.SuspendLayout();
            this.pLeftScore.SuspendLayout();
            this.pCredits.SuspendLayout();
            this.pInnerCredits.SuspendLayout();
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
            // pBar
            // 
            this.pBar.Controls.Add(this.pMain);
            this.pBar.Controls.Add(this.pRightScore);
            this.pBar.Controls.Add(this.pLeftScore);
            this.pBar.Location = new System.Drawing.Point(41, 610);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(496, 112);
            this.pBar.TabIndex = 4;
            this.pBar.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.pBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBar.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMain.BackgroundImage")));
            this.pMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMain.Controls.Add(this.lQuarter);
            this.pMain.Controls.Add(this.lInfoText);
            this.pMain.Controls.Add(this.lAbbr2);
            this.pMain.Controls.Add(this.lAbbr1);
            this.pMain.Location = new System.Drawing.Point(89, 0);
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
            // lQuarter
            // 
            this.lQuarter.AutoSize = true;
            this.lQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuarter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lQuarter.Location = new System.Drawing.Point(135, 24);
            this.lQuarter.MinimumSize = new System.Drawing.Size(50, 0);
            this.lQuarter.Name = "lQuarter";
            this.lQuarter.Size = new System.Drawing.Size(50, 25);
            this.lQuarter.TabIndex = 5;
            this.lQuarter.Text = "1st";
            this.lQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lQuarter.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lQuarter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lQuarter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lQuarter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lQuarter.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lInfoText
            // 
            this.lInfoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lInfoText.AutoSize = true;
            this.lInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lInfoText.Location = new System.Drawing.Point(0, 79);
            this.lInfoText.Margin = new System.Windows.Forms.Padding(0);
            this.lInfoText.MinimumSize = new System.Drawing.Size(318, 0);
            this.lInfoText.Name = "lInfoText";
            this.lInfoText.Size = new System.Drawing.Size(318, 27);
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
            // lAbbr2
            // 
            this.lAbbr2.AutoSize = true;
            this.lAbbr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAbbr2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAbbr2.Location = new System.Drawing.Point(210, 19);
            this.lAbbr2.Name = "lAbbr2";
            this.lAbbr2.Size = new System.Drawing.Size(91, 39);
            this.lAbbr2.TabIndex = 5;
            this.lAbbr2.Text = "ABC";
            this.lAbbr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAbbr2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAbbr2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAbbr2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAbbr2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAbbr2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // lAbbr1
            // 
            this.lAbbr1.AutoSize = true;
            this.lAbbr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAbbr1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAbbr1.Location = new System.Drawing.Point(18, 19);
            this.lAbbr1.Name = "lAbbr1";
            this.lAbbr1.Size = new System.Drawing.Size(91, 39);
            this.lAbbr1.TabIndex = 5;
            this.lAbbr1.Text = "ABC";
            this.lAbbr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAbbr1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lAbbr1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lAbbr1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lAbbr1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lAbbr1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pRightScore
            // 
            this.pRightScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pRightScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRightScore.BackgroundImage")));
            this.pRightScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pRightScore.Controls.Add(this.lScore2);
            this.pRightScore.Location = new System.Drawing.Point(407, 0);
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
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScore2.Location = new System.Drawing.Point(6, 22);
            this.lScore2.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(50, 37);
            this.lScore2.TabIndex = 5;
            this.lScore2.Text = "0";
            this.lScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScore2.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScore2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScore2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScore2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScore2.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pLeftScore
            // 
            this.pLeftScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLeftScore.BackgroundImage")));
            this.pLeftScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLeftScore.Controls.Add(this.lScore1);
            this.pLeftScore.Location = new System.Drawing.Point(0, 0);
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
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lScore1.Location = new System.Drawing.Point(33, 22);
            this.lScore1.MinimumSize = new System.Drawing.Size(50, 0);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(50, 37);
            this.lScore1.TabIndex = 5;
            this.lScore1.Text = "0";
            this.lScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lScore1.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.lScore1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.lScore1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBoard);
            this.lScore1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.lScore1.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
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
            // pBug
            // 
            this.pBug.BackgroundImage = global::TETV_ScoreBar.Properties.Resources.bug;
            this.pBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBug.Location = new System.Drawing.Point(912, 610);
            this.pBug.Name = "pBug";
            this.pBug.Size = new System.Drawing.Size(112, 80);
            this.pBug.TabIndex = 6;
            this.pBug.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.pBug.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragBug);
            this.pBug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            this.pBug.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            // 
            // pCredits
            // 
            this.pCredits.BackColor = System.Drawing.Color.DarkGray;
            this.pCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCredits.Controls.Add(this.pInnerCredits);
            this.pCredits.Location = new System.Drawing.Point(618, 12);
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
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1090, 742);
            this.Controls.Add(this.pCredits);
            this.Controls.Add(this.pBug);
            this.Controls.Add(this.pReplay);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.bOtherSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.pBar.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pRightScore.ResumeLayout(false);
            this.pRightScore.PerformLayout();
            this.pLeftScore.ResumeLayout(false);
            this.pLeftScore.PerformLayout();
            this.pCredits.ResumeLayout(false);
            this.pInnerCredits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOtherSide;
        private System.Windows.Forms.Panel pBar;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pRightScore;
        private System.Windows.Forms.Panel pLeftScore;
        private System.Windows.Forms.Label lInfoText;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lAbbr1;
        private System.Windows.Forms.Label lQuarter;
        private System.Windows.Forms.Label lAbbr2;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.Panel pReplay;
        private System.Windows.Forms.Panel pBug;
        private System.Windows.Forms.Panel pCredits;
        private System.Windows.Forms.RichTextBox tCredits;
        private System.Windows.Forms.Panel pInnerCredits;
    }
}