using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TETV_ScoreBar {
    class Utils {
        public static String ToOrderedString(int number) {
            String curStr = number.ToString();
            switch (int.Parse(curStr.Substring(curStr.Length - 1))) {
                case 1:
                    curStr += "st";
                    break;
                case 2:
                    curStr += "nd";
                    break;
                case 3:
                    curStr += "rd";
                    break;
                default:
                    if (number.Equals(0)) break;
                    curStr += "th";
                    break;
            }
            return curStr;
        }

        // OBSELETE: Use Resources now except for images determined in runtime
        private static Dictionary<string, Image> images = new Dictionary<string, Image>();
        public static Image GetImage(string location) {
            Image retImg = null;

            if (images.TryGetValue(location, out retImg))
                return retImg;

            images.Add(location, Image.FromFile(location));

            if (images.TryGetValue(location, out retImg))
                return retImg;

            return null;
        }
    }
}
