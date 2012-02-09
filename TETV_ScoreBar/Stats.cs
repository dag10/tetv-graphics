using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                    PopulateWrestlingColumns(homeData, conestogaPlayerGrid, "home");
                    PopulateWrestlingColumns(visitingData, visitingPlayerGrid, "visiting");

                    display.statFields = new string[] { "", "Name", "Weight Class", "" };

                    /*
                     * type     name            title
                     * -------  --------------  -------------
                     * int      number          #
                     * string   name            Name
                     * string   weightclass     Weight Class
                     */

                    break;
                }
                case GameType.Basketball: {
                    PopulateBasketballColumns(homeData, conestogaPlayerGrid, "home");
                    PopulateBasketballColumns(visitingData, visitingPlayerGrid, "visiting");

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
                File.Create(homeFileName);
            if (File.Exists(visitngFileName))
                visitingData.ReadXml(visitngFileName);
            else
                File.Create(visitngFileName);

            // Allow data to be saved on change
            allowDataSave = true;
        }

        #region Stat Bar

        private void playerGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView grid = ((DataGridView)sender);

            if (game.gameType != GameType.Basketball)
                return; // TEMPORARY - REMOVED WHEN WRESTLING IMPLEMENTED

            foreach (DataGridViewCell c in ((DataGridView)sender).CurrentRow.Cells)
                if (c.Value == null) c.Value = " ";

            switch (game.gameType) {
                /*case GameType.Wrestling:
                    display.statValues[1] = grid.CurrentRow.Cells["name"].Value.ToString();
                    display.statValues[2] = grid.CurrentRow.Cells["weightclass"].Value.ToString();
                    break;*/
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
                                saveStatData(true, false);
                            } else {
                                game.TeamScore[1]++;
                                saveStatData(false, true);
                            }

                            if (display.statValues[1] == row.Cells["name"].Value.ToString())
                               display.statValues[2] = row.Cells["points"].Value.ToString();
                            controls.GameUpdated();

                            break;
                        }
                        case 2: { // INCREMENT FOULS
                            row.Cells["fouls"].Value = ((int)row.Cells["fouls"].Value) + 1;
                            saveStatData(grid == conestogaPlayerGrid, grid != conestogaPlayerGrid);
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

        void PopulateWrestlingColumns(DataTable table, DataGridView grid, string tableName) {
            // TODO

            MessageBox.Show("Wrestling: TODO");
        }

        void PopulateBasketballColumns(DataTable table, DataGridView grid, string tableName) {
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

            // Table name
            table.TableName = tableName;
        }

        // Prevents user from closing the stats window
        private void Stats_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void playerGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            saveStatData(sender == conestogaPlayerGrid, sender == visitingPlayerGrid);
            saveBtn.Enabled = true;
        }

        private void saveStatData(bool home, bool visiting) {
            if (!allowDataSave) return;

            /*homeData.GetChanges();
            visitingData.GetChanges();

            homeData.AcceptChanges();
            visitingData.AcceptChanges();
             * */

            conestogaPlayerGrid.EndEdit();
            visitingPlayerGrid.EndEdit();

            DataTable lHomeData = (DataTable)conestogaPlayerGrid.DataSource;
            DataTable lVisitingData = (DataTable)visitingPlayerGrid.DataSource;

            if (home)       lHomeData.WriteXml(homeFileName);
            if (visiting)   lVisitingData.WriteXml(visitngFileName);

            //MessageBox.Show("Home: " + (home ? "Yes" : "No") + " Visiting: " + (visiting ? "Yes" : "No"));
        }

        private void playerGrid_CellEndEdit(object sender, DataGridViewCellCancelEventArgs e) {
            saveStatData(sender == conestogaPlayerGrid, sender == visitingPlayerGrid);
            saveBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            saveStatData(true, true);
            saveBtn.Enabled = false;
        }
    }
}
