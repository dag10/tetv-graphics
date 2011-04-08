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
            this.components = new System.ComponentModel.Container();
            this.visitingPlayerGrid = new System.Windows.Forms.DataGridView();
            this.conestogaPlayerGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.conestogaPlayersDataSet = new TETV_ScoreBar.ConestogaPlayersDataSet();
            this.conestogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conestogaPlayersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayersDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // visitingPlayerGrid
            // 
            this.visitingPlayerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.visitingPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitingPlayerGrid.Location = new System.Drawing.Point(437, 3);
            this.visitingPlayerGrid.Name = "visitingPlayerGrid";
            this.visitingPlayerGrid.RowHeadersVisible = false;
            this.visitingPlayerGrid.ShowEditingIcon = false;
            this.visitingPlayerGrid.Size = new System.Drawing.Size(428, 553);
            this.visitingPlayerGrid.TabIndex = 2;
            this.visitingPlayerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellClick);
            // 
            // conestogaPlayerGrid
            // 
            this.conestogaPlayerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.conestogaPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conestogaPlayerGrid.Location = new System.Drawing.Point(3, 3);
            this.conestogaPlayerGrid.Name = "conestogaPlayerGrid";
            this.conestogaPlayerGrid.RowHeadersVisible = false;
            this.conestogaPlayerGrid.ShowEditingIcon = false;
            this.conestogaPlayerGrid.Size = new System.Drawing.Size(428, 553);
            this.conestogaPlayerGrid.TabIndex = 1;
            this.conestogaPlayerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.visitingPlayerGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.conestogaPlayerGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 559);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // conestogaPlayersDataSet
            // 
            this.conestogaPlayersDataSet.DataSetName = "ConestogaPlayersDataSet";
            this.conestogaPlayersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conestogaBindingSource
            // 
            this.conestogaBindingSource.DataMember = "Conestoga";
            // 
            // visitingBindingSource
            // 
            this.visitingBindingSource.DataMember = "Visiting";
            // 
            // conestogaPlayersDataSetBindingSource
            // 
            this.conestogaPlayersDataSetBindingSource.DataSource = this.conestogaPlayersDataSet;
            this.conestogaPlayersDataSetBindingSource.Position = 0;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Stats";
            this.Text = "Player Stats";
            ((System.ComponentModel.ISupportInitialize)(this.visitingPlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayerGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conestogaPlayersDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitingPlayerGrid;
        private System.Windows.Forms.DataGridView conestogaPlayerGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ConestogaPlayersDataSet conestogaPlayersDataSet;
        private System.Windows.Forms.BindingSource conestogaBindingSource;
        private System.Windows.Forms.BindingSource visitingBindingSource;
        private System.Windows.Forms.BindingSource conestogaPlayersDataSetBindingSource;
    }
}