using SingleplayerLauncher.Model;
using SingleplayerLauncher.Mods;
using System;
using System.Text;

namespace SingleplayerLauncher
{
    class SpitfireGameUPK
    {
        // TODO: make singleton * Load after initialized

        public static UPKFile SpitfireGameUPKFile;

        private readonly GameInfo GameInfo = GameInfo.Instance;

        private const int MAX_TRAP_TIER = 7;
        private const string TRAP_TIER_STRING = "src.TrapStrength";

        private const int PAR_TIME_CHANGE_INDEX = 0x155A3C2;
        private static readonly byte[] UNIQUE_BYTES_REFERENCE_PAR_TIME = { 0x1B, 0x8B, 0x8F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x28, 0x1D };

        public void ApplyParTime()
        {
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");

            if (GameInfo.Battleground.ParTime != null)
            {
                byte[] parTimeSeconds = BitConverter.GetBytes((int)GameInfo.Battleground.ParTime.TotalSeconds);
                SpitfireGameUPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE_PAR_TIME, PAR_TIME_CHANGE_INDEX, 0, parTimeSeconds);
            }
        }

        public void ApplyTrapTiers()
        {
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Difficulty ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Difficulty), "Mandatory parameter");

            int trapTier = GameInfo.Battleground.Difficulty.TrapTier;
            if (trapTier < 1)
            {
                throw new Exception("Trap Tier should be greater than 1 but it was: " + trapTier);
            }

            if (SpitfireGameUPKFile == null)
            {
                throw new Exception("Null spitfireGameUPKFile");
            }

            foreach (Trap trap in Trap.Traps.Values)
            {
                if (trap.StatModifierExpressions != null)
                {
                    foreach (Trap.StatModifierExpression expression in trap.StatModifierExpressions)
                    {
                        SpitfireGameUPKFile.OverrideBytes(Encoding.ASCII.GetBytes(expression.Expression.Replace(TRAP_TIER_STRING, new String(' ', TRAP_TIER_STRING.Length - 1) + (trapTier - 1))), expression.Offset);
                    }
                }
                else // TripWire and TempleAlarmGong
                {
                    SpitfireGameUPKFile.OverrideBytes(BitConverter.GetBytes((int)Math.Round(trap.CoinCost * (1 - trap.IncreasePerTier * (trapTier - 1)))), trap.CoinCostOffset);
                }

                foreach (int offset in trap.TextureOffsets)
                {
                    if (trap.TextureIds == null)
                    {
                        SpitfireGameUPKFile.OverrideBytes(Trap.DEFAULT_TRAP_TEXTURE_IDS[Math.Min(trapTier, MAX_TRAP_TIER) - 1], offset);
                    }
                    else // assumes that traps with unique TextureIds (WebSpinner) only have 1 texture to replace
                    {
                        SpitfireGameUPKFile.OverrideBytes(trap.TextureIds[Math.Min(trapTier, MAX_TRAP_TIER) - 1], offset);
                    }
                }

                if (trap.IconIds != null)
                {
                    SpitfireGameUPKFile.OverrideBytes(trap.IconIds[Math.Min(trapTier, MAX_TRAP_TIER) / 2 % 4], trap.IconOffset);
                }
            }
        }

        public void ApplyMods()
        {
            Mod.UPKFile = SpitfireGameUPKFile;
            foreach (Mod mod in Mods.Mods.ModList)
            {
                if (mod.IsEnabled)
                {
                    mod.InstallMod();
                }
                else
                {
                    mod.UninstallMod();
                }
            }
        }

        public void ApplyLoadout()
        {
            UPKFile heroObjectContent = new UPKFile(SpitfireGameUPKFile.GetSubArray(GameInfo.Loadout.Hero.UPKFileHeroObjectOffset, GameInfo.Loadout.Hero.UPKFileHeroObjectSize));
            UPKHeroObjectContent uPKHeroObjectContent = new UPKHeroObjectContent(heroObjectContent);
            uPKHeroObjectContent.ApplyLoadoutChanges();
            SpitfireGameUPKFile.OverrideBytes(uPKHeroObjectContent.HeroObjectContent.Bytes, GameInfo.Loadout.Hero.UPKFileHeroObjectOffset);
        }

        public void ApplyHostPatches()
        {
            // Fix the weaver upgrade menu not closing when selecting
            byte[] uniqueBytesWeaverUpgrade = { 0x07, 0x79, 0x00, 0x9A, 0x38, 0x3A, 0x19, 0x01, 0x07, 0xFA, 0xFF, 0xFF, 0x09, 0x00, 0xE3, 0xFE, 0xFF, 0xFF, 0x00, 0x01, 0xE3, 0xFE, 0xFF, 0xFF, 0x38, 0x3A, 0x24 };
            int changeIndexWeaverUpgrade = 0xECCA73;
            SpitfireGameUPKFile.ApplyModification(uniqueBytesWeaverUpgrade, changeIndexWeaverUpgrade, 0, (byte)2);

            // Fix the no aggro (also the map overriding the trap cap, initial coins, etc.)
            byte[] uniqueBytesNoAggro = { 0x18, 0x27, 0x00, 0x9A, 0x38, 0x3A, 0x19, 0x00, 0xAF, 0xA5, 0x00, 0x00, 0x09, 0x00, 0xE3, 0xFE, 0xFF, 0xFF, 0x00, 0x01, 0xE3, 0xFE, 0xFF, 0xFF, 0x38, 0x3A, 0x24 };
            int changeIndexNoAggro = 0x155A4D1;
            SpitfireGameUPKFile.ApplyModification(uniqueBytesNoAggro, changeIndexNoAggro, 0, (byte)2);

            // Fix the par time at top for Host
            byte[] uniqueBytesParTime = { 0x07, 0x65, 0x00, 0x9A, 0x38, 0x3A, 0x19, 0x01, 0x07, 0xFA, 0xFF, 0xFF, 0x09, 0x00, 0xE3, 0xFE, 0xFF, 0xFF, 0x00, 0x01, 0xE3, 0xFE, 0xFF, 0xFF, 0x38, 0x3A, 0x24 };
            int changeIndexParTime = 0x1111436;
            SpitfireGameUPKFile.ApplyModification(uniqueBytesParTime, changeIndexParTime, 0, (byte)2);

            // Fix the shown Rift Points for Host
            byte[] uniqueBytesRiftPoints = { 0x07, 0xAA, 0x00, 0x9A, 0x38, 0x3A, 0x19, 0x01, 0x07, 0xFA, 0xFF, 0xFF, 0x09, 0x00, 0xE3, 0xFE, 0xFF, 0xFF, 0x00, 0x01, 0xE3, 0xFE, 0xFF, 0xFF, 0x38, 0x3A, 0x24 };
            int changeIndexRiftPoints = 0x110C979;
            SpitfireGameUPKFile.ApplyModification(uniqueBytesRiftPoints, changeIndexRiftPoints, 0, (byte)2);

            // Fix the score for Host
            byte[] uniqueBytesScore = { 0x07, 0x76, 0x01, 0x9A, 0x38, 0x3A, 0x19, 0x01, 0x07, 0xFA, 0xFF, 0xFF, 0x09, 0x00, 0xE3, 0xFE, 0xFF, 0xFF, 0x00, 0x01, 0xE3, 0xFE, 0xFF, 0xFF, 0x38, 0x3A, 0x24 };
            int changeIndexScore = 0x110A5EC;
            SpitfireGameUPKFile.ApplyModification(uniqueBytesScore, changeIndexScore, 0, (byte)2);
        }

        public void SaveChanges()
        {
            SpitfireGameUPKFile.Save();
        }
    }
}
