// Config Class
// Copyright 2009, 2010 Matvei Stefarov <me@matvei.org>
// This class was released under the MIT license
using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace TETV_ScoreBar {
    public static class Config {
        public const int ConfigVersion = 2;
        public const string ConfigRootName = "ScoreBarSettings",
                            ConfigFile = "settings.xml";
        static Dictionary<ConfigKey, string> settings = new Dictionary<ConfigKey, string>();
        public static bool logToString;


        public static void LoadDefaults() {
            settings.Clear();
            settings[ConfigKey.BoardX] = Display.ScreenPadding.ToString();
            settings[ConfigKey.BoardY] = (Display.ScreenPadding + 60).ToString();
            settings[ConfigKey.ReplayX] = Display.ScreenPadding.ToString();
            settings[ConfigKey.ReplayY] = Display.ScreenPadding.ToString();
            settings[ConfigKey.BugX] = (Display.ScreenPadding + 160).ToString();
            settings[ConfigKey.BugY] = (Display.ScreenPadding + 460).ToString();
            settings[ConfigKey.StatX] = (Display.ScreenPadding + 60).ToString();
            settings[ConfigKey.StatY] = (Display.ScreenPadding + 460).ToString();
            settings[ConfigKey.ControlScreen] = "0";
            settings[ConfigKey.DisplayScreen] = "1";
            settings[ConfigKey.GameType] = ((int)GameType.Football).ToString();
            settings[ConfigKey.ShowInfoText] = "True";
            settings[ConfigKey.ShowScores] = "True";
            settings[ConfigKey.ShowTimeouts] = "True";
            settings[ConfigKey.ShowBug] = "True";
            settings[ConfigKey.CreditsFile] = "";
            settings[ConfigKey.SerialPort] = "COM1";
        }

        public static bool Load() {
            LoadDefaults();

            // Try to load config file (XML)
            XDocument file;
            if (File.Exists(ConfigFile)) {
                try {
                    file = XDocument.Load(ConfigFile);
                    if (file.Root == null || file.Root.Name != ConfigRootName) {
                        file = new XDocument();
                        file.Add(new XElement(ConfigRootName));
                    }
                } catch {
                    return false;
                }
            } else {
                // Create a new one (with defaults) if no file exists
                file = new XDocument();
                file.Add(new XElement(ConfigRootName));
            }

            XElement config = file.Root;

            XAttribute attr = config.Attribute("version");

            // Load config
            string[] keyNames = Enum.GetNames(typeof(ConfigKey));
            foreach (XElement element in config.Elements()) {
                if (keyNames.Contains<string>(element.Name.ToString())) {
                    // Known key
                    SetValue((ConfigKey)Enum.Parse(typeof(ConfigKey), element.Name.ToString(), true), element.Value);

                }
            }
            return true;
        }


        public static bool Save() {
            XDocument file = new XDocument();

            XElement config = new XElement(ConfigRootName);
            config.Add(new XAttribute("version", ConfigVersion));


            foreach (KeyValuePair<ConfigKey, string> pair in settings) {
                config.Add(new XElement(pair.Key.ToString(), pair.Value));
            }

            file.Add(config);

            // Save the settings
            try {
                file.Save(ConfigFile);
                return true;
            } catch {
                return false;
            }
        }

        public static bool SetValue(ConfigKey key, object _value) {
            string value = _value.ToString();
            switch (key) {
                case ConfigKey.GameType:
                case ConfigKey.ControlScreen:
                case ConfigKey.DisplayScreen:
                case ConfigKey.BoardX:
                case ConfigKey.BoardY:
                case ConfigKey.ReplayX:
                case ConfigKey.ReplayY:
                case ConfigKey.BugX:
                case ConfigKey.BugY:
                case ConfigKey.StatX:
                case ConfigKey.StatY:
                    return ValidateInt(key, value, 0, 5000);
                case ConfigKey.ShowInfoText:
                case ConfigKey.ShowScores:
                case ConfigKey.ShowTimeouts:
                case ConfigKey.ShowBug:
                    return ValidateBool(key, value);
                case ConfigKey.CreditsFile:
                case ConfigKey.SerialPort:
                    return ValidateString(key, value, 1, 128);
                default:
                    settings[key] = value;
                    return true;
            }
        }


        static bool ValidateInt(ConfigKey key, string value, int minRange, int maxRange) {
            int temp;
            if (Int32.TryParse(value, out temp)) {
                if (temp >= minRange && temp <= maxRange) {
                    settings[key] = temp.ToString();
                } else {
                }
                return true;
            } else {
                return false;
            }
        }

        static bool ValidateBool(ConfigKey key, string value) {
            bool temp;
            if (Boolean.TryParse(value, out temp)) {
                settings[key] = temp.ToString();
                return true;
            } else {
                return false;
            }
        }

        static bool ValidateString(ConfigKey key, string value, int minLength, int maxLength) {
            if (value.Length < minLength) {
                return false;
            } else if (value.Length > maxLength) {
                settings[key] = value.Substring(0, maxLength);
                return true;
            } else {
                settings[key] = value;
                return true;
            }
        }

        static bool ValidateEnum(ConfigKey key, string value, params string[] options) {
            for (int i = 0; i < options.Length; i++) {
                if (value.ToLower() == options[i].ToLower()) {
                    settings[key] = options[i];
                    return true;
                }
            }
            return false;
        }


        public static string GetString(ConfigKey key) {
            return settings[key];
        }

        public static int GetInt(ConfigKey key) {
            return Int32.Parse(settings[key]);
        }

        public static bool GetBool(ConfigKey key) {
            return Boolean.Parse(settings[key]);
        }
    }
}