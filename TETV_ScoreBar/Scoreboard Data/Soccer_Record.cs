using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scoreboard_Communication {
    public class Soccer_Record {
        public const int size = 36;
        public const char recordType = 'R';

        string[] teamName = new string[] { "", "" };
        int[] score = new int[] { 0, 0 };

        private bool teamNameChanged = true;
        private bool scoreChanged = true;

        private bool firstRun = true;

        public bool Update(char[] data) {
            string dataStr = new String(data);

            // Parse ASCII strings
            string[] oldTeamName = new string[] { teamName[0], teamName[1] };
            teamName[0] = dataStr.Substring(0, 10);
            teamName[1] = dataStr.Substring(18, 10);

            teamNameChanged = teamNameChanged || (oldTeamName[0] != teamName[0] || oldTeamName[1] != teamName[1]);

            // Parse numbers
            dataStr = dataStr.Replace(" ", "0");
            int[] oldScore = new int[] { score[0], score[1] };
            score[0] = int.Parse(dataStr.Substring(10, 2));
            score[1] = int.Parse(dataStr.Substring(28, 2));

            scoreChanged = scoreChanged || (oldScore[0] != score[0] || oldScore[1] != score[1]);

            // Always return true on first run
            if (firstRun) {
                firstRun = false;
                return true;
            }

            return Changed;
        }

        public bool Changed {
            get {
                return TeamNameChanged || ScoreChanged;
            }
        }

        public bool TeamNameChanged {
            get {
                return teamNameChanged;
            }
        }

        public bool ScoreChanged {
            get {
                return scoreChanged;
            }
        }

        public string[] TeamName {
            get {
                teamNameChanged = false;
                return teamName;
            }
        }

        public int[] Score {
            get {
                scoreChanged = false;
                return score;
            }
        }
    }
}
