namespace TETV_ScoreBar {
    partial class Stats {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.visitingPlayerGrid = new System.Windows.Forms.DataGridView();
            this.conestogaPlayerGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bSaveVisitingRoster = new System.Windows.Forms.Button();
            this.bLoadVisitingRoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bLoadHomeRoster = new System.Windows.Forms.Button();
            this.bSaveHomeRoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitingPlayerGrid
            // 
            this.visitingPlayerGrid.AllowUserToResizeColumns = false;
            this.visitingPlayerGrid.AllowUserToResizeRows = false;
            this.visitingPlayerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.visitingPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitingPlayerGrid.Location = new System.Drawing.Point(3, 39);
            this.visitingPlayerGrid.MultiSelect = false;
            this.visitingPlayerGrid.Name = "visitingPlayerGrid";
            this.visitingPlayerGrid.RowHeadersVisible = false;
            this.visitingPlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.visitingPlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitingPlayerGrid.ShowEditingIcon = false;
            this.visitingPlayerGrid.Size = new System.Drawing.Size(406, 552);
            this.visitingPlayerGrid.TabIndex = 2;
            this.visitingPlayerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellClick);
            // 
            // conestogaPlayerGrid
            // 
            this.conestogaPlayerGrid.AllowUserToResizeColumns = false;
            this.conestogaPlayerGrid.AllowUserToResizeRows = false;
            this.conestogaPlayerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.conestogaPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conestogaPlayerGrid.Location = new System.Drawing.Point(3, 39);
            this.conestogaPlayerGrid.MultiSelect = false;
            this.conestogaPlayerGrid.Name = "conestogaPlayerGrid";
            this.conestogaPlayerGrid.RowHeadersVisible = false;
            this.conestogaPlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.conestogaPlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conestogaPlayerGrid.ShowEditingIcon = false;
            this.conestogaPlayerGrid.Size = new System.Drawing.Size(417, 552);
            this.conestogaPlayerGrid.TabIndex = 1;
            this.conestogaPlayerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57604F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(847, 597);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bSaveVisitingRoster
            // 
            this.bSaveVisitingRoster.Location = new System.Drawing.Point(90, 8);
            this.bSaveVisitingRoster.Name = "bSaveVisitingRoster";
            this.bSaveVisitingRoster.Size = new System.Drawing.Size(56, 23);
            this.bSaveVisitingRoster.TabIndex = 4;
            this.bSaveVisitingRoster.Text = "Save";
            this.bSaveVisitingRoster.UseVisualStyleBackColor = true;
            this.bSaveVisitingRoster.Click += new System.EventHandler(this.bSaveVisitingRoster_Click);
            // 
            // bLoadVisitingRoster
            // 
            this.bLoadVisitingRoster.Location = new System.Drawing.Point(152, 8);
            this.bLoadVisitingRoster.Name = "bLoadVisitingRoster";
            this.bLoadVisitingRoster.Size = new System.Drawing.Size(56, 23);
            this.bLoadVisitingRoster.TabIndex = 5;
            this.bLoadVisitingRoster.Text = "Load";
            this.bLoadVisitingRoster.UseVisualStyleBackColor = true;
            this.bLoadVisitingRoster.Click += new System.EventHandler(this.bLoadVisitingRoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visiting roster";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bLoadVisitingRoster);
            this.panel1.Controls.Add(this.visitingPlayerGrid);
            this.panel1.Controls.Add(this.bSaveVisitingRoster);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 591);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.conestogaPlayerGrid);
            this.panel2.Controls.Add(this.bLoadHomeRoster);
            this.panel2.Controls.Add(this.bSaveHomeRoster);
            this.panel2.Location = new System.Drawing.Point(421, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 591);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Home roster";
            // 
            // bLoadHomeRoster
            // 
            this.bLoadHomeRoster.Location = new System.Drawing.Point(153, 8);
            this.bLoadHomeRoster.Name = "bLoadHomeRoster";
            this.bLoadHomeRoster.Size = new System.Drawing.Size(56, 23);
            this.bLoadHomeRoster.TabIndex = 8;
            this.bLoadHomeRoster.Text = "Load";
            this.bLoadHomeRoster.UseVisualStyleBackColor = true;
            this.bLoadHomeRoster.Click += new System.EventHandler(this.bLoadHomeRoster_Click);
            // 
            // bSaveHomeRoster
            // 
            this.bSaveHomeRoster.Location = new System.Drawing.Point(91, 8);
            this.bSaveHomeRoster.Name = "bSaveHomeRoster";
            this.bSaveHomeRoster.Size = new System.Drawing.Size(56, 23);
            this.bSaveHomeRoster.TabIndex = 7;
            this.bSaveHomeRoster.Text = "Save";
            this.bSaveHomeRoster.UseVisualStyleBackColor = true;
            this.bSaveHomeRoster.Click += new System.EventHandler(this.bSaveHomeRoster_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Player Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitingPlayerGrid;
        private System.Windows.Forms.DataGridView conestogaPlayerGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bSaveVisitingRoster;
        private System.Windows.Forms.Button bLoadVisitingRoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLoadHomeRoster;
        private System.Windows.Forms.Button bSaveHomeRoster;
        private System.Windows.Forms.Panel panel1;
    }
}