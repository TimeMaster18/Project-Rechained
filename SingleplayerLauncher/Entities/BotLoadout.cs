using SingleplayerLauncher.Model;
using static SingleplayerLauncher.Model.Wave;
using static SingleplayerLauncher.Model.Trap;
using static SingleplayerLauncher.Model.Gear;
using static SingleplayerLauncher.Model.SiegeTrait;

namespace ProjectRechained.Entities
{
    public class BotLoadout
    {
        // Base Waves, SlotItems, and Traits
        private static readonly Wave[] BaseWaves1 =
        {
            LightSoldiersLvl1Wave, GnollHuntersLvl1Wave,
            LightSoldiersLvl2Wave, GnollHuntersLvl2Wave,
            GiantsLvl3Wave, PrideHuntersLvl3Wave,
            GiantsLvl4Wave, FireMagesLvl4Wave,
            BulgodArmoredOgre, BulgodArmoredOgre
        };

        private static readonly Wave[] BaseWaves2 =
        {
            GrizzlyBearsLvl1Wave, CrossbowOrcsLvl1Wave,
            GrizzlyBearsLvl2Wave, CrossbowOrcsLvl2Wave,
            OgresLvl3Wave, HumanCrossbowmenLvl3Wave,
            TrollsLvl4Wave, FireMagesLvl4Wave,
            BulgodArmoredOgre, BulgodArmoredOgre
        };

        private static readonly SlotItem[] BaseDefenderSlotItems =
        {
            MendingRoot, MagesClover,
            Barricade, ViscousTar, Brimstone, BGHCeilingBallista, CeilingBallista, ArrowWall, null
        };

        private static readonly SlotItem[] BaseAttackerSlotItems =
        {
            MendingRoot, MagesClover, MagesPicnic, FreedomTrinket,
            null, null, null, null, null
        };

        private static readonly SiegeTrait[] BaseDefenderTraits =
        {
            DoesntPlayWellWithOthers, StrangeSenseOfHumor, WalksItOff, OneWithTheTraps
        };

        private static readonly SiegeTrait[] BaseAttackerTraits =
        {
            BornLeader, NotScaredOfStatues, PracticesWitchcraft, MotivatesOthers
        };

        // Static Bot Loadouts
        public static SiegeLoadout BaseMaximilian = new()
        {
            PlayerName = "Maximilian",
            Hero = Hero.Maximilian,
            Skin = Skin.CardboardSamurai,
            Role = SiegeRole.Defender,
            Waves = BaseWaves1,
            SlotItems = BaseDefenderSlotItems,
            Traits = BaseDefenderTraits
        };

        public static SiegeLoadout BaseGabriella = new()
        {
            PlayerName = "Gabriella",
            Hero = Hero.Gabriella,
            Skin = Skin.MistressOfIllusion,
            Role = SiegeRole.Defender,
            Waves = BaseWaves2,
            SlotItems = BaseDefenderSlotItems,
            Traits = BaseDefenderTraits
        };

        public static SiegeLoadout BaseSmolder = new()
        {
            PlayerName = "Smolder",
            Hero = Hero.Smolder,
            Skin = Skin.KillAuea,
            Role = SiegeRole.Defender,
            Waves = BaseWaves2,
            SlotItems = BaseDefenderSlotItems,
            Traits = BaseDefenderTraits
        };

        public static SiegeLoadout BaseZoey = new()
        {
            PlayerName = "Zoey",
            Hero = Hero.Zoey,
            Skin = Skin.JurassicJourney,
            Role = SiegeRole.Defender,
            Waves = BaseWaves1,
            SlotItems = BaseDefenderSlotItems,
            Traits = BaseDefenderTraits
        };

        public static SiegeLoadout BaseHogarth = new()
        {
            PlayerName = "Hogarth",
            Hero = Hero.Hogarth,
            Skin = Skin.GodOfPlunder,
            Role = SiegeRole.Attacker,
            Waves = BaseWaves1,
            SlotItems = BaseAttackerSlotItems,
            Traits = BaseAttackerTraits
        };

        public static SiegeLoadout BaseIvy = new()
        {
            PlayerName = "Ivy",
            Hero = Hero.Ivy,
            Skin = Skin.FlowerFriend,
            Role = SiegeRole.Attacker,
            Waves = BaseWaves2,
            SlotItems = BaseAttackerSlotItems,
            Traits = BaseAttackerTraits
        };

        public static SiegeLoadout BaseOziel = new()
        {
            PlayerName = "Oziel",
            Hero = Hero.Oziel,
            Skin = Skin.StringTheory,
            Role = SiegeRole.Attacker,
            Waves = BaseWaves1,
            SlotItems = BaseAttackerSlotItems,
            Traits = BaseAttackerTraits
        };

        public static SiegeLoadout BaseSirWinston = new()
        {
            PlayerName = "SirWinston",
            Hero = Hero.SirWinston,
            Skin = Skin.DarkPaladin,
            Role = SiegeRole.Attacker,
            Waves = BaseWaves2,
            SlotItems = BaseAttackerSlotItems,
            Traits = BaseAttackerTraits
        };
    }
}
