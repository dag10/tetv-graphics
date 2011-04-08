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
                    break;
                case GameType.Basketball:
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

            display.plyNumber = ((DataGridView)sender).CurrentRow.Cells["number"].Value.ToString();
            display.plyName = ((DataGridView)sender).CurrentRow.Cells["name"].Value.ToString();
            display.plyPoints = ((DataGridView)sender).CurrentRow.Cells["weightclass"].Value.ToString();
            //display.plyFouls = ((DataGridView)sender).CurrentRow.Cells["fouls"].Value.ToString();
            display.UpdateDisplay();
        }

        #endregion
    }
}
