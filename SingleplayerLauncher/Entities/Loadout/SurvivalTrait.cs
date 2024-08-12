using System.Collections.Generic;
using System.Linq;
using static SingleplayerLauncher.Names.Difficulty;
using static SingleplayerLauncher.Names.Trait;

namespace SingleplayerLauncher.Model
{
    public class SurvivalTrait : Trait
    {

        // Traits
        // Triangle Traits
        public static SurvivalTrait EasilyExcited = new()
        {
            Id = 1,
            CodeName = "SpitfireGame.RTraitEasilyExcited",
            Name = EASILY_EXCITED,
            Description = "Combos fill the Unchained meter by 20% more.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait MakingItRain = new()
        {
            Id = 2,
            CodeName = "SpitfireGame.RTraitMakingItRain",
            Name = MAKING_IT_RAIN,
            Description = "+30% to bonus coin granted by combos.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait NaturalBornSprinter = new()
        {
            Id = 3,
            CodeName = "SpitfireGame.RTraitNaturalBornSprinter",
            Name = NATURAL_BORN_SPRINTER,
            Description = "+50% movement speed while Unchained.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SurvivalTrait KidnappedALeprechaun = new()
        {
            Id = 4,
            CodeName = "SpitfireGame.RTraitStartingCoin3",
            Name = KIDNAPPED_A_LEPRECHAUN,
            Description = "+500 starting coin.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait OverReacting = new()
        {
            Id = 5,
            CodeName = "trait.Upgrades.Adult_Supervision",
            Name = OVER_REACTING,
            Description = "Regenerates +1 mana regeneration per second when below 50% health.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SurvivalTrait AvoidsPain = new()
        {
            Id = 6,
            CodeName = "trait.Upgrades.Afraid_Leave_Home",
            Name = AVOIDS_PAIN,
            Description = "Regenerates 0.5% max health per second when below 50% health.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait FireSale = new()
        {
            Id = 7,
            CodeName = "trait.Upgrades.Fire_Sale",
            Name = FIRE_SALE,
            Description = "-15% fire trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait IceColdDeals = new()
        {
            Id = 8,
            CodeName = "trait.Upgrades.Ice_Cold_Deals",
            Name = ICE_COLD_DEALS,
            Description = "-15% ice trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SurvivalTrait InsaneArcaneSale = new()
        {
            Id = 9,
            CodeName = "trait.Upgrades.Insane_Arcane_Sale",
            Name = INSANE_ARCANE_SALE,
            Description = "-15% arcane trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static SurvivalTrait LightningDeals = new()
        {
            Id = 10,
            CodeName = "trait.Upgrades.Lightning_Deals",
            Name = LIGHTNING_DEALS,
            Description = "-15% lightning trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SurvivalTrait BigSpender = new()
        {
            Id = 11,
            CodeName = "trait.Upgrades.MoneyBags",
            Name = BIG_SPENDER,
            Description = "+250 coin at the beginning of each wave.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait NeverPaysRetail = new()
        {
            Id = 12,
            CodeName = "trait.Upgrades.Never_Pays_Retail",
            Name = NEVER_PAYS_RETAIL,
            Description = "-25% hero respawn buyback cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait OneWithTheTraps = new()
        {
            Id = 13,
            CodeName = "trait.Upgrades.One_With_Traps",
            Name = ONE_WITH_THE_TRAPS,
            Description = "+1 per second mana regeneration near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait Overachiever = new()
        {
            Id = 14,
            CodeName = "trait.Upgrades.Overachiever",
            Name = OVERACHIEVER,
            Description = "+1 battle level at the start of the matches.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SurvivalTrait Overprotective = new()
        {
            Id = 15,
            CodeName = "trait.Upgrades.Overprotective",
            Name = OVERPROTECTIVE,
            Description = "-25% damage taken by traps near the hero.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SurvivalTrait RiftGift = new()
        {
            Id = 16,
            CodeName = "trait.Upgrades.Rift_Gift",
            Name = RIFT_GIFT,
            Description = "+100% mana and health after destroying an unstable rift.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static SurvivalTrait RiftRocket = new()
        {
            Id = 17,
            CodeName = "trait.Upgrades.Rift_Rocket",
            Name = RIFT_ROCKET,
            Description = "+50% movement speed for 5s after destroying an unstable rift.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SurvivalTrait SmashingDeals = new()
        {
            Id = 18,
            CodeName = "trait.Upgrades.Smashing_Deals",
            Name = SMASHING_DEALS,
            Description = "-15% trap cost to traps that deal physical damage.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SurvivalTrait HasATrapFetish = new()
        {
            Id = 19,
            CodeName = "trait.Upgrades.Trap_Fetish",
            Name = HAS_A_TRAP_FETISH,
            Description = "Regenerates +0.6% max health per second near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };

        // Pentagon Traits
        public static SurvivalTrait BelievesSizeMatters = new()
        {
            Id = 20,
            CodeName = "SpitfireGame.RTraitBelieveSizeMatters",
            Name = BELIEVES_SIZE_MATTERS,
            Description = "+15% primary attack damage to large minions when unchained (+25% if team is unchained).",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait UncleKilledByGiant = new()
        {
            Id = 21,
            CodeName = "SpitfireGame.RTraitDamageToGiants3",
            Name = UNCLE_KILLED_BY_GIANT,
            Description = "+12% damage to giants.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SurvivalTrait CatEatenByGnolls = new()
        {
            Id = 22,
            CodeName = "SpitfireGame.RTraitDamageToGnolls3",
            Name = CAT_EATEN_BY_GNOLLS,
            Description = "+12% damage to gnoll hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait BrotherMauledByGrizzlies = new()
        {
            Id = 23,
            CodeName = "SpitfireGame.RTraitDamageToGrizzlies3",
            Name = BROTHER_MAULED_BY_GRIZZLIES,
            Description = "+12% damage to grizzly minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SurvivalTrait SisterEatenByAnOgre = new()
        {
            Id = 24,
            CodeName = "SpitfireGame.RTraitDamageToOgres3",
            Name = SISTER_EATEN_BY_AN_OGRE,
            Description = "+12% damage to ogre minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait DogKilledByPrideHunters = new()
        {
            Id = 25,
            CodeName = "SpitfireGame.RTraitDamageToPrideHunters3",
            Name = DOG_KILLED_BY_PRIDE_HUNTERS,
            Description = "+12% damage to pride hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait GrandmotherEatenByATroll = new()
        {
            Id = 26,
            CodeName = "SpitfireGame.RTraitDamageToTrolls3",
            Name = GRANDMOTHER_EATEN_BY_A_TROLL,
            Description = "+12% damage to troll minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait DifficultyCalmingDown = new()
        {
            Id = 27,
            CodeName = "SpitfireGame.RTraitDifficultyCalmingDown",
            Name = DIFFICULTY_CALMING_DOWN,
            Description = "+15% Unchained duration.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SurvivalTrait AmateurVeterinarian = new()
        {
            Id = 28,
            CodeName = "SpitfireGame.RTraitImprovedHealing3",
            Name = AMATEUR_VETERINARIAN,
            Description = "+25% healing abilities cast on the hero.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SurvivalTrait SoldiersTookMyHorse = new()
        {
            Id = 29,
            CodeName = "SpitfireGame.RTraitSoldiersTookMyHorse",
            Name = SOLDIERS_TOOK_MY_HORSE,
            Description = "+12% damage to soldiers.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait HasUltimateSetOfTools = new()
        {
            Id = 30,
            CodeName = "SpitfireGame.RTraitTrapDamageIncrease3",
            Name = HAS_ULTIMATE_SET_OF_TOOLS,
            Description = "+6% trap damage.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait BearHugs = new()
        {
            Id = 31,
            CodeName = "trait.Upgrades.Bear_Hugs",
            Name = BEAR_HUGS,
            Description = "+8% damage to minions near the hero",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SurvivalTrait HasABigBrother = new()
        {
            Id = 32,
            CodeName = "trait.Upgrades.Big_Brother",
            Name = HAS_A_BIG_BROTHER,
            Description = "+10% damage dealt to minions near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SurvivalTrait KillerBuzz = new()
        {
            Id = 33,
            CodeName = "trait.Upgrades.Killer_Buzz",
            Name = KILLER_BUZZ,
            Description = "+8% damage after kills. Lasts 3s.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait PagingDrLove = new()
        {
            Id = 34,
            CodeName = "trait.Upgrades.Paging_Dr_Love",
            Name = PAGING_DR_LOVE,
            Description = "+25% to hero's healing abilities.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SurvivalTrait RiftAway = new()
        {
            Id = 35,
            CodeName = "trait.Upgrades.Rift_Away",
            Name = RIFT_AWAY,
            Description = "+25% damage to unstable rifts.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SurvivalTrait FeelingFierce = new()
        {
            Id = 36,
            CodeName = "trait.Upgrades.Strange_Humor",
            Name = FEELING_FIERCE,
            Description = "+10% damage when health is above 50%.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SurvivalTrait TriesTooHard = new()
        {
            Id = 37,
            CodeName = "trait.Upgrades.Tries_Too_Hard",
            Name = TRIES_TOO_HARD,
            Description = "+10% damage dealt to mercenaries near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };

        // Diamond Traits
        public static SurvivalTrait EnjoysPain = new()
        {
            Id = 38,
            CodeName = "SpitfireGame.RTraitEnjoysPain",
            Name = ENJOYS_PAIN,
            Description = "Adds +4% lifesteal to physical primary attacks.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static SurvivalTrait ExecutionAdvantage = new()
        {
            Id = 39,
            CodeName = "SpitfireGame.RTraitExecutionAdvantage",
            Name = EXECUTION_ADVANTAGE,
            Description = "Grants a shield worth 30% of the hero's max health for 5s upon killing a boss, mercenary, or hunter.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SurvivalTrait FeelsSafeAtHome = new()
        {
            Id = 40,
            CodeName = "SpitfireGame.RTraitFeelsSafeAtHome",
            Name = FEELS_SAFE_AT_HOME,
            Description = "+6 physical and magical armor when near allied guardians.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static SurvivalTrait PracticesWitchcraft = new()
        {
            Id = 41,
            CodeName = "SpitfireGame.RTraitPracticesWitchcraft",
            Name = PRACTICES_WITCHCRAFT,
            Description = "+5% lifesteal to primary attack when dealing magical damage.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static SurvivalTrait HighPainTolerance = new()
        {
            Id = 42,
            CodeName = "SpitfireGame.RTraitReduceDamageFromMinions3",
            Name = HIGH_PAIN_TOLERANCE,
            Description = "+12% damage reduction against minions.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static SurvivalTrait WalksItOff = new()
        {
            Id = 43,
            CodeName = "SpitfireGame.RTraitRespawnTime3",
            Name = WALKS_IT_OFF,
            Description = "-12% respawn time.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SurvivalTrait TakesLessonsFromCygnus = new()
        {
            Id = 44,
            CodeName = "SpitfireGame.RTraitTakesLessonsFromCygnus",
            Name = TAKES_LESSONS_FROM_CYGNUS,
            Description = "+1% max health for every 50 mana the hero has.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SurvivalTrait WallBuildingPhD = new()
        {
            Id = 45,
            CodeName = "SpitfireGame.RTraitWallBuildingPhD",
            Name = WALL_BUILDING_PHD,
            Description = "Increases barricades' health by 20% and regenerates 0.5% of their max health each second.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Epic",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static SurvivalTrait AttentionDeficit = new()
        {
            Id = 46,
            CodeName = "trait.Upgrades.Attention_Defecit",
            Name = ATTENTION_DEFICIT,
            Description = "-40% to the duration of crowd control, slow, and stun debuffs.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static SurvivalTrait ExtraPadding = new()
        {
            Id = 47,
            CodeName = "trait.Upgrades.Extra_Padding",
            Name = EXTRA_PADDING,
            Description = "+12% damage protection after dealing damage to an enemy. Lasts 3s.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static SurvivalTrait RespectMyAuthority = new()
        {
            Id = 48,
            CodeName = "trait.Upgrades.Respect_My_Authority",
            Name = RESPECT_MY_AUTHORITY,
            Description = "+15% to the duration of crowd control abilities cast by the hero.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };

        public static Dictionary<string, SurvivalTrait> TriangleSlotTraits = new()
        {
            { EASILY_EXCITED, EasilyExcited},
            { MAKING_IT_RAIN, MakingItRain},
            { NATURAL_BORN_SPRINTER, NaturalBornSprinter},
            { KIDNAPPED_A_LEPRECHAUN, KidnappedALeprechaun},
            { OVER_REACTING, OverReacting},
            { AVOIDS_PAIN, AvoidsPain},
            { FIRE_SALE, FireSale},
            { ICE_COLD_DEALS, IceColdDeals},
            { INSANE_ARCANE_SALE, InsaneArcaneSale},
            { LIGHTNING_DEALS, LightningDeals},
            { BIG_SPENDER, BigSpender},
            { NEVER_PAYS_RETAIL, NeverPaysRetail},
            { ONE_WITH_THE_TRAPS, OneWithTheTraps},
            { OVERACHIEVER, Overachiever},
            { OVERPROTECTIVE, Overprotective},
            { RIFT_GIFT, RiftGift},
            { RIFT_ROCKET, RiftRocket},
            { SMASHING_DEALS, SmashingDeals},
            { HAS_A_TRAP_FETISH, HasATrapFetish}
        };

        public static Dictionary<string, SurvivalTrait> PentagonSlotTraits = new()
        {
            { BELIEVES_SIZE_MATTERS, BelievesSizeMatters},
            { UNCLE_KILLED_BY_GIANT, UncleKilledByGiant},
            { CAT_EATEN_BY_GNOLLS, CatEatenByGnolls},
            { BROTHER_MAULED_BY_GRIZZLIES, BrotherMauledByGrizzlies},
            { SISTER_EATEN_BY_AN_OGRE, SisterEatenByAnOgre},
            { DOG_KILLED_BY_PRIDE_HUNTERS, DogKilledByPrideHunters},
            { GRANDMOTHER_EATEN_BY_A_TROLL, GrandmotherEatenByATroll},
            { DIFFICULTY_CALMING_DOWN, DifficultyCalmingDown},
            { AMATEUR_VETERINARIAN, AmateurVeterinarian},
            { SOLDIERS_TOOK_MY_HORSE, SoldiersTookMyHorse},
            { HAS_ULTIMATE_SET_OF_TOOLS, HasUltimateSetOfTools},
            { BEAR_HUGS, BearHugs},
            { HAS_A_BIG_BROTHER, HasABigBrother},
            { KILLER_BUZZ, KillerBuzz},
            { PAGING_DR_LOVE, PagingDrLove},
            { RIFT_AWAY, RiftAway},
            { FEELING_FIERCE, FeelingFierce},
            { TRIES_TOO_HARD, TriesTooHard}
        };

        public static Dictionary<string, SurvivalTrait> DiamondSlotTraits = new()
        {

            { ENJOYS_PAIN, EnjoysPain},
            { EXECUTION_ADVANTAGE, ExecutionAdvantage},
            { FEELS_SAFE_AT_HOME, FeelsSafeAtHome},
            { PRACTICES_WITCHCRAFT, PracticesWitchcraft},
            { HIGH_PAIN_TOLERANCE, HighPainTolerance},
            { WALKS_IT_OFF, WalksItOff},
            { TAKES_LESSONS_FROM_CYGNUS, TakesLessonsFromCygnus},
            { WALL_BUILDING_PHD, WallBuildingPhD},
            { ATTENTION_DEFICIT, AttentionDeficit},
            { EXTRA_PADDING, ExtraPadding},
            { RESPECT_MY_AUTHORITY, RespectMyAuthority},
        };


        public static Dictionary<string, SurvivalTrait> Traits =
            TriangleSlotTraits
            .Concat(PentagonSlotTraits)
            .Concat(DiamondSlotTraits)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


        public static Dictionary<int, SurvivalTrait> TraitsById = new()
        {
            { EasilyExcited.Id, EasilyExcited},
            { MakingItRain.Id, MakingItRain},
            { NaturalBornSprinter.Id, NaturalBornSprinter},
            { KidnappedALeprechaun.Id, KidnappedALeprechaun},
            { OverReacting.Id, OverReacting},
            { AvoidsPain.Id, AvoidsPain},
            { FireSale.Id, FireSale},
            { IceColdDeals.Id, IceColdDeals},
            { InsaneArcaneSale.Id, InsaneArcaneSale},
            { LightningDeals.Id, LightningDeals},
            { BigSpender.Id, BigSpender},
            { NeverPaysRetail.Id, NeverPaysRetail},
            { OneWithTheTraps.Id, OneWithTheTraps},
            { Overachiever.Id, Overachiever},
            { Overprotective.Id, Overprotective},
            { RiftGift.Id, RiftGift},
            { RiftRocket.Id, RiftRocket},
            { SmashingDeals.Id, SmashingDeals},
            { HasATrapFetish.Id, HasATrapFetish},

            { BelievesSizeMatters.Id, BelievesSizeMatters},
            { UncleKilledByGiant.Id, UncleKilledByGiant},
            { CatEatenByGnolls.Id, CatEatenByGnolls},
            { BrotherMauledByGrizzlies.Id, BrotherMauledByGrizzlies},
            { SisterEatenByAnOgre.Id, SisterEatenByAnOgre},
            { DogKilledByPrideHunters.Id, DogKilledByPrideHunters},
            { GrandmotherEatenByATroll.Id, GrandmotherEatenByATroll},
            { DifficultyCalmingDown.Id, DifficultyCalmingDown},
            { AmateurVeterinarian.Id, AmateurVeterinarian},
            { SoldiersTookMyHorse.Id, SoldiersTookMyHorse},
            { HasUltimateSetOfTools.Id, HasUltimateSetOfTools},
            { BearHugs.Id, BearHugs},
            { HasABigBrother.Id, HasABigBrother},
            { KillerBuzz.Id, KillerBuzz},
            { PagingDrLove.Id, PagingDrLove},
            { RiftAway.Id, RiftAway},
            { FeelingFierce.Id, FeelingFierce},

            { TriesTooHard.Id, TriesTooHard},
            { EnjoysPain.Id, EnjoysPain},
            { ExecutionAdvantage.Id, ExecutionAdvantage},
            { FeelsSafeAtHome.Id, FeelsSafeAtHome},
            { PracticesWitchcraft.Id, PracticesWitchcraft},
            { HighPainTolerance.Id, HighPainTolerance},
            { WalksItOff.Id, WalksItOff},
            { TakesLessonsFromCygnus.Id, TakesLessonsFromCygnus},
            { WallBuildingPhD.Id, WallBuildingPhD},
            { AttentionDeficit.Id, AttentionDeficit},
            { ExtraPadding.Id, ExtraPadding},
            { RespectMyAuthority.Id, RespectMyAuthority},
        };

        public static SurvivalTrait GetById(int id)
        {
            if (TraitsById.TryGetValue(id, out var trait))
            {
                return trait;
            }
            return new SurvivalTrait { Id = 0, Name = "Unknown" };
        }
    }
}