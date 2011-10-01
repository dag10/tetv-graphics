using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scoreboard_Communication {
    public class Soccer_Record {
        public const int size = 36;
        public const char recordType = 'R';

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
