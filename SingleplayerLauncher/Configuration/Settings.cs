using Newtonsoft.Json;
using SingleplayerLauncher.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace SingleplayerLauncher
{
    public class Settings : IConfiguration
    {
        private static readonly string SettingsFile = "settings.json";
        private static readonly string SettingsFileLegacy = "settings.txt";
        private static Settings _instance;
        private static readonly object _lock = new object();

        public bool FirstRun { get; set; }
        public bool Debug { get; set; }
        public bool RunAs32 { get; set; }
        public string Language { get; set; } = "English";

        private Settings() { }

        public static Settings Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                        _instance.Load();
                    }
                }
                return _instance;
            }
        }

        public void Load()
        {
            // TODO: Remove in future release
            if (File.Exists(SettingsFileLegacy))
            {
                try
                {
                    File.Delete(SettingsFileLegacy);
                } finally {
                    // Do nothing - ignore legacy file
                }
            }

            if (File.Exists(SettingsFile))
            {
                var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(SettingsFile));
                LoadFromDictionary(settings);
            }
            else
            {
                Save();
            }
        }

        private void LoadFromDictionary(Dictionary<string, object> settings)
        {
            foreach (var property in GetType().GetProperties())
            {
                if (settings.ContainsKey(property.Name) && property.CanWrite && property.Name != "Instance")
                {
                    property.SetValue(this, Convert.ChangeType(settings[property.Name], property.PropertyType));
                }
            }
        }

        public void Save()
        {
            var settings = new Dictionary<string, object>();

            foreach (var property in GetType().GetProperties())
            {
                if (property.CanRead && property.Name != "Instance")
                {
                    settings[property.Name] = property.GetValue(this);
                }
            }

            File.WriteAllText(SettingsFile, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
