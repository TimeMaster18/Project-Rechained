using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.Globalization;
using System.Text;
using System.Linq;
using System.IO;

namespace SingleplayerLauncher.GameFiles
{
    public static class CharacterData
    {
        // TODO: make singleton and read after initialization

        private static readonly GameInfo GameInfo = GameInfo.Instance;

        private const string DefaultPlayerName = "TimeMaster";
        private const string DefaultGuildTag = "~(^-^)~";
        private const string DefaultGuildName = "ComboCalypse";
        private const string DefaultTeam = "1";

        private const string CharacterDataKeyHero = "PawnTemplateName";
        private const string CharacterDataKeySkin = "PlayerSkinName";
        private const string CharacterDataKeyDye = "HeroicDyeIdx";
        private const string CharacterDataKeyLoadout = "EquippableInventory";
        private const string CharacterDataKeyGuardian = "PlaceableGuardians";
        private const string CharacterDataKeyConsumable = "Consumables";
        private const string CharacterDataKeyTrait = "PassiveUpgrades";

        private const string CharacterDataKeyGodMode = "GodMode";
        private const string CharacterDataKeyBonusStartingCoin = "BonusStartingCoin";

        private const string CharacterDataKeyPlayerName = "PlayerName";
        private const string CharacterDataKeyGuildTag = "GuildTag";
        private const string CharacterDataKeyGuildName = "GuildName";
        private const string CharacterDataKeyTeam = "Team";

        private const int BASE_STARTING_COIN_SERVER_MODE = 6000;

        public static void ApplyLoadout(Loadout loadout)
        {
            ValidateLoadout(loadout);

            string characterDataSection = $"RCharacterData_{loadout.PlayerName} RCharacterData";
            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME));
            IniFile data = characterData.data;

            UpdateCharacterDataEntries(data, characterDataSection, loadout);
            UpdateLoadoutEntries(data, characterDataSection, loadout);
            UpdateGuardianEntries(data, characterDataSection, loadout);
            UpdateConsumableEntries(data, characterDataSection, loadout);
            UpdateTraitEntries(data, characterDataSection, loadout);

            characterData.Write();
        }

        public static void ApplyMods(bool areEnabled)
        {
            _ = Mods.Mods.GodMode ?? throw new ArgumentNullException(nameof(Mods.Mods.GodMode), "Mandatory parameter");
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Map ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Map), "Mandatory parameter");

            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME));
            IniFile data = characterData.data;

            string RCharacterDataSection = $"RCharacterData_{GameInfo.Loadout.PlayerName} RCharacterData";
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGodMode, areEnabled ? Mods.Mods.GodMode.IsEnabled.ToString() : false.ToString());

            string startingCoinMultiplier = CalculateMultiplierStartingCoin(areEnabled && Mods.Mods.StartingCoinOverride.IsEnabled, Mods.Mods.StartingCoinOverride.Value, GameInfo.Instance.Battleground.Map);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyBonusStartingCoin, startingCoinMultiplier);

            characterData.Write();
        }

        public static void Initialize()
        {
            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME), true);
            characterData.Write();
        }

        private static void ValidateLoadout(Loadout loadout)
        {
            var _ = loadout ?? throw new ArgumentNullException(nameof(loadout), "Mandatory parameter");

            if (loadout.Hero == null) throw new ArgumentNullException(nameof(loadout.Hero), "Mandatory parameter");
            if (loadout.Dye == null) throw new ArgumentNullException(nameof(loadout.Dye), "Mandatory parameter");
            if (loadout.SlotItems == null) throw new ArgumentNullException(nameof(loadout.SlotItems), "Mandatory parameter");
            if (loadout.TrapParts == null) throw new ArgumentNullException(nameof(loadout.TrapParts), "Mandatory parameter");
            if (loadout.Guardians == null) throw new ArgumentNullException(nameof(loadout.Guardians), "Mandatory parameter");
            if (loadout.Consumables == null) throw new ArgumentNullException(nameof(loadout.Consumables), "Mandatory parameter");
            if (loadout.Traits == null) throw new ArgumentNullException(nameof(loadout.Traits), "Mandatory parameter");
            if (loadout.PlayerName == null) throw new ArgumentNullException(nameof(loadout.PlayerName), "Mandatory parameter");
            if (GameInfo.Battleground.Difficulty == null) throw new ArgumentNullException(nameof(GameInfo.Battleground.Difficulty.TrapTier), "Mandatory parameter");
        }

        private static void UpdateCharacterDataEntries(IniFile data, string section, Loadout loadout)
        {
            data.UpdateEntry(section, CharacterDataKeyHero, loadout.Hero.PawnTemplateName);
            data.UpdateEntry(section, CharacterDataKeySkin, loadout.Skin.PlayerSkinName);
            data.UpdateEntry(section, CharacterDataKeyDye, loadout.Dye.CodeName.ToString());
            data.UpdateEntry(section, CharacterDataKeyPlayerName, loadout.PlayerName);
            data.UpdateEntry(section, CharacterDataKeyGuildTag, DefaultGuildTag);
            data.UpdateEntry(section, CharacterDataKeyGuildName, DefaultGuildName);
            data.UpdateEntry(section, CharacterDataKeyTeam, DefaultTeam);
        }

        private static void UpdateLoadoutEntries(IniFile data, string section, Loadout loadout)
        {
            data.UpdateEntry(section, CharacterDataKeyLoadout, GenerateItemString(loadout.Hero.PawnWeaponTemplateName), index: 0);

            for (int i = 0; i < loadout.SlotItems.Length; i++)
            {
                var slotItem = loadout.SlotItems[i];
                string itemString = slotItem == null ? "" : GenerateItemString(slotItem.ItemTemplateName, GameInfo.Battleground.Difficulty.TrapTier, slotItem is Trap ? loadout.GetTrapPartsForLoadout(i + 1) : null);
                data.UpdateEntry(section, CharacterDataKeyLoadout, itemString, index: i + 1);
            }
        }

        private static void UpdateGuardianEntries(IniFile data, string section, Loadout loadout)
        {
            for (int i = 0; i < loadout.Guardians.Length; i++)
            {
                var guardian = loadout.Guardians[i];
                string itemString = guardian == null ? "" : GenerateItemString(guardian.ItemTemplateName, itemUseCount: 1);
                data.UpdateEntry(section, CharacterDataKeyGuardian, itemString, index: i);
            }
        }

        private static void UpdateConsumableEntries(IniFile data, string section, Loadout loadout)
        {
            for (int i = 0; i < loadout.Consumables.Length; i++)
            {
                var consumable = loadout.Consumables[i];
                string itemString = consumable == null ? "" : GenerateItemString(consumable.ItemTemplateName, itemUseCount: consumable.UsageLimit);
                data.UpdateEntry(section, CharacterDataKeyConsumable, itemString, index: i);
            }
        }

        private static void UpdateTraitEntries(IniFile data, string section, Loadout loadout)
        {
            for (int i = 0; i < loadout.Traits.Length; i++)
            {
                var trait = loadout.Traits[i];
                string traitCodeName = trait?.CodeName ?? "";
                string bonusTraitCodeName = trait != null && loadout.isTraitMatchingBonus(i) ? trait.MatchingBonusTrait.CodeName : "";

                data.UpdateEntry(section, CharacterDataKeyTrait, traitCodeName, index: i);
                data.UpdateEntry(section, CharacterDataKeyTrait, bonusTraitCodeName, index: i + 4);
            }
        }

        private static string CalculateMultiplierStartingCoin(bool shouldOverride, int startingCoin, Map map)
        {
            string mapName = map.Name;
            int targetStartingCoin = shouldOverride ? startingCoin : map.StartingCoin;

            if (mapName.Contains("Tutorial") || mapName.Contains("Prologue"))
            {
                return "0";
            }
            else if (targetStartingCoin <= 0)
            {
                return "-1";
            }
            else
            {
                double startingCoinsMultiplier = (double)targetStartingCoin / map.StartingCoin;
                startingCoinsMultiplier--; // it's a multiplier, so it needs an offset of -1

                return startingCoinsMultiplier.ToString("F6", CultureInfo.InvariantCulture);
            }

        }

        private static string GenerateItemString(string itemTemplateName, int? trapLevel = null, TrapPart[] trapParts = null, int? itemUseCount = null)
        {
            if (string.IsNullOrEmpty(itemTemplateName))
            {
                throw new ArgumentException("ItemTemplateName is mandatory.");
            }

            if (trapLevel.HasValue && (trapLevel < 1 || trapLevel > 7))
            {
                throw new ArgumentOutOfRangeException(nameof(trapLevel), "Strength must be between 1 and 7.");
            }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"(ItemTemplateName=\"{itemTemplateName}\"");

            if (trapLevel.HasValue)
            {
                // - 1 since the config uses 0 to 6 instead of 1 to 7
                stringBuilder.Append($", Strength={trapLevel.Value - 1}");
            }

            if (trapParts != null && trapParts.Length > 0)
            {
                var trapPartsString = string.Join(", ", trapParts.Select(tp => tp == null ? "" : $"\"{tp.ItemTinkerEffect}\""));
                stringBuilder.Append($", ItemTinkerEffects=({trapPartsString})");
            }

            if (itemUseCount.HasValue)
            {
                stringBuilder.Append($", ItemUseCount={itemUseCount.Value}");
            }

            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }
    }


}
