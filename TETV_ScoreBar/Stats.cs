using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TETV_ScoreBar {
    public partial class Stats : Form {
        private Game game;
        private Display display;
        private Controls controls;

        public Stats(Game game, Display display, Controls controls) {
            InitializeComponent();

            this.game = game;
            this.display = display;
            this.controls = controls;

            // Init gridview for player db
            //conestogaPlayerGrid.DataSource = conestogaPlayersDataSet.Tables["Conestoga"].DefaultView;

            switch (game.gameType) {
                case GameType.Wrestling:
                    conestogaPlayerGrid.Columns.Add("number", "#");
                    conestogaPlayerGrid.Columns.Add("name", "Name");
                    conestogaPlayerGrid.Columns.Add("weightclass", "Weight Class");
                    visitingPlayerGrid.Columns.Add("number", "#");
                    visitingPlayerGrid.Columns.Add("name", "Name");
                    visitingPlayerGrid.Columns.Add("weightclass", "Weight Class");
                    display.statFields = new string[]{ "", "Name", "Weight Class", "" };
                    break;
                case GameType.Basketball:
                    conestogaPlayerGrid.Columns.Add("number", "#");
                    conestogaPlayerGrid.Columns.Add("name", "Name");
                    conestogaPlayerGrid.Columns.Add("points", "Points");
                    conestogaPlayerGrid.Columns.Add("fouls", "Fouls");
                    visitingPlayerGrid.Columns.Add("number", "#");
                    visitingPlayerGrid.Columns.Add("name", "Name");
                    visitingPlayerGrid.Columns.Add("points", "Points");
                    visitingPlayerGrid.Columns.Add("fouls", "Fouls");
                    display.statFields = new string[] { "#", "Name", "Points", "Fouls" };
                    break;
            }

            DataGridViewButtonColumn btnColH = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnColV = new DataGridViewButtonColumn();
            //((Button)btnCol.CellTemplate.Value).Text = "USE";
            conestogaPlayerGrid.Columns.Add(btnColH);
            visitingPlayerGrid.Columns.Add(btnColV);
        }

        #region Stat Bar

        private void playerGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != ((DataGridView)sender).Columns.Count - 1)
                return;

            foreach (DataGridViewCell c in ((DataGridView)sender).CurrentRow.Cells)
                if (c.Value == null) c.Value = " ";

            switch (game.gameType) {
                case GameType.Wrestling:
                    display.statValues[1] = ((DataGridView)sender).CurrentRow.Cells["name"].Value.ToString();
                    display.statValues[2] = ((DataGridView)sender).CurrentRow.Cells["weightclass"].Value.ToString();
                    break;
                case GameType.Basketball:
                    display.statValues[0] = ((DataGridView)sender).CurrentRow.Cells["number"].Value.ToString();
                    display.statValues[1] = ((DataGridView)sender).CurrentRow.Cells["name"].Value.ToString();
                    display.statValues[2] = ((DataGridView)sender).CurrentRow.Cells["points"].Value.ToString();
                    display.statValues[3] = ((DataGridView)sender).CurrentRow.Cells["fouls"].Value.ToString();
                    break;
                default:
                    return;
            }

            display.UpdateDisplay();
        }

        #endregion
    }
}
