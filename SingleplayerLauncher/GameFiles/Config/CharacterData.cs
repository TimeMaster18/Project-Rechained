using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.Globalization;
using System.Text;
using System.Linq;

namespace SingleplayerLauncher.GameFiles
{
    public static class CharacterData
    {
        // TODO: make singleton

        private static readonly GameInfo GameInfo = GameInfo.Instance;

        private const string CharacterDataIniFileName = "DefaultCharacterData.ini";
        private const string CharacterDataIniPath = "..//SpitfireGame//Config//DefaultCharacterData.ini";

        private const string RCharacterDataSection = "RCharacterData_Time-Master RCharacterData";

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


        public static void ApplyLoadout()
        {
            _ = GameInfo.Loadout ?? throw new ArgumentNullException(nameof(GameInfo.Loadout), "Mandatory parameter");
            _ = GameInfo.Loadout.Hero ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Hero), "Mandatory parameter");
            _ = GameInfo.Loadout.Dye ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Dye), "Mandatory parameter");
            _ = GameInfo.Loadout.SlotItems ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.SlotItems), "Mandatory parameter");
            _ = GameInfo.Loadout.TrapParts ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.TrapParts), "Mandatory parameter");
            _ = GameInfo.Loadout.Guardians ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Guardians), "Mandatory parameter");
            _ = GameInfo.Loadout.Consumables ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Consumables), "Mandatory parameter");
            _ = GameInfo.Loadout.Traits ?? throw new ArgumentNullException(nameof(GameInfo.Loadout.Traits), "Mandatory parameter");
            _ = GameInfo.Battleground.Difficulty ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Difficulty.TrapTier), "Mandatory parameter");


            ConfigFile characterData = new ConfigFile(CharacterDataIniPath);
            IniFile data = characterData.data;

            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyHero, GameInfo.Loadout.Hero.PawnTemplateName);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeySkin, GameInfo.Loadout.Skin.PlayerSkinName);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyDye, GameInfo.Loadout.Dye.SpitfireGameIdBytes.ToString());


            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyLoadout, GenerateItemString(GameInfo.Loadout.Hero.PawnWeaponTemplateName), index: 0);

            int loadoutIdx = 1;
            foreach (SlotItem slotItem in GameInfo.Loadout.SlotItems)
            {
                if (slotItem == null)
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyLoadout, "", index: loadoutIdx);
                } else
                {

                    bool isTrap = slotItem.GetType() == typeof(Trap);
                    data.UpdateEntry(
                        RCharacterDataSection,
                        CharacterDataKeyLoadout,
                        GenerateItemString(
                            slotItem.ItemTemplateName,
                            trapLevel: GameInfo.Battleground.Difficulty.TrapTier,
                            trapParts: isTrap ? GameInfo.Loadout.GetTrapPartsForLoadout(loadoutIdx) : null
                        ),
                        index: loadoutIdx
                    );

                }
                loadoutIdx++;
            }

            int guardianIdx = 0;
            foreach (Guardian guardian in GameInfo.Loadout.Guardians)
            {
                if (guardian == null)
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGuardian, "", index: guardianIdx);
                } else
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGuardian, GenerateItemString(guardian.ItemTemplateName, itemUseCount: 1), index: guardianIdx);
                }
                guardianIdx++;
            }

            int consumableIdx = 0;
            foreach (Consumable consumable in GameInfo.Loadout.Consumables)
            {
                if (consumable == null)
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyConsumable, "", index: consumableIdx);
                } else
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyConsumable, GenerateItemString(consumable.ItemTemplateName, itemUseCount: consumable.UsageLimit), index: consumableIdx);
                }
                consumableIdx++;
            }

            int traitIdx = 0;
            int bonusTraitIdx = 4;
            foreach (Trait trait in GameInfo.Loadout.Traits)
            {
                if (trait == null)
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyTrait, "", index: traitIdx);
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyTrait, "", index: bonusTraitIdx);
                } else
                {
                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyTrait, trait.CodeName, index: traitIdx);

                    string bonusTraitCodeName = GameInfo.Loadout.isTraitMatchingBonus(traitIdx)
                                                ? trait.MatchingBonusTrait.CodeName
                                                : "";

                    data.UpdateEntry(RCharacterDataSection, CharacterDataKeyTrait, bonusTraitCodeName, index: bonusTraitIdx);
                }

                bonusTraitIdx++;
                traitIdx++;
            }

            characterData.Write();
        }

        public static void ApplyMods(bool areEnabled)
        {
            _ = Mods.Mods.GodMode ?? throw new ArgumentNullException(nameof(Mods.Mods.GodMode), "Mandatory parameter");
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Map ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Map), "Mandatory parameter");

            ConfigFile characterData = new ConfigFile(CharacterDataIniPath);
            IniFile data = characterData.data;

            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGodMode, areEnabled ? Mods.Mods.GodMode.IsEnabled.ToString() : false.ToString());

            string startingCoinMultiplier = CalculateMultiplierStartingCoin(areEnabled && Mods.Mods.StartingCoinOverride.IsEnabled, Mods.Mods.StartingCoinOverride.Value, GameInfo.Instance.Battleground.Map);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyBonusStartingCoin, startingCoinMultiplier);

            characterData.Write();
        }

        public static void Initialize()
        {
            FileUtils.CreateBackup(CharacterDataIniFileName, CharacterDataIniPath);

            ConfigFile characterDataConfigFile = new ConfigFile(CharacterDataIniPath, true);
            IniFile data = characterDataConfigFile.data;

            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyPlayerName, DefaultPlayerName);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGuildTag, DefaultGuildTag);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyGuildName, DefaultGuildName);
            data.UpdateEntry(RCharacterDataSection, CharacterDataKeyTeam, DefaultTeam);

            characterDataConfigFile.Write();
        }

        private static string CalculateMultiplierStartingCoin(bool shouldOverride, int startingCoin, Map map)
        {
            string mapName = map.Name;
            int targetStartingCoin = shouldOverride ? startingCoin : map.StartingCoin;

            if (mapName.Contains("Tutorial") || mapName.Contains("Prologue"))
            {
                return "0";
            }
            else if (startingCoin <= 0)
            {
                return "-1";
            }
            else
            {
                double startingCoinsMultiplier = (double)targetStartingCoin / map.StartingCoin; // TODO handle non-server mode
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
