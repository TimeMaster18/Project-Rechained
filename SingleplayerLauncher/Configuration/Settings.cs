using Newtonsoft.Json;
using SingleplayerLauncher.Configuration;
using SingleplayerLauncher.GameFiles;
using System;
using System.Collections.Generic;
using System.IO;

namespace SingleplayerLauncher
{
    public class Settings : IConfiguration
    {
        public static readonly string SETTINGS_FILE_NAME = "settings.json";
        private static readonly string SETTINGS_LEGACY_FILE_NAME = "settings.txt";
        private static Settings _instance;
        private static readonly object _lock = new();

        public bool FirstRun { get; set; } = true;
        public bool Debug { get; set; }
        public bool RunAs32 { get; set; }
        public string Language { get; set; } = "English";
        public string RootGamePath { get; set; }
        public string LauncherInstallationPath { get; set; }
        public bool IsSiegeInstallation { get; set; } = false;

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
                    }
                }
                return _instance;
            }
        }

        public void Load()
        {
            // TODO: Remove in future release
            string settingsFileLegacy = Path.Combine(RootGamePath, FileUtils.BINARIES_FOLDER_NAME, SETTINGS_LEGACY_FILE_NAME);
            if (File.Exists(settingsFileLegacy))
            {
                try
                {
                    File.Delete(settingsFileLegacy);
                }
                finally
                {
                    // Do nothing - ignore legacy file
                }
            }

            string settingsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, SETTINGS_FILE_NAME);
            if (File.Exists(settingsFile))
            {
                var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(settingsFile));
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

            string settingsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, SETTINGS_FILE_NAME);
            File.WriteAllText(settingsFile, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
