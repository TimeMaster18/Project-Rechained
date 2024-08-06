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
        private const string CharacterDataKeyWave = "Waves";

        private const string CharacterDataKeyGodMode = "GodMode";
        private const string CharacterDataKeyBonusStartingCoin = "BonusStartingCoin";

        private const string CharacterDataKeyPlayerName = "PlayerName";
        private const string CharacterDataKeyGuildTag = "GuildTag";
        private const string CharacterDataKeyGuildName = "GuildName";
        private const string CharacterDataKeyTeam = "Team";

        private const int BASE_STARTING_COIN_SERVER_MODE = 6000;

        public static void ApplySiegeLoadout(SiegeLoadout loadout, int team = 1)
        {
            ValidateSiegeLoadout(loadout);

            string characterDataSection = $"RCharacterData_{loadout.PlayerName} RCharacterData";
            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME));
            IniFile data = characterData.data;

            UpdateCharacterDataEntries(data, characterDataSection, loadout, team);
            UpdateLoadoutEntries(data, characterDataSection, loadout);
            UpdateTraitEntries(data, characterDataSection, loadout);
            UpdateWaveEntries(data, characterDataSection, loadout);
            UpdateRoleEntry(data, characterDataSection, loadout);

            characterData.Write();
        }

        public static void ApplyLoadout(SurvivalLoadout loadout)
        {
            ValidateSurvivalLoadout(loadout);

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
            _ = GameInfo.SurvivalBattleground ?? throw new ArgumentNullException(nameof(GameInfo.SurvivalBattleground), "Mandatory parameter");
            _ = GameInfo.SurvivalBattleground.Map ?? throw new ArgumentNullException(nameof(GameInfo.SurvivalBattleground.Map), "Mandatory parameter");

            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME));
            IniFile data = characterData.data;

            string RCharacterDataSection = $"RCharacterData_{GameInfo.SurvivalLoadout.PlayerName} RCharacterData";
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGodMode, areEnabled ? Mods.Mods.GodMode.IsEnabled.ToString() : false.ToString());

            string startingCoinMultiplier = CalculateMultiplierStartingCoin(areEnabled && Mods.Mods.StartingCoinOverride.IsEnabled, Mods.Mods.StartingCoinOverride.Value, GameInfo.Instance.SurvivalBattleground.Map);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyBonusStartingCoin, startingCoinMultiplier);

            characterData.Write();
        }

        public static void Initialize()
        {
            ConfigFile characterData = new ConfigFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME), true);
            characterData.Write();
        }

        private static void ValidateSurvivalLoadout(SurvivalLoadout loadout)
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
            if (GameInfo.SurvivalBattleground.Difficulty == null) throw new ArgumentNullException(nameof(GameInfo.SurvivalBattleground.Difficulty.TrapTier), "Mandatory parameter");
        }

        private static void ValidateSiegeLoadout(SiegeLoadout loadout)
        {
            var _ = loadout ?? throw new ArgumentNullException(nameof(loadout), "Mandatory parameter");

            if (loadout.Hero == null) throw new ArgumentNullException(nameof(loadout.Hero), "Mandatory parameter");
            if (loadout.Dye == null) throw new ArgumentNullException(nameof(loadout.Dye), "Mandatory parameter");
            if (loadout.SlotItems == null) throw new ArgumentNullException(nameof(loadout.SlotItems), "Mandatory parameter");
            if (loadout.Role == null) throw new ArgumentNullException(nameof(loadout.Role), "Mandatory parameter");
            if (loadout.Waves == null) throw new ArgumentNullException(nameof(loadout.Waves), "Mandatory parameter");
            if (loadout.Traits == null) throw new ArgumentNullException(nameof(loadout.Traits), "Mandatory parameter");
            if (loadout.PlayerName == null) throw new ArgumentNullException(nameof(loadout.PlayerName), "Mandatory parameter");
        }

        private static void UpdateCharacterDataEntries(IniFile data, string section, BaseLoadout loadout, int team=1)
        {
            bool isSiege = loadout.GetType() == typeof(SiegeLoadout);
            data.UpdateEntry(section, CharacterDataKeyHero, isSiege ? loadout.Hero.SiegeTemplateName : loadout.Hero.PawnTemplateName);
            data.UpdateEntry(section, CharacterDataKeySkin, loadout.Skin.PlayerSkinName);
            data.UpdateEntry(section, CharacterDataKeyDye, loadout.Dye.CodeName.ToString());
            data.UpdateEntry(section, CharacterDataKeyPlayerName, loadout.PlayerName);
            data.UpdateEntry(section, CharacterDataKeyGuildTag, DefaultGuildTag); // TODO add a different one for each team
            data.UpdateEntry(section, CharacterDataKeyGuildName, DefaultGuildName);
            data.UpdateEntry(section, CharacterDataKeyTeam, team.ToString());
        }

        private static void UpdateLoadoutEntries(IniFile data, string section, BaseLoadout loadout)
        {
            bool isSiege = loadout.GetType() == typeof(SiegeLoadout);
            int loadoutIdx = 0;
            string pawnWeaponTemplateName = isSiege ? loadout.Hero.SiegePawnWeaponTemplateName : loadout.Hero.PawnWeaponTemplateName;
            data.UpdateEntry(section, CharacterDataKeyLoadout, GenerateItemString(pawnWeaponTemplateName), index: loadoutIdx);
            loadoutIdx++;

            if (GameConfig.Instance.ModsEnabled && GameConfig.Instance.AdditionalHeroWeaponEnabled)
            {
                string additionalPawnWeaponTemplateName = Model.Hero.Heroes[GameConfig.Instance.AdditionalHeroWeapon]?.PawnWeaponTemplateName;
                data.UpdateEntry(section, CharacterDataKeyLoadout, GenerateItemString(additionalPawnWeaponTemplateName), index: loadoutIdx);
                loadoutIdx++;
            }

            for (int i = 0; i < SurvivalLoadout.SLOT_ITEMS_COUNT; loadoutIdx++, i++)
            {
                var slotItem = loadout.SlotItems[i];
                bool isTrap = slotItem is Trap;

                TrapPart[] parts = isTrap && !isSiege ? ((SurvivalLoadout)loadout).GetTrapPartsForLoadout(i) : null;
                int? trapTier = isTrap && !isSiege ? GameInfo.SurvivalBattleground.Difficulty.TrapTier : (int?)null;

                string itemString = slotItem == null ? "" : GenerateItemString(slotItem.ItemTemplateName, trapTier, parts);
                data.UpdateEntry(section, CharacterDataKeyLoadout, itemString, index: loadoutIdx);
            }

            if (isSiege)
            {
                string uniqueLoadoutItemSlot = loadout.Hero.SiegeUniqueSlotItem.ItemTemplateName;
                data.UpdateEntry(section, CharacterDataKeyLoadout, GenerateItemString(uniqueLoadoutItemSlot), index: loadoutIdx);
                loadoutIdx++;
            }
        }

        private static void UpdateGuardianEntries(IniFile data, string section, SurvivalLoadout loadout)
        {
            for (int i = 0; i < loadout.Guardians.Length; i++)
            {
                var guardian = loadout.Guardians[i];
                string itemString = guardian == null ? "" : GenerateItemString(guardian.ItemTemplateName, itemUseCount: 1);
                data.UpdateEntry(section, CharacterDataKeyGuardian, itemString, index: i);
            }
        }

        private static void UpdateConsumableEntries(IniFile data, string section, SurvivalLoadout loadout)
        {
            for (int i = 0; i < loadout.Consumables.Length; i++)
            {
                var consumable = loadout.Consumables[i];
                string itemString = consumable == null ? "" : GenerateItemString(consumable.ItemTemplateName, itemUseCount: consumable.UsageLimit);
                data.UpdateEntry(section, CharacterDataKeyConsumable, itemString, index: i);
            }
        }

        private static void UpdateTraitEntries(IniFile data, string section, BaseLoadout loadout)
        {
            for (int i = 0; i < loadout.Traits.Length; i++)
            {
                var trait = loadout.Traits[i];
                string traitCodeName = trait?.CodeName ?? "";
                string bonusTraitCodeName = trait != null && loadout.IsTraitMatchingBonus(i) ? trait.MatchingBonusTrait.CodeName : "";

                data.UpdateEntry(section, CharacterDataKeyTrait, traitCodeName, index: i);
                data.UpdateEntry(section, CharacterDataKeyTrait, bonusTraitCodeName, index: i + 4);
            }
        }

        private static void UpdateRoleEntry(IniFile data, string section, SiegeLoadout loadout)
        {
            data.UpdateEntry(section, CharacterDataKeyTrait, loadout.Role.CodeName, index: 7);
        }

        private static void UpdateWaveEntries(IniFile data, string section, SiegeLoadout loadout)
        {
            for (int i = 0; i < loadout.Waves.Length; i++)
            {
                var wave = loadout.Waves[i];
                string itemString = wave == null ? "" : GenerateItemString(wave.CodeName);
                data.UpdateEntry(section, CharacterDataKeyWave, itemString, index: i);
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
