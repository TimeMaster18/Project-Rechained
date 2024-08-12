using Newtonsoft.Json;
using SingleplayerLauncher.Configuration;
using SingleplayerLauncher.GameFiles;
using System;
using System.Collections.Generic;
using System.IO;

namespace SingleplayerLauncher
{
    public class GameConfig : IConfiguration
    {
        public static readonly string GAME_CONFIG_FILE_NAME = "gameconfig.json";
        private static GameConfig _instance;
        private static readonly object _lock = new();

        public bool ModsEnabled { get; set; }
        public string GameMode { get; set; } = "Survival";
        public string Difficulty { get; set; }
        public string Battleground { get; set; }
        public string SiegeBattleground { get; set; }
        public string ExtraDifficulty { get; set; }
        public bool GodMode { get; set; }
        public bool ShowTrapDamage { get; set; }
        public bool NoTrapCap { get; set; }
        public bool InvincibleBarricades { get; set; }
        public bool TrapsInTraps { get; set; }
        public bool Hardcore { get; set; }
        public bool NoLimitUniqueTraps { get; set; }
        public bool NoTrapGrid { get; set; }
        public bool TrapsAnySurface { get; set; }
        public bool EnhancedTrapRotation { get; set; }
        public bool SellTrapsAnytime { get; set; }
        public bool CustomStartCoinEnabled { get; set; }
        public int StartingCoin { get; set; }
        public string AdditionalHeroWeapon { get; set; } = "";
        public bool AdditionalHeroWeaponEnabled { get; set; }

        private GameConfig() { }

        public static GameConfig Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameConfig();
                    }
                }
                return _instance;
            }
        }

        public void Load()
        {
            string gameConfigFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, GAME_CONFIG_FILE_NAME);
            if (File.Exists(gameConfigFile))
            {
                var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(gameConfigFile));
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

            string gameConfigFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, GAME_CONFIG_FILE_NAME);
            File.WriteAllText(gameConfigFile, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
