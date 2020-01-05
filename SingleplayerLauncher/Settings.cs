using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace SingleplayerLauncher
{
    internal class Settings
    {
        private static readonly string SettingsFile = "settings.txt";
        public static Dictionary<string, object> Instance = new Dictionary<string, object>();
        static Settings()
        {
            try
            {
                Load();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static void Load()
        {
            if (File.Exists(SettingsFile))
            {
                Instance = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(SettingsFile));
            }
            else
            {
                Save();
            }
        }
        public static void Save()
        {
            File.WriteAllText(SettingsFile, JsonConvert.SerializeObject(Instance));
            Load();
        }
    }
}
