using IniParser.Model;
using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.Globalization;

namespace SingleplayerLauncher.GameSettings
{
    public static class CharacterData
    {
        private static readonly GameInfo GameInfo = GameInfo.Instance;

        private const string CharacterDataIniFileName = "DefaultCharacterData.ini";
        private const string CharacterDataIniPath = "..//SpitfireGame//Config//DefaultCharacterData.ini";

        private const string RCharacterDataSection = "RCharacterData_0 RCharacterData";

        private const string CharacterDataKeyGodMode = "GodMode";
        private const string CharacterDataKeyHero = "PawnTemplateName";
        private const string CharacterDataKeyDye = "HeroicDyeIdx";
        private const string CharacterDataKeyBonusStartingCoin = "BonusStartingCoin";

        private const string CharacterDataKeyPlayerName = "PlayerName";
        private const string CharacterDataKeyGuildTag = "GuildTag";
        private const string CharacterDataKeyGuildName = "GuildName";
        private const string CharacterDataKeyTeam = "Team";

        private const string DefaultPlayerName = "TimeMaster";
        private const string DefaultGuildTag = "~(^-^)~";
        private const string DefaultGuildName = "ComboCalypse";
        private const string DefaultTeam = "1";

        public static void Apply()
        {
            _ = GameInfo.Loadout ?? throw new ArgumentNullException(nameof(GameInfo.Loadout), "Mandatory parameter");
            _ = GameInfo.Loadout.Hero ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Hero), "Mandatory parameter");
            _ = GameInfo.Loadout.Dye ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Dye), "Mandatory parameter");
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Map ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Map), "Mandatory parameter");
            _ = Mods.Mods.GodMode ?? throw new ArgumentNullException(nameof(Mods.Mods.GodMode), "Mandatory parameter");

            ConfigFile characterData = new ConfigFile(CharacterDataIniPath);
            IniData data = characterData.data;

            data[RCharacterDataSection][CharacterDataKeyHero] = GameInfo.Loadout.Hero.PawnWeaponString;
            data[RCharacterDataSection][CharacterDataKeyDye] = GameInfo.Loadout.Dye.Id.ToString();

            data[RCharacterDataSection][CharacterDataKeyGodMode] = Mods.Mods.GodMode.IsEnabled ? "TRUE" : "FALSE";

            int startingCoin = GameInfo.Battleground.StartingCoin != 0 ? GameInfo.Battleground.StartingCoin : GameInfo.Battleground.Map.StartingCoin;
            data[RCharacterDataSection][CharacterDataKeyBonusStartingCoin] = CalculateMultiplierStartingCoin(startingCoin);

            characterData.Write(data);
        }

        public static void Initialize()
        {
            FileUtils.CreateBackup(CharacterDataIniFileName, CharacterDataIniPath);

            ConfigFile characterDataConfigFile = new ConfigFile(CharacterDataIniPath, true);
            IniData data = characterDataConfigFile.data;

            data.Sections.AddSection(RCharacterDataSection);

            data[RCharacterDataSection][CharacterDataKeyPlayerName] = DefaultPlayerName;
            data[RCharacterDataSection][CharacterDataKeyGuildTag] = DefaultGuildTag;
            data[RCharacterDataSection][CharacterDataKeyGuildName] = DefaultGuildName;
            data[RCharacterDataSection][CharacterDataKeyTeam] = DefaultTeam;

            characterDataConfigFile.Write(data);
        }

        private static string CalculateMultiplierStartingCoin(int startingCoin)
        {
            string mapName = GameInfo.Instance.Battleground.Map.Name;

            if (mapName.Contains("Tutorial") || mapName.Contains("Prologue"))
            {
                return "0";
            }
            else if (startingCoin == -1)
            {
                return "0";
            }
            else if (startingCoin == 0)
            {
                return "-1";
            }
            else
            {
                int baseStartingCoins = GameInfo.Instance.Battleground.Map.StartingCoin;

                double startingCoinsMultiplier = (double)startingCoin / baseStartingCoins;
                startingCoinsMultiplier--; // it's a multiplier, so it needs an offset of -1

                return startingCoinsMultiplier.ToString("F6", CultureInfo.InvariantCulture);
            }

        }
    }


}
