using System;
using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public class Language
    {
        private static readonly Dictionary<string, string> languageMap = new Dictionary<string, string>
        {
            { "CHN", "Chinese" },
            { "DEU", "Deutsch" },
            { "ESN", "Español" },
            { "FRA", "Français" },
            { "INT", "English" },
            { "ITA", "Italiano" },
            { "POL", "Polski" },
            { "PTB", "Português" },
            { "RUS", "Русский" },
            { "TUR", "Türkçe" }
        };

        public static Dictionary<string, string> GetLanguageMap()
        {
            return languageMap;
        }
        public static string GetKeyFromValue(string value)
        {
            foreach (var kvp in languageMap)
            {
                if (kvp.Value.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    return kvp.Key;
                }
            }
            return null;
        }
    }
}
