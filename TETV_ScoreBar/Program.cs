/* TETV ScoreBar Displayer
 * Copyright © Drew Gottlieb 2010
 * Do not use, distribute, or modify without permission. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics.Eventing;
using System.Diagnostics;

namespace TETV_ScoreBar {
    static class Program {
        [STAThread]
        static void Main() {
            try {
                // Add Exception handler
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(
                    (sender, e) => {
                        if (!e.IsTerminating) return;

                        MessageBox.Show(e.ExceptionObject.ToString(), "Unhandled Exception");
                        EventLog.WriteEntry("Main", e.ToString());
                    }
                );

                // Init visual settings
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Load settings
                Config.Load();

                // Create game and launch controls
                Game game = new Game((GameType)Config.GetInt(ConfigKey.GameType), "Conestoga", "Visiting School", "CHS", "VST");
                Application.Run(new Settings(game));

            } catch (Exception e) {
                MessageBox.Show(e.ToString(), "Unhandled Exception");
                Debug.Write(e.ToString());
            }
        }
    }
}