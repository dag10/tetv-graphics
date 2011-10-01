using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scoreboard_Communication {
    public class Game_Clock_Record {
        public const int size = 8;
        public const char recordType = 'C';

        private int minutes, seconds, tenthSeconds;
        private int period;
        private int shot;

        private bool firstRun = true;
        private bool clockChanged = true;
        private bool periodChanged = true;
        private bool shotChanged = true;

        public bool Update(char[] data) {
            string dataStr = new String(data);

            // Update GAMECLK
            string GAMECLK = dataStr.Substring(0, 5).Replace(" ", "0");
            int oldMinutes = minutes;
            int oldSeconds = seconds;
            int oldTenthSeconds = tenthSeconds;
            minutes = int.Parse(GAMECLK.Substring(0, 2));
            seconds = int.Parse(GAMECLK.Substring(2, 2));
            tenthSeconds = int.Parse(GAMECLK.Substring(4, 1));
            clockChanged = clockChanged || (oldMinutes != minutes || oldSeconds != seconds || oldTenthSeconds != tenthSeconds);

            // Update PERIOD
            int oldPeriod = period;
            period = int.Parse(dataStr.Substring(5, 1).Replace(" ", "0"));
            periodChanged = periodChanged || (oldPeriod != period);

            // Update SHOTT
            int oldShot = shot;
            shot = int.Parse(dataStr.Substring(6, 2).Replace(" ", "0"));
            shotChanged = shotChanged || (oldShot != shot);

            // Always return true on first run
            if (firstRun) {
                firstRun = false;
                return true;
            }

            return Changed;
        }

        public bool Changed {
            get {
                return (ClockChanged || PeriodChanged || ShotChanged);
            }
        }

        public bool ClockChanged {
            get {
                return clockChanged || firstRun;
            }
        }

        public bool PeriodChanged {
            get {
                return periodChanged || firstRun;
            }
        }

        public bool ShotChanged {
            get {
                return shotChanged || firstRun;
            }
        }

        public int[] Clock {
            get {
                clockChanged = false;
                return new int[3] { minutes, seconds, tenthSeconds };
            }
        }

        public int Period {
            get {
                periodChanged = false;
                return period;
            }
        }

        public int Shot {
            get {
                shotChanged = false;
                return shot;
            }
        }
    }
}
