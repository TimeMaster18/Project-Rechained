using System.Collections.Generic;
using static SingleplayerLauncher.Names.Trait;
using static SingleplayerLauncher.Names.Difficulty;

namespace SingleplayerLauncher.Model
{
    public class Trait
    {

        public const string PENTAGON_BONUS_SLOT = "Pentagon";
        public const string DIAMOND_BONUS_SLOT = "Diamond";
        public const string TRIANGLE_BONUS_SLOT = "Triangle";

        public string CodeName { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string MatchingSlot { get; private set; }
        public string UnlockedAt { get; private set; }
        public string Rarity { get; private set; }
        public Trait MatchingBonusTrait { get; private set; }
        public string MatchingBonusTraitDescription { get; private set; }

        // Bonus Traits
        public static Trait BONUS_TRAIT_ARMOR = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitArmor",
            Description = "+8 armor."
        };
        public static Trait BONUS_TRAIT_CC_RESIST = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCCResist",
            Description = "-10% control effect duration."
        };
        public static Trait BONUS_TRAIT_COIN_TRICKLE = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCoinTrickle",
            Description = "+1 coin per second."
        };
        public static Trait BONUS_TRAIT_COOLDOWN_REDUCTION = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCooldownReduction",
            Description = "+10.0% cooldown speed."
        };
        public static Trait BONUS_TRAIT_HEALTH = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitHealth",
            Description = "+4.0% max health."
        };
        public static Trait BONUS_TRAIT_HEALTH_REGEN = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitHealthRegen",
            Description = "Regenerates 1% max health per second."
        };
        public static Trait BONUS_TRAIT_MAGIC_ARMOR = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitMagicArmor",
            Description = "+8 magic armor."
        };
        public static Trait BONUS_TRAIT_MANA_MAX = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitManaMax",
            Description = "+8.0% max mana."
        };
        public static Trait BONUS_TRAIT_MANA_REGEN = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitManaRegen",
            Description = "+12.0% mana regeneration."
        };
        public static Trait BONUS_TRAIT_PRIMARY_DAMAGE = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitPrimaryDamage",
            Description = "+5.0% primary attack damage."
        };
        public static Trait BONUS_TRAIT_SPEED = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitSpeed",
            Description = "+2.5% movement speed."
        };

        // Traits
        // Triangle Traits
        public static Trait EasilyExcited = new Trait
        {
            CodeName = "SpitfireGame.RTraitEasilyExcited",
            Name = EASILY_EXCITED,
            Description = "Combos fill the Unchained meter by 20% more.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait MakingItRain = new Trait
        {
            CodeName = "SpitfireGame.RTraitMakingItRain",
            Name = MAKING_IT_RAIN,
            Description = "+30% to bonus coin granted by combos.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait NaturalBornSprinter = new Trait
        {
            CodeName = "SpitfireGame.RTraitNaturalBornSprinter",
            Name = NATURAL_BORN_SPRINTER,
            Description = "+50% movement speed while Unchained.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static Trait KidnappedALeprechaun = new Trait
        {
            CodeName = "SpitfireGame.RTraitStartingCoin3",
            Name = KIDNAPPED_A_LEPRECHAUN,
            Description = "+500 starting coin.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait OverReacting = new Trait
        {
            CodeName = "trait.Upgrades.Adult_Supervision",
            Name = OVER_REACTING,
            Description = "Regenerates +1 mana regeneration per second when below 50% health.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static Trait AvoidsPain = new Trait
        {
            CodeName = "trait.Upgrades.Afraid_Leave_Home",
            Name = AVOIDS_PAIN,
            Description = "Regenerates 0.5% max health per second when below 50% health.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait FireSale = new Trait
        {
            CodeName = "trait.Upgrades.Fire_Sale",
            Name = FIRE_SALE,
            Description = "-15% fire trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait IceColdDeals = new Trait
        {
            CodeName = "trait.Upgrades.Ice_Cold_Deals",
            Name = ICE_COLD_DEALS,
            Description = "-15% ice trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static Trait InsaneArcaneSale = new Trait
        {
            CodeName = "trait.Upgrades.Insane_Arcane_Sale",
            Name = INSANE_ARCANE_SALE,
            Description = "-15% arcane trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static Trait LightningDeals = new Trait
        {
            CodeName = "trait.Upgrades.Lightning_Deals",
            Name = LIGHTNING_DEALS,
            Description = "-15% lightning trap cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static Trait BigSpender = new Trait
        {
            CodeName = "trait.Upgrades.MoneyBags",
            Name = BIG_SPENDER,
            Description = "+250 coin at the beginning of each wave.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait NeverPaysRetail = new Trait
        {
            CodeName = "trait.Upgrades.Never_Pays_Retail",
            Name = NEVER_PAYS_RETAIL,
            Description = "-25% hero respawn buyback cost.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait OneWithTheTraps = new Trait
        {
            CodeName = "trait.Upgrades.One_With_Traps",
            Name = ONE_WITH_THE_TRAPS,
            Description = "+1 per second mana regeneration near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait Overachiever = new Trait
        {
            CodeName = "trait.Upgrades.Overachiever",
            Name = OVERACHIEVER,
            Description = "+1 battle level at the start of the matches.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static Trait Overprotective = new Trait
        {
            CodeName = "trait.Upgrades.Overprotective",
            Name = OVERPROTECTIVE,
            Description = "-25% damage taken by traps near the hero.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static Trait RiftGift = new Trait
        {
            CodeName = "trait.Upgrades.Rift_Gift",
            Name = RIFT_GIFT,
            Description = "+100% mana and health after destroying an unstable rift.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static Trait RiftRocket = new Trait
        {
            CodeName = "trait.Upgrades.Rift_Rocket",
            Name = RIFT_ROCKET,
            Description = "+50% movement speed for 5s after destroying an unstable rift.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static Trait SmashingDeals = new Trait
        {
            CodeName = "trait.Upgrades.Smashing_Deals",
            Name = SMASHING_DEALS,
            Description = "-15% trap cost to traps that deal physical damage.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static Trait HasATrapFetish = new Trait
        {
            CodeName = "trait.Upgrades.Trap_Fetish",
            Name = HAS_A_TRAP_FETISH,
            Description = "Regenerates +0.6% max health per second near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };

        // Pentagon Traits
        public static Trait BelievesSizeMatters = new Trait
        {
            CodeName = "SpitfireGame.RTraitBelieveSizeMatters",
            Name = BELIEVES_SIZE_MATTERS,
            Description = "+15% primary attack damage to large minions when unchained (+25% if team is unchained).",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait UncleKilledByGiant = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToGiants3",
            Name = UNCLE_KILLED_BY_GIANT,
            Description = "+12% damage to giants.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static Trait CatEatenByGnolls = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToGnolls3",
            Name = CAT_EATEN_BY_GNOLLS,
            Description = "+12% damage to gnoll hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait BrotherMauledByGrizzlies = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToGrizzlies3",
            Name = BROTHER_MAULED_BY_GRIZZLIES,
            Description = "+12% damage to grizzly minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static Trait SisterEatenByAnOgre = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToOgres3",
            Name = SISTER_EATEN_BY_AN_OGRE,
            Description = "+12% damage to ogre minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait DogKilledByPrideHunters = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToPrideHunters3",
            Name = DOG_KILLED_BY_PRIDE_HUNTERS,
            Description = "+12% damage to pride hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait GrandmotherEatenByATroll = new Trait
        {
            CodeName = "SpitfireGame.RTraitDamageToTrolls3",
            Name = GRANDMOTHER_EATEN_BY_A_TROLL,
            Description = "+12% damage to troll minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait DifficultyCalmingDown = new Trait
        {
            CodeName = "SpitfireGame.RTraitDifficultyCalmingDown",
            Name = DIFFICULTY_CALMING_DOWN,
            Description = "+15% Unchained duration.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static Trait AmateurVeterinarian = new Trait
        {
            CodeName = "SpitfireGame.RTraitImprovedHealing3",
            Name = AMATEUR_VETERINARIAN,
            Description = "+25% healing abilities cast on the hero.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static Trait SoldiersTookMyHorse = new Trait
        {
            CodeName = "SpitfireGame.RTraitSoldiersTookMyHorse",
            Name = SOLDIERS_TOOK_MY_HORSE,
            Description = "+12% damage to soldiers.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait HasUltimateSetOfTools = new Trait
        {
            CodeName = "SpitfireGame.RTraitTrapDamageIncrease3",
            Name = HAS_ULTIMATE_SET_OF_TOOLS,
            Description = "+6% trap damage.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait BearHugs = new Trait
        {
            CodeName = "trait.Upgrades.Bear_Hugs",
            Name = BEAR_HUGS,
            Description = "+8% damage to minions near the hero",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static Trait HasABigBrother = new Trait
        {
            CodeName = "trait.Upgrades.Big_Brother",
            Name = HAS_A_BIG_BROTHER,
            Description = "+10% damage dealt to minions near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static Trait KillerBuzz = new Trait
        {
            CodeName = "trait.Upgrades.Killer_Buzz",
            Name = KILLER_BUZZ,
            Description = "+8% damage after kills. Lasts 3s.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait PagingDrLove = new Trait
        {
            CodeName = "trait.Upgrades.Paging_Dr_Love",
            Name = PAGING_DR_LOVE,
            Description = "+25% to hero's healing abilities.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static Trait RiftAway = new Trait
        {
            CodeName = "trait.Upgrades.Rift_Away",
            Name = RIFT_AWAY,
            Description = "+25% damage to unstable rifts.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static Trait FeelingFierce = new Trait
        {
            CodeName = "trait.Upgrades.Strange_Humor",
            Name = FEELING_FIERCE,
            Description = "+10% damage when health is above 50%.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static Trait TriesTooHard = new Trait
        {
            CodeName = "trait.Upgrades.Tries_Too_Hard",
            Name = TRIES_TOO_HARD,
            Description = "+10% damage dealt to mercenaries near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };

        // Diamond Traits
        public static Trait EnjoysPain = new Trait
        {
            CodeName = "SpitfireGame.RTraitEnjoysPain",
            Name = ENJOYS_PAIN,
            Description = "Adds +4% lifesteal to physical primary attacks.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static Trait ExecutionAdvantage = new Trait
        {
            CodeName = "SpitfireGame.RTraitExecutionAdvantage",
            Name = EXECUTION_ADVANTAGE,
            Description = "Grants a shield worth 30% of the hero's max health for 5s upon killing a boss, mercenary, or hunter.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static Trait FeelsSafeAtHome = new Trait
        {
            CodeName = "SpitfireGame.RTraitFeelsSafeAtHome",
            Name = FEELS_SAFE_AT_HOME,
            Description = "+6 physical and magical armor when near allied guardians.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static Trait PracticesWitchcraft = new Trait
        {
            CodeName = "SpitfireGame.RTraitPracticesWitchcraft",
            Name = PRACTICES_WITCHCRAFT,
            Description = "+5% lifesteal to primary attack when dealing magical damage.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = WAR_MAGE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static Trait HighPainTolerance = new Trait
        {
            CodeName = "SpitfireGame.RTraitReduceDamageFromMinions3",
            Name = HIGH_PAIN_TOLERANCE,
            Description = "+12% damage reduction against minions.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static Trait WalksItOff = new Trait
        {
            CodeName = "SpitfireGame.RTraitRespawnTime3",
            Name = WALKS_IT_OFF,
            Description = "-12% respawn time.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = RIFT_LORD,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static Trait TakesLessonsFromCygnus = new Trait
        {
            CodeName = "SpitfireGame.RTraitTakesLessonsFromCygnus",
            Name = TAKES_LESSONS_FROM_CYGNUS,
            Description = "+1% max health for every 50 mana the hero has.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Uncommon",
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static Trait WallBuildingPhD = new Trait
        {
            CodeName = "SpitfireGame.RTraitWallBuildingPhD",
            Name = WALL_BUILDING_PHD,
            Description = "Increases barricades' health by 20% and regenerates 0.5% of their max health each second.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Epic",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static Trait AttentionDeficit = new Trait
        {
            CodeName = "trait.Upgrades.Attention_Defecit",
            Name = ATTENTION_DEFICIT,
            Description = "-40% to the duration of crowd control, slow, and stun debuffs.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = APPRENTICE,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static Trait ExtraPadding = new Trait
        {
            CodeName = "trait.Upgrades.Extra_Padding",
            Name = EXTRA_PADDING,
            Description = "+12% damage protection after dealing damage to an enemy. Lasts 3s.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static Trait RespectMyAuthority = new Trait
        {
            CodeName = "trait.Upgrades.Respect_My_Authority",
            Name = RESPECT_MY_AUTHORITY,
            Description = "+15% to the duration of crowd control abilities cast by the hero.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            UnlockedAt = MASTER,
            Rarity = "Rare",
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };


        public static Dictionary<string, Trait> Traits = new Dictionary<string, Trait>
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
            { HAS_A_TRAP_FETISH, HasATrapFetish},
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
            { TRIES_TOO_HARD, TriesTooHard},
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
    }
}