using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scoreboard_Communication {
    public class Football_Record {
        public const int size = 32;
        public const char recordType = 'F';

        string HTeamName = "";
        string VTeamName = "";
        int[] score = new int[] { 0, 0 };
        int[] timeoutsLeft = new int[] { 0, 0 };


        private bool firstRun = true;

        public bool Update(char[] data) {
            string dataStr = new String(data);

            // Always return true on first run
            if (firstRun) {
                firstRun = false;
                return true;
            }

            return Changed;
        }

        public bool Changed {
            get {
                return false;
            }
        }
    }
}
