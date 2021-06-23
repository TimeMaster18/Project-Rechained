using System.Collections.Generic;

namespace SingleplayerLauncher.Resources
{
    internal class DefaultValues
    {
        // Game Running
        public const string ExeArguments = " -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";

        // Form Defaults
        public const string SelectedHero = "Maximilian"; // Default selected Hero "Maximilian" Main Hero of the OrcsMustDie! Saga
        public const string SelectedSkin = "Default";  // Default selected skin
        public const string SelectedDye = "Normal";  // Default selected Normal dye

        public const string SelectedMap = "The Baths"; // Default Selected "The Baths" because it's well optimised and Iconic Level 
        public const string SelectedGameMode = "Survival"; // Default selected Game Mode "Survival"

        public const bool CustomIniSetting = true;

        // Config Defaults
        public static readonly Dictionary<string, string> CharacterDataSection = new Dictionary<string, string>
        {
            { "PlayerName",         "Savitar"                           },
            { "GuildTag",           "~(^-^)~"                           },
            { "GuildName",          "ComboCalypse"                      },
            { "PawnTemplateName",   "PawnWeapon_Warmage.Pawn_Warmage"   },
            { "Team" ,              "1"                                 },
            { "HeroicDyeIdx",       "Normal"                            },
            { "GodMode",            "FALSE"                             }
        };

        public static readonly Dictionary<string, string> GameReplicationInfoSection = new Dictionary<string, string>
        {
            { "DefaultOfflineDifficulty",                       "1"         },
            { "PlayerCountOverride",                            "1"         },
            { "DefaultOfflineSuggestedLevel",                   "1"         },
            { "DefaultOfflinePlayerLevel",                      "1"         },
            { "DefaultOfflinePauseTimerDurationInSeconds",      "999999"    }
        };

        // Loadout defaults
        public static readonly string[] Loadout =
        {
            "Mending Root",     "Mage's Clover",        "Barricade",
            "Viscous Tar",      "Flip Trap",            "Wall Blades",
            "Arrow Wall",       "Concussive Pounder",   "Ceiling Ballista"
        };

        public static readonly string[] Guardians =
        {
            "Dragon Guardian",     "Serpent Guardian"
        };
    }
}
