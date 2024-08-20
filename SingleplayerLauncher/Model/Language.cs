using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public class Language
    {
        public static readonly Dictionary<string, string> survivalLanguageMap = new()
        {
            { "Chinese" , "CHN" },
            { "Deutsch" , "DEU" },
            { "Español" , "ESN" },
            { "Français" , "FRA" },
            { "English" , "INT" },
            { "Italiano" , "ITA" },
            { "Polski" , "POL" },
            { "Português" , "PTB" },
            { "Русский" , "RUS" },
            { "Türkçe" , "TUR" }
        };

        public static readonly Dictionary<string, string> siegeLanguageMap = new()
        {
            { "Chinese" , "CHN" },
            { "Deutsch" , "DEU" },
            { "Español" , "ESN" },
            { "Français" , "FRA" },
            { "English" , "INT" },
            { "Italiano" , "ITA" },
            { "Polski" , "POL" },
            { "Türkçe" , "TUR" }
        };
    }
}
