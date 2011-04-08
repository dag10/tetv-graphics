using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TETV_ScoreBar {
    public enum GameType {
        Generic,
        Football,
        //Soccer,
        Basketball,
        Hockey,
        Wrestling,
        //Volleyball,
        //Baseball
    }

    public class Game {
        public string[] TeamName;
        public string[] TeamAbbr;
        public int[] TeamScore;
        public int[] AltScore;
        public int[] Timeouts;
        public int Quarter = 1;
        public int BallPossession = 0;
        public string infoText = "";
        public GameType gameType;
        public bool active = false;

        public Point ScoreBoardPosition;
        public Point ReplayPosition;
        public Point BugPosition;
        public Point StatPosition;

        public Game() {
            this.gameType = (GameType)Config.GetInt(ConfigKey.GameType);
            TeamName = new string[2] { "Team1", "Team2" };
            TeamAbbr = new string[2] { "Abbr1", "Abbr2" };
            TeamScore = new int[2] { 0, 0 };
            AltScore = new int[2] { 0, 0 };
            Timeouts = new int[2] { 3, 3 };
            ScoreBoardPosition = new Point(Config.GetInt(ConfigKey.BoardX), Config.GetInt(ConfigKey.BoardY));
            ReplayPosition = new Point(Config.GetInt(ConfigKey.ReplayX), Config.GetInt(ConfigKey.ReplayY));
            BugPosition = new Point(Config.GetInt(ConfigKey.BugX), Config.GetInt(ConfigKey.BugY));
            StatPosition = new Point(Config.GetInt(ConfigKey.StatX), Config.GetInt(ConfigKey.StatY));
        }

        public Game(GameType type, string Name1, string Name2, string Abbr1, string Abbr2) {
            this.gameType = type;
            TeamName = new string[2] { Name1, Name2 };
            TeamAbbr = new string[2] { Abbr1, Abbr2 };
            TeamScore = new int[2] { 0, 0 };
            AltScore = new int[2] { 0, 0 };
            Timeouts = new int[2] { 3, 3 };
            ScoreBoardPosition = new Point(Config.GetInt(ConfigKey.BoardX), Config.GetInt(ConfigKey.BoardY));
            ReplayPosition = new Point(Config.GetInt(ConfigKey.ReplayX), Config.GetInt(ConfigKey.ReplayY));
            BugPosition = new Point(Config.GetInt(ConfigKey.BugX), Config.GetInt(ConfigKey.BugY));
            StatPosition = new Point(Config.GetInt(ConfigKey.StatX), Config.GetInt(ConfigKey.StatY));
        }
    }
}
