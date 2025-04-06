using System.Collections.Generic;
using SingleplayerLauncher.Names;

namespace SingleplayerLauncher.Mods
{
    static class Mods
    {
        // static members
        public static Mod NoTrapCap = new NoTrapCap();
        public static Mod NoLimitUniqueTraps = new NoLimitUniqueTraps();
        public static Mod InvincibleBarricades = new InvincibleBarricades();
        public static Mod TrapsAnySurface = new TrapsAnySurface();
        public static Mod TrapsInTraps = new TrapsInTraps();
        public static Mod NoTrapGrid = new NoTrapGrid();
        public static Mod GodMode = new GodMode();
        public static Mod ShowTrapDamageFlyoffs = new ShowTrapDamageFlyoffs();
        public static Mod Hardcore = new Hardcore();
        public static Mod EnhancedTrapRotation = new EnhancedTrapRotation();
        public static Mod SellTrapsAnytime = new SellTrapsAnytime();
        public static Mod StartingCoinOverride = new StartingCoinOverride();
        public static Mod AccountLevelOverride = new AccountLevelOverride();
        public static Mod TrapTierOverride = new TrapTierOverride();
        public static AdditionalHeroWeapon AdditionalHeroWeapon = new();

        public readonly static List<Mod> ModList =
        [
            NoTrapCap,
            NoLimitUniqueTraps,
            InvincibleBarricades,
            TrapsAnySurface,
            TrapsInTraps,
            NoTrapGrid,
            GodMode,
            ShowTrapDamageFlyoffs,
            Hardcore,
            EnhancedTrapRotation,
            SellTrapsAnytime,
            StartingCoinOverride,
            AccountLevelOverride, 
            TrapTierOverride,
            AdditionalHeroWeapon
        ];

        public readonly static Dictionary<string, Mod> ModsByName = new()
        {
            { Names.Mod.NO_TRAP_CAP, NoTrapCap },
            { Names.Mod.NO_LIMIT_UNIQUE_TRAPS, NoLimitUniqueTraps },
            { Names.Mod.INVINCIBLE_BARRICADES, InvincibleBarricades },
            { Names.Mod.TRAPS_ANY_SURFACE, TrapsAnySurface },
            { Names.Mod.TRAPS_IN_TRAPS, TrapsInTraps },
            { Names.Mod.NO_TRAP_GRID, NoTrapGrid },
            { Names.Mod.GOD_MODE, GodMode },
            { Names.Mod.SHOW_TRAP_DAMAGE_FLYOFFS, ShowTrapDamageFlyoffs },
            { Names.Mod.HARDCORE, Hardcore },
            { Names.Mod.ENHANCED_TRAP_ROTATION, EnhancedTrapRotation },
            { Names.Mod.SELL_TRAPS_ANYTIME, SellTrapsAnytime },
            { Names.Mod.STARTING_COIN_OVERRIDE, StartingCoinOverride },
            { Names.Mod.ACCOUNT_LEVEL_OVERRIDE, AccountLevelOverride },
            { Names.Mod.TRAP_TIER_OVERRIDE, TrapTierOverride },
            { Names.Mod.ADDITIONAL_HERO_WEAPON, AdditionalHeroWeapon }
        };
    }
}
