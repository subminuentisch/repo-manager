using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RepoManager
{
    public class Settings
    {
        const string SETTINGS_FILE = ".c&p/config.json";
        public FtpSettings FtpServer = new FtpSettings();

        public static Settings Load()
        {
            if (!File.Exists(SETTINGS_FILE))
                return new Settings();

            string settingsJson = File.ReadAllText(SETTINGS_FILE);
            return JsonConvert.DeserializeObject<Settings>(settingsJson);
        }

        public void Save()
        {
            string settingsJson = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(SETTINGS_FILE, settingsJson);
        }
    }
}
