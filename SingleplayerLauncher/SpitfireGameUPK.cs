using SingleplayerLauncher.Model;
using SingleplayerLauncher.Mods;
using SingleplayerLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher
{
    class SpitfireGameUPK
    {
        public static UPKFile SpitfireGameUPKFile;

        private readonly GameInfo GameInfo = GameInfo.Instance;

        private const int MAX_TRAP_TIER = 7;
        private const string TRAP_TIER_STRING = "src.TrapStrength";

        public void ApplyTrapTiers()
        {
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(GameInfo.Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Difficulty ?? throw new ArgumentNullException(nameof(GameInfo.Battleground.Difficulty), "Mandatory parameter");

            int trapTier = GameInfo.Battleground.Difficulty.TrapTier;
            if (trapTier < 1)
                throw new Exception("Trap Tier should be greater than 1 but it was: " + trapTier);
            if (SpitfireGameUPKFile == null)
                throw new Exception("Null spitfireGameUPKFile");

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
                        SpitfireGameUPKFile.OverrideBytes(Trap.DEFAULT_TRAP_TEXTURE_IDS[Math.Min(trapTier, MAX_TRAP_TIER) - 1], offset);
                    else // assumes that traps with unique TextureIds (WebSpinner) only have 1 texture to replace
                        SpitfireGameUPKFile.OverrideBytes(trap.TextureIds[Math.Min(trapTier, MAX_TRAP_TIER) - 1], offset);
                }

                if (trap.IconIds != null)
                    SpitfireGameUPKFile.OverrideBytes(trap.IconIds[Math.Min(trapTier, MAX_TRAP_TIER) / 2 % 4], trap.IconOffset);
            }
        }

        public void ApplyMods()
        {
            Mod.UPKFile = SpitfireGameUPKFile;
            foreach (Mod mod in Mods.Mods.ModList)
            {
                if (mod.IsEnabled)
                    mod.InstallMod();
                else
                    mod.UninstallMod();
            }
        }
        public void ApplyLoadout()
        {
            UPKFile heroObjectContent = new UPKFile(SpitfireGameUPKFile.GetSubArray(GameInfo.Loadout.Hero.UPKFileHeroObjectOffset, GameInfo.Loadout.Hero.UPKFileHeroObjectSize));
            UPKHeroObjectContent uPKHeroObjectContent = new UPKHeroObjectContent(heroObjectContent);
            uPKHeroObjectContent.ApplyLoadoutChanges();
            SpitfireGameUPKFile.OverrideBytes(uPKHeroObjectContent.HeroObjectContent.Bytes, GameInfo.Loadout.Hero.UPKFileHeroObjectOffset);
        }

        public void SaveChanges()
        {
            SpitfireGameUPKFile.Save();
        }
    }
}
