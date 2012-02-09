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
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.visitingPlayerGrid.Location = new System.Drawing.Point(431, 3);
            this.visitingPlayerGrid.MultiSelect = false;
            this.visitingPlayerGrid.Name = "visitingPlayerGrid";
            this.visitingPlayerGrid.RowHeadersVisible = false;
            this.visitingPlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.visitingPlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitingPlayerGrid.ShowEditingIcon = false;
            this.visitingPlayerGrid.Size = new System.Drawing.Size(434, 523);
            this.visitingPlayerGrid.TabIndex = 2;
            this.visitingPlayerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.playerGrid_CellEndEdit);
            this.visitingPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
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
            this.conestogaPlayerGrid.Location = new System.Drawing.Point(3, 3);
            this.conestogaPlayerGrid.MultiSelect = false;
            this.conestogaPlayerGrid.Name = "conestogaPlayerGrid";
            this.conestogaPlayerGrid.RowHeadersVisible = false;
            this.conestogaPlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.conestogaPlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conestogaPlayerGrid.ShowEditingIcon = false;
            this.conestogaPlayerGrid.Size = new System.Drawing.Size(422, 523);
            this.conestogaPlayerGrid.TabIndex = 1;
            this.conestogaPlayerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellEndEdit);
            this.conestogaPlayerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57604F));
            this.tableLayoutPanel1.Controls.Add(this.visitingPlayerGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.conestogaPlayerGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 529);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(57, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 583);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Player Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitingPlayerGrid;
        private System.Windows.Forms.DataGridView conestogaPlayerGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveBtn;
    }
}