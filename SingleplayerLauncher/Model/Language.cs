using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public class Language
    {
        public static readonly Dictionary<string, string> languageMap = new Dictionary<string, string>
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
    }
}
