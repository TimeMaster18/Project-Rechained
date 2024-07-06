using Newtonsoft.Json;
using SingleplayerLauncher.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace SingleplayerLauncher
{
    public class GameConfig : IConfiguration
    {
        private static readonly string GameConfigFile = "gameconfig.json";
        private static GameConfig _instance;
        private static readonly object _lock = new object();

        public bool ModsEnabled { get; set; }
        public string GameMode { get; set; }
        public string Difficulty { get; set; }
        public string Battleground { get; set; }
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
                        _instance.Load();
                    }
                }
                return _instance;
            }
        }

        public void Load()
        {
            if (File.Exists(GameConfigFile))
            {
                var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(GameConfigFile));
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

            File.WriteAllText(GameConfigFile, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
