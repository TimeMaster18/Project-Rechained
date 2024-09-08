﻿using System.Collections.Generic;

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
    }
}
