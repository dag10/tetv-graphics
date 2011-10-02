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
        int[] timeoutsLeft = new int[] { 0, 0 };
        int down;
        int toGo;
        int ballOn;
        FootballPossession possession;

        private bool teamNameChanged = true;
        private bool scoreChanged = true;
        private bool timeoutsLeftChanged = true;
        private bool downChanged = true;
        private bool toGoChanged = true;
        private bool ballOnChanged = true;
        private bool possessionChanged = true;

        private bool firstRun = true;

        public bool Update(char[] data) {
            string dataStr = new String(data);

            // Parse ASCII strings
            string[] oldTeamName = new string[] { teamName[0], teamName[1] };
            teamName[0] = dataStr.Substring(0, 10);
            teamName[1] = dataStr.Substring(13, 10);

            teamNameChanged = teamNameChanged || (oldTeamName[0] != teamName[0] || oldTeamName[1] != teamName[1]);

            // Parse numbers
            dataStr = dataStr.Replace(" ", "0");
            int[] oldScore = new int[] { score[0], score[1] };
            score[0] = int.Parse(dataStr.Substring(10, 2));
            score[1] = int.Parse(dataStr.Substring(23, 2));
            int[] oldTimeoutsLeft = new int[] { timeoutsLeft[0], timeoutsLeft[1] };
            timeoutsLeft[0] = int.Parse(dataStr.Substring(12, 1));
            timeoutsLeft[1] = int.Parse(dataStr.Substring(25, 1));
            int oldDown = down;
            down = int.Parse(dataStr.Substring(26, 1));
            int oldToGo = toGo;
            toGo = int.Parse(dataStr.Substring(27, 2));
            int oldBallOn = ballOn;
            ballOn = int.Parse(dataStr.Substring(29, 2));
            FootballPossession oldPossession = possession;
            possession = ((dataStr.Substring(31, 1) == "H") ? FootballPossession.Home : (dataStr.Substring(31, 1) == "V") ? FootballPossession.Visitor : FootballPossession.SP);

            scoreChanged = scoreChanged || (oldScore[0] != score[0] || oldScore[1] != score[1]);
            timeoutsLeftChanged = timeoutsLeftChanged || (oldTimeoutsLeft[0] != timeoutsLeft[0] || oldTimeoutsLeft[1] != timeoutsLeft[1]);
            downChanged = downChanged || (oldDown != down);
            toGoChanged = toGoChanged || (oldToGo != toGo);
            ballOnChanged = ballOnChanged || (oldBallOn != ballOn);
            possessionChanged = possessionChanged || (oldPossession != possession);

            // Always return true on first run
            if (firstRun) {
                firstRun = false;
                return true;
            }

            return Changed;
        }

        public bool Changed {
            get {
                return TeamNameChanged
                    || ScoreChanged
                    || TimeoutsLeftChanged
                    || DownChanged
                    || ToGoChanged
                    || BallOnChanged
                    || PossessionChanged;
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

        public bool TimeoutsLeftChanged {
            get {
                return timeoutsLeftChanged;
            }
        }

        public bool DownChanged {
            get {
                return downChanged;
            }
        }

        public bool ToGoChanged {
            get {
                return toGoChanged;
            }
        }

        public bool BallOnChanged {
            get {
                return ballOnChanged;
            }
        }

        public bool PossessionChanged {
            get {
                return possessionChanged;
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

        public int[] TimeoutsLeft {
            get {
                timeoutsLeftChanged = false;
                return timeoutsLeft;
            }
        }

        public int Down {
            get {
                downChanged = false;
                return down;
            }
        }

        public int ToGo {
            get {
                toGoChanged = false;
                return toGo;
            }
        }

        public int BallOn {
            get {
                ballOnChanged = false;
                return ballOn;
            }
        }

        public FootballPossession Possession {
            get {
                possessionChanged = false;
                return possession;
            }
        }
    }
}
