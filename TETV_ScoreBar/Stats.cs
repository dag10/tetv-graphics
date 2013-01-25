﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TETV_ScoreBar {
    public partial class Stats : Form {
        private const int INT_COL_WIDTH = 50,
                          BTN_COL_WIDTH = 50;
        private Game game;
        private Display display;
        private Controls controls;
        private DataTable homeData;
        private DataTable visitingData;
        private string homeFileName;
        private string visitngFileName;
        private bool allowDataSave = false;

        public Stats(Game game, Display display, Controls controls) {
            InitializeComponent();

            this.game = game;
            this.display = display;
            this.controls = controls;

            homeData = new DataTable();
            visitingData = new DataTable();

            switch (game.gameType) {
                case GameType.Wrestling: {
                    PopulateWrestlingColumns(homeData, conestogaPlayerGrid);
                    PopulateWrestlingColumns(visitingData, visitingPlayerGrid);

                    display.statFields = new string[] { "", "Name", "Weight Class", "" };

                    break;
                }
                case GameType.Basketball: {
                    PopulateBasketballColumns(homeData, conestogaPlayerGrid);
                    PopulateBasketballColumns(visitingData, visitingPlayerGrid);

                    display.statFields = new string[] { "#", "Name", "Points", "Fouls" };

                    break;
                }
            }

            // Determine data file names
            homeFileName = game.gameType + ".home.xml";
            visitngFileName = game.gameType + ".visiting.xml";

            // Load data from files
            if (File.Exists(homeFileName))
                homeData.ReadXml(homeFileName);
            else
                homeData.WriteXml(homeFileName);
            if (File.Exists(visitngFileName))
                visitingData.ReadXml(visitngFileName);
            else
                visitingData.WriteXml(visitngFileName);

            // Allow data to be saved on change
            allowDataSave = true;
        }

        #region Stat Bar

        private void playerGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView grid = ((DataGridView)sender);

            foreach (DataGridViewCell c in ((DataGridView)sender).CurrentRow.Cells)
                if (c.Value == null) c.Value = " ";

            switch (game.gameType) {
                case GameType.Wrestling: {
                    DataGridViewRow row = grid.CurrentRow;

                    switch (e.ColumnIndex) {
                        case 0: { // USE
                            display.statValues[0] = "";
                            display.statValues[1] = row.Cells["name"].Value.ToString();
                            display.statValues[2] = row.Cells["weightclass"].Value.ToString() + " lbs";
                            display.statValues[3] = "";

                            display.ShowStats();
                            display.showStats = true;
                            controls.GameUpdated();

                            break;
                        }
                    }

                    break;
                }
                case GameType.Basketball: {
                    DataGridViewRow row = grid.CurrentRow;

                    switch (e.ColumnIndex) {
                        case 0: { // USE
                            display.statValues[0] = row.Cells["number"].Value.ToString();
                            display.statValues[1] = row.Cells["name"].Value.ToString();
                            display.statValues[2] = row.Cells["points"].Value.ToString();
                            display.statValues[3] = row.Cells["fouls"].Value.ToString();

                            display.ShowStats();
                            display.showStats = true;
                            controls.GameUpdated();

                            break;
                        }
                        case 1: { // INCREMENT POINTS
                            row.Cells["points"].Value = ((int)row.Cells["points"].Value) + 1;

                            if (grid == conestogaPlayerGrid) {
                                game.TeamScore[0]++;
                                saveStatData();
                            } else {
                                game.TeamScore[1]++;
                                saveStatData();
                            }

                            if (display.statValues[1] == row.Cells["name"].Value.ToString())
                               display.statValues[2] = row.Cells["points"].Value.ToString();
                            controls.GameUpdated();

                            break;
                        }
                        case 2: { // INCREMENT FOULS
                            row.Cells["fouls"].Value = ((int)row.Cells["fouls"].Value) + 1;
                            saveStatData();
                            if (display.statValues[1] == row.Cells["name"].Value.ToString())
                                display.statValues[3] = row.Cells["fouls"].Value.ToString();
                            controls.GameUpdated();

                            break;
                        }
                    }

                    break;
                }
                default:
                    return;
            }

            display.UpdateDisplay();
        }

        #endregion

        void PopulateWrestlingColumns(DataTable table, DataGridView grid) {
            DataColumn col;

            // Weight Class
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "weightclass";
            col.DataType = typeof(int);
            table.Columns.Add(col);

            // Name
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "name";
            col.DataType = typeof(string);
            table.Columns.Add(col);

            // Set data source for datagridview
            grid.DataSource = table;

            /* Set column headers */

            grid.Columns["weightclass"].HeaderText = "Weight";
            grid.Columns["weightclass"].Width = INT_COL_WIDTH;
            grid.Columns["weightclass"].Resizable = DataGridViewTriState.False;

            grid.Columns["name"].HeaderText = "Name";
            grid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["name"].Resizable = DataGridViewTriState.False;

            /* Add buttons */

            DataGridViewButtonColumn useBtn = new DataGridViewButtonColumn();
            useBtn.Resizable = DataGridViewTriState.False;
            useBtn.HeaderText = "Use";
            useBtn.Text = "GO";
            useBtn.UseColumnTextForButtonValue = true;
            useBtn.Width = BTN_COL_WIDTH;
            grid.Columns.Add(useBtn);

            /* Table info */

            table.TableName = "player";
            table.Namespace = GameType.Wrestling.ToString();
        }

        void PopulateBasketballColumns(DataTable table, DataGridView grid) {
            DataColumn col;

            // Number
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "number";
            col.DataType = typeof(int);
            table.Columns.Add(col);

            // Name
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "name";
            col.DataType = typeof(string);
            table.Columns.Add(col);

            // Points
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "points";
            col.DataType = typeof(int);
            col.DefaultValue = 0;
            table.Columns.Add(col);

            // Fouls
            col = new DataColumn();
            col.ReadOnly = false;
            col.ColumnName = "fouls";
            col.DataType = typeof(int);
            col.DefaultValue = 0;
            table.Columns.Add(col);

            // Set data source for datagridview
            grid.DataSource = table;

            /* Set column headers */

            grid.Columns["number"].HeaderText = "#";
            grid.Columns["number"].Width = INT_COL_WIDTH;
            grid.Columns["number"].Resizable = DataGridViewTriState.False;

            grid.Columns["points"].HeaderText = "Points";
            grid.Columns["points"].Width = INT_COL_WIDTH;
            grid.Columns["points"].Resizable = DataGridViewTriState.False;

            grid.Columns["fouls"].HeaderText = "Fouls";
            grid.Columns["fouls"].Width = INT_COL_WIDTH;
            grid.Columns["fouls"].Resizable = DataGridViewTriState.False;

            grid.Columns["name"].HeaderText = "Name";
            grid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["name"].Resizable = DataGridViewTriState.False;

            /* Add buttons */

            DataGridViewButtonColumn useBtn = new DataGridViewButtonColumn();
            useBtn.Resizable = DataGridViewTriState.False;
            useBtn.HeaderText = "Use";
            useBtn.Text = "GO";
            useBtn.UseColumnTextForButtonValue = true;
            useBtn.Width = BTN_COL_WIDTH;
            grid.Columns.Add(useBtn);

            DataGridViewButtonColumn incScoreBtn = new DataGridViewButtonColumn();
            incScoreBtn.Resizable = DataGridViewTriState.False;
            incScoreBtn.HeaderText = "Score";
            incScoreBtn.Text = "+";
            incScoreBtn.UseColumnTextForButtonValue = true;
            incScoreBtn.Width = BTN_COL_WIDTH;
            grid.Columns.Add(incScoreBtn);

            DataGridViewButtonColumn incFoulsBtn = new DataGridViewButtonColumn();
            incFoulsBtn.Resizable = DataGridViewTriState.False;
            incFoulsBtn.HeaderText = "Fouls";
            incFoulsBtn.Text = "+";
            incFoulsBtn.UseColumnTextForButtonValue = true;
            incFoulsBtn.Width = BTN_COL_WIDTH;
            grid.Columns.Add(incFoulsBtn);

            /* Table info */

            table.TableName = "player";
            table.Namespace = GameType.Basketball.ToString();
        }

        // Prevents user from closing the stats window
        private void Stats_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void playerGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            saveStatData();
        }

        private void saveStatData() {
            if (!allowDataSave) return;

            conestogaPlayerGrid.EndEdit();
            visitingPlayerGrid.EndEdit();

            DataTable lHomeData = (DataTable)conestogaPlayerGrid.DataSource;
            DataTable lVisitingData = (DataTable)visitingPlayerGrid.DataSource;

            lHomeData.WriteXml(homeFileName);
            lVisitingData.WriteXml(visitngFileName);
        }

        private void playerGrid_CellEndEdit(object sender, DataGridViewCellCancelEventArgs e) {
            saveStatData();
        }

        private void playerGrid_CellEndEdit(object sender, KeyPressEventArgs e) {
            saveStatData();
        }

        private void playerGrid_CellEndEdit(object sender, DataGridViewCellValueEventArgs e) {
            saveStatData();
        }

        private string saveRosterDialog() {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "roster";
            dialog.Filter = "Roster files (*.roster)|*.roster";
            dialog.AddExtension = true;
            return (dialog.ShowDialog() == DialogResult.OK) ? dialog.FileName : null;
        }

        private string loadRosterDialog() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "roster";
            dialog.Filter = "Roster files (*.roster)|*.roster";
            dialog.AddExtension = true;
            dialog.Multiselect = false;
            return (dialog.ShowDialog() == DialogResult.OK) ? dialog.FileName : null;
        }

        private void bSaveVisitingRoster_Click(object sender, EventArgs e) {
            string filename = saveRosterDialog();
            if (filename == null) return;

            DataTable data = ((DataTable)visitingPlayerGrid.DataSource).Copy();

            if (game.gameType == GameType.Basketball) {
                data.Columns.Remove("points");
                data.Columns.Remove("fouls");
            }

            data.WriteXml(filename);
        }

        private void bSaveHomeRoster_Click(object sender, EventArgs e) {
            string filename = saveRosterDialog();
            if (filename == null) return;

            DataTable data = ((DataTable)conestogaPlayerGrid.DataSource).Copy();

            if (game.gameType == GameType.Basketball) {
                data.Columns.Remove("points");
                data.Columns.Remove("fouls");
            }

            data.WriteXml(filename);
        }

        private void bLoadVisitingRoster_Click(object sender, EventArgs e) {
            string filename = loadRosterDialog();
            if (filename == null) return;

            XmlDocument doc = new XmlDocument();
            doc.Load(XmlReader.Create(filename));

            if (doc.DocumentElement.NamespaceURI != game.gameType.ToString()) {
                MessageBox.Show("You must use a " + game.gameType.ToString() + " roster.");
                return;
            }

            DataTable table = ((DataTable)visitingPlayerGrid.DataSource);
            table.Clear();
            table.ReadXml(filename);

            if (game.gameType == GameType.Basketball) {
                var colPoints = table.Columns["points"];
                var colFouls = table.Columns["fouls"];

                foreach (DataRow row in table.Rows)
                    row[colPoints] = row[colFouls] = 0;
            }

            saveStatData();
        }

        private void bLoadHomeRoster_Click(object sender, EventArgs e) {
            string filename = loadRosterDialog();
            if (filename == null) return;

            XmlDocument doc = new XmlDocument();
            doc.Load(XmlReader.Create(filename));

            if (doc.DocumentElement.NamespaceURI != game.gameType.ToString()) {
                MessageBox.Show("You must use a " + game.gameType.ToString() + " roster.");
                return;
            }

            DataTable table = ((DataTable)conestogaPlayerGrid.DataSource);
            table.Clear();
            table.ReadXml(filename);

            if (game.gameType == GameType.Basketball) {
                var colPoints = table.Columns["points"];
                var colFouls = table.Columns["fouls"];

                foreach (DataRow row in table.Rows)
                    row[colPoints] = row[colFouls] = 0;
            }

            saveStatData();
        }
    }
}
