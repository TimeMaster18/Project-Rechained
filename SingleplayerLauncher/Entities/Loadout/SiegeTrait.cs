using System.Collections.Generic;
using System.Linq;
using static SingleplayerLauncher.Names.Trait;

namespace SingleplayerLauncher.Model
{
    public class SiegeTrait : Trait
    {

        // Triangle Traits
        public static SiegeTrait CacheWhisperer = new SiegeTrait
        {
            Id = 1,
            CodeName = "SpitfireGame.RTraitCacheWhisperer",
            Name = CACHE_WHISPERER,
            Description = "+15 bonus coin for killing caches.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SiegeTrait NeedsAloneTime = new SiegeTrait
        {
            Id = 2,
            CodeName = "SpitfireGame.RTraitHealNearGuardians3",
            Name = NEEDS_ALONE_TIME,
            Description = "+0.5%/s max health when away from enemy heroes.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SiegeTrait MakingItRain = new SiegeTrait
        {
            Id = 3,
            CodeName = "SpitfireGame.RTraitMakingItRain",
            Name = MAKING_IT_RAIN,
            Description = "+15% more coin from combos.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SiegeTrait OneWithTheTraps = new SiegeTrait
        {
            Id = 4,
            CodeName = "SpitfireGame.RTraitManaNearTraps3",
            Name = ONE_WITH_THE_TRAPS,
            Description = "+1.0/s mana regeneration near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SiegeTrait KidnappedALeprechaun = new SiegeTrait
        {
            Id = 5,
            CodeName = "SpitfireGame.RTraitStartingCoin3",
            Name = KIDNAPPED_A_LEPRECHAUN,
            Description = "+500 starting coin.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COIN_TRICKLE
        };
        public static SiegeTrait LargeAndInCharge = new SiegeTrait
        {
            Id = 6,
            CodeName = "SpitfireGame.RTraitLargeAndInCharge",
            Name = LARGE_AND_IN_CHARGE,
            Description = "Grants +15% control effect resistance to nearby large minions.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SiegeTrait RansackingObsession = new SiegeTrait
        {
            Id = 7,
            CodeName = "SpitfireGame.RTraitRansackingObsession",
            Name = RANSACKING_OBSESSION,
            Description = "+5% minion portal XP gained from caches.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SiegeTrait BornLeader = new SiegeTrait
        {
            Id = 8,
            CodeName = "SpitfireGame.RTraitStartingLeadership3",
            Name = BORN_LEADER,
            Description = "+1.0/s minion portal XP.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SiegeTrait OhWowBandages = new SiegeTrait
        {
            Id = 9,
            CodeName = "SpitfireGame.RTraitThereWereBandaids",
            Name = OH_WOW_BANDAGES,
            Description = "Recovers +3.5% total health after destroying a cache.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SiegeTrait SellsMagicToMages = new SiegeTrait
        {
            Id = 10,
            CodeName = "SpitfireGame.RTraitTrapSellCost3",
            Name = SELLS_MAGIC_TO_MAGES,
            Description = "+20% trap sell value.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN
        };
        public static SiegeTrait WorksSmarter = new SiegeTrait
        {
            Id = 11,
            CodeName = "SpitfireGame.RTraitEscortAuraNoEnemyPlayers3",
            Name = WORKS_SMARTER,
            Description = "+12% trap armor while leading minions when no enemy heroes present.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static SiegeTrait MotivatesOthers = new SiegeTrait
        {
            Id = 12,
            CodeName = "SpitfireGame.RTraitMotivatesOthers",
            Name = MOTIVATES_OTHERS,
            Description = "+6% minion portal XP when escorting minions.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static SiegeTrait OhWowPotions = new SiegeTrait
        {
            Id = 13,
            CodeName = "SpitfireGame.RTraitThereWerePotions",
            Name = OH_WOW_POTIONS,
            Description = "Recovers +3.5% total mana after destroying a cache.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_REGEN
        };
        public static SiegeTrait LikeYouStoleIt = new SiegeTrait
        {
            Id = 14,
            CodeName = "SpitfireGame.RTraitLikeYouStoleIt",
            Name = LIKE_YOU_STOLE_IT,
            Description = "Grants +10% movement speed for 5s after destroying a cache.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SiegeTrait DoesntPlayWellWithOthers = new SiegeTrait
        {
            Id = 15,
            CodeName = "SpitfireGame.RTraitManaNearGuardians3",
            Name = DOESNT_PLAY_WELL_WITH_OTHERS,
            Description = "+1.0/s mana regeneration when away from enemy heroes.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SiegeTrait MobMentality = new SiegeTrait
        {
            Id = 16,
            CodeName = "SpitfireGame.RTraitMobMentality",
            Name = MOB_MENTALITY,
            Description = "When more than 12 friendly minions are nearby, their speed is increased by 5%.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SiegeTrait SettingAnExample = new SiegeTrait
        {
            Id = 17,
            CodeName = "SpitfireGame.RTraitSettingAnExample",
            Name = SETTING_AN_EXAMPLE,
            Description = "Grants a 25% speed boost to nearby allied minions on player kill",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_SPEED
        };
        public static SiegeTrait HasATrapFetish = new SiegeTrait
        {
            Id = 18,
            CodeName = "trait.Upgrades.Trap_Fetish", // TODO: Check if it is the real one
            Name = HAS_A_TRAP_FETISH,
            Description = "Regenerates +0.6% max health per second near allied traps.",
            MatchingSlot = TRIANGLE_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH_REGEN // TODO: Check if it is the real one
        };

        // Pentagon Traits
        public static SiegeTrait UncleKilledByGiant = new SiegeTrait
        {
            Id = 19,
            CodeName = "SpitfireGame.RTraitDamageToGiants3",
            Name = UNCLE_KILLED_BY_GIANT,
            Description = "+12% damage to giants.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SiegeTrait BrotherMauledByGrizzlies = new SiegeTrait
        {
            Id = 20,
            CodeName = "SpitfireGame.RTraitDamageToGrizzlies3",
            Name = BROTHER_MAULED_BY_GRIZZLIES,
            Description = "+12% damage to grizzly minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SiegeTrait StrangeSenseOfHumor = new SiegeTrait
        {
            Id = 21,
            CodeName = "SpitfireGame.RTraitDmgBonusNoEnemyPlayers3",
            Name = STRANGE_SENSE_OF_HUMOR,
            Description = "+10% damage to minions when no enemy heroes nearby.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SiegeTrait NeverKnocks = new SiegeTrait
        {
            Id = 22,
            CodeName = "SpitfireGame.RTraitNeverKnocks",
            Name = NEVER_KNOCKS,
            Description = "+15% damage to gates and barriers.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_COOLDOWN_REDUCTION
        };
        public static SiegeTrait HasABigBrother = new SiegeTrait
        {
            Id = 23,
            CodeName = "SpitfireGame.RTraitDmgBonusNearGuardians1_3",
            Name = HAS_A_BIG_BROTHER,
            Description = "+10% damage against minions near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SiegeTrait TriesTooHard = new SiegeTrait
        {
            Id = 24,
            CodeName = "SpitfireGame.RTraitDmgBonusNearGuardians2_3",
            Name = TRIES_TOO_HARD,
            Description = "+10% damage against heroes near allied guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SiegeTrait AmateurVeterinarian = new SiegeTrait
        {
            Id = 25,
            CodeName = "SpitfireGame.RTraitImprovedHealing3",
            Name = AMATEUR_VETERINARIAN,
            Description = "+10% healing applied to the hero.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SiegeTrait RipThatSuckerOpen = new SiegeTrait
        {
            Id = 26,
            CodeName = "SpitfireGame.RTraitRipThatSuckerOpen",
            Name = RIP_THAT_SUCKER_OPEN,
            Description = "+12% damage to caches.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MANA_MAX
        };
        public static SiegeTrait CatEatenByAGnoll = new SiegeTrait
        {
            Id = 27,
            CodeName = "SpitfireGame.RTraitDamageToGnolls3",
            Name = CAT_EATEN_BY_GNOLLS,
            Description = "+12% damage to gnoll hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait SisterEatenByAnOgre = new SiegeTrait
        {
            Id = 28,
            CodeName = "SpitfireGame.RTraitDamageToOgres3",
            Name = SISTER_EATEN_BY_AN_OGRE,
            Description = "+12% damage to ogre minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait DogKilledByPrideHunters = new SiegeTrait
        {
            Id = 29,
            CodeName = "SpitfireGame.RTraitDamageToPrideHunters3",
            Name = DOG_KILLED_BY_PRIDE_HUNTERS,
            Description = "+12% damage to pride hunter minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait GrandmotherEatenByATroll = new SiegeTrait
        {
            Id = 30,
            CodeName = "SpitfireGame.RTraitDamageToTrolls3",
            Name = GRANDMOTHER_EATEN_BY_A_TROLL,
            Description = "+12% damage to troll minions.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait ItsMine = new SiegeTrait
        {
            Id = 31,
            CodeName = "SpitfireGame.RTraitItsMine",
            Name = ITS_MINE,
            Description = "+10% damage for 10s after destroying a cache.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait NotScaredOfStatues = new SiegeTrait
        {
            Id = 32,
            CodeName = "SpitfireGame.RTraitNotScaredOfStatues",
            Name = NOT_SCARED_OF_STATUES,
            Description = "+6% damage to guardians.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait SoldiersTookMyHorse = new SiegeTrait
        {
            Id = 33,
            CodeName = "SpitfireGame.RTraitSoldiersTookMyHorse",
            Name = SOLDIERS_TOOK_MY_HORSE,
            Description = "+12% damage to soldiers.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };
        public static SiegeTrait HasUltimateSetOfTools = new SiegeTrait
        {
            Id = 34,
            CodeName = "SpitfireGame.RTraitTrapDamageIncrease3",
            Name = HAS_ULTIMATE_SET_OF_TOOLS,
            Description = "+6% trap damage.",
            MatchingSlot = PENTAGON_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_PRIMARY_DAMAGE
        };

        // Diamond Traits
        public static SiegeTrait EnjoysPain = new SiegeTrait
        {
            Id = 35,
            CodeName = "SpitfireGame.RTraitEnjoysPain",
            Name = ENJOYS_PAIN,
            Description = "Adds +5% lifesteal to physical primary attacks.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static SiegeTrait HighPainTolerance = new SiegeTrait
        {
            Id = 36,
            CodeName = "SpitfireGame.RTraitReduceDamageFromMinions3",
            Name = HIGH_PAIN_TOLERANCE,
            Description = "+12% damage reduction against enemy minions.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_ARMOR
        };
        public static SiegeTrait ExecutionAdvantage = new SiegeTrait
        {
            Id = 37,
            CodeName = "SpitfireGame.RTraitExecutionAdvantage",
            Name = EXECUTION_ADVANTAGE,
            Description = "Grants a shield worth 10% of the hero's HPs for 3s upon a kill or assist.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SiegeTrait ImNotTouchingYou = new SiegeTrait
        {
            Id = 38,
            CodeName = "SpitfireGame.RTraitHandsOff",
            Name = IM_NOT_TOUCHING_YOU,
            Description = "-10% damage from guardians.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SiegeTrait WalksItOff = new SiegeTrait
        {
            Id = 39,
            CodeName = "SpitfireGame.RTraitRespawnTime3",
            Name = WALKS_IT_OFF,
            Description = "-12% respawn time.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SiegeTrait TakesLessonsFromCygnus = new SiegeTrait
        {
            Id = 40,
            CodeName = "SpitfireGame.RTraitTakesLessonsFromCygnus",
            Name = TAKES_LESSONS_FROM_CYGNUS,
            Description = "+1% max health for every 50 mana the hero has.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_CC_RESIST
        };
        public static SiegeTrait FeelsSafeAtHome = new SiegeTrait
        {
            Id = 41,
            CodeName = "SpitfireGame.RTraitFeelsSafeAtHome",
            Name = FEELS_SAFE_AT_HOME,
            Description = "+6 physical and magical armor when near allied guardians.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static SiegeTrait GuardianVandalism = new SiegeTrait
        {
            Id = 42,
            CodeName = "SpitfireGame.RTraitGuardianVandalism",
            Name = GUARDIAN_VANDALISM,
            Description = "+10% damage reduction for 3s upon dealing damage to an enemy guardian.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH
        };
        public static SiegeTrait PracticesWitchcraft = new SiegeTrait
        {
            Id = 43,
            CodeName = "SpitfireGame.RTraitPracticesWitchcraft",
            Name = PRACTICES_WITCHCRAFT,
            Description = "+5% lifesteal to primary attack when dealing magical damage.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static SiegeTrait IsAWalkingPincushion = new SiegeTrait
        {
            Id = 44,
            CodeName = "SpitfireGame.RTraitReduceDamageFromTraps3",
            Name = IS_A_WALKING_PINCUSHION,
            Description = "+20% damage reduction against enemy traps.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_MAGIC_ARMOR
        };
        public static SiegeTrait ShowOff = new SiegeTrait
        {
            Id = 45,
            CodeName = "trait.Upgrades.Show_Off",
            Name = SHOW_OFF,
            Description = "+6 to all armor when escorting minions.",
            MatchingSlot = DIAMOND_BONUS_SLOT,
            MatchingBonusTrait = BONUS_TRAIT_HEALTH // TODO: Check the real bonus
        };

        public static Dictionary<string, SiegeTrait> TriangleSlotTraits = new Dictionary<string, SiegeTrait> {
            { CACHE_WHISPERER, CacheWhisperer},
            { NEEDS_ALONE_TIME, NeedsAloneTime},
            { MAKING_IT_RAIN, MakingItRain},
            { ONE_WITH_THE_TRAPS, OneWithTheTraps},
            { KIDNAPPED_A_LEPRECHAUN, KidnappedALeprechaun},
            { LARGE_AND_IN_CHARGE, LargeAndInCharge},
            { RANSACKING_OBSESSION, RansackingObsession},
            { BORN_LEADER, BornLeader},
            { OH_WOW_BANDAGES, OhWowBandages},
            { SELLS_MAGIC_TO_MAGES, SellsMagicToMages},
            { WORKS_SMARTER, WorksSmarter},
            { MOTIVATES_OTHERS, MotivatesOthers},
            { OH_WOW_POTIONS, OhWowPotions},
            { LIKE_YOU_STOLE_IT, LikeYouStoleIt},
            { DOESNT_PLAY_WELL_WITH_OTHERS, DoesntPlayWellWithOthers},
            { MOB_MENTALITY, MobMentality},
            { SETTING_AN_EXAMPLE, SettingAnExample},
            { HAS_A_TRAP_FETISH, HasATrapFetish }
        };

        public static Dictionary<string, SiegeTrait> PentagonSlotTraits = new Dictionary<string, SiegeTrait>
        {
            { UNCLE_KILLED_BY_GIANT, UncleKilledByGiant},
            { BROTHER_MAULED_BY_GRIZZLIES, BrotherMauledByGrizzlies},
            { STRANGE_SENSE_OF_HUMOR, StrangeSenseOfHumor},
            { NEVER_KNOCKS, NeverKnocks},
            { HAS_A_BIG_BROTHER, HasABigBrother},
            { TRIES_TOO_HARD, TriesTooHard},
            { AMATEUR_VETERINARIAN, AmateurVeterinarian},
            { RIP_THAT_SUCKER_OPEN, RipThatSuckerOpen},
            { CAT_EATEN_BY_GNOLLS, CatEatenByAGnoll},
            { SISTER_EATEN_BY_AN_OGRE, SisterEatenByAnOgre},
            { DOG_KILLED_BY_PRIDE_HUNTERS, DogKilledByPrideHunters},
            { GRANDMOTHER_EATEN_BY_A_TROLL, GrandmotherEatenByATroll},
            { ITS_MINE, ItsMine},
            { NOT_SCARED_OF_STATUES, NotScaredOfStatues},
            { SOLDIERS_TOOK_MY_HORSE, SoldiersTookMyHorse},
            { HAS_ULTIMATE_SET_OF_TOOLS, HasUltimateSetOfTools}
        };

        public static Dictionary<string, SiegeTrait> DiamondSlotTraits = new Dictionary<string, SiegeTrait>
        {
            { ENJOYS_PAIN, EnjoysPain},
            { HIGH_PAIN_TOLERANCE, HighPainTolerance},
            { EXECUTION_ADVANTAGE, ExecutionAdvantage},
            { IM_NOT_TOUCHING_YOU, ImNotTouchingYou},
            { WALKS_IT_OFF, WalksItOff},
            { TAKES_LESSONS_FROM_CYGNUS, TakesLessonsFromCygnus},
            { FEELS_SAFE_AT_HOME, FeelsSafeAtHome},
            { GUARDIAN_VANDALISM, GuardianVandalism},
            { PRACTICES_WITCHCRAFT, PracticesWitchcraft},
            { IS_A_WALKING_PINCUSHION, IsAWalkingPincushion},
            { SHOW_OFF, ShowOff}
        };

        public static Dictionary<string, SiegeTrait> Traits =
            TriangleSlotTraits
            .Concat(PentagonSlotTraits)
            .Concat(DiamondSlotTraits)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        public static Dictionary<int, SiegeTrait> TraitsById = new Dictionary<int, SiegeTrait>
        {
            { CacheWhisperer.Id, CacheWhisperer},
            { NeedsAloneTime.Id, NeedsAloneTime},
            { MakingItRain.Id, MakingItRain},
            { OneWithTheTraps.Id, OneWithTheTraps},
            { KidnappedALeprechaun.Id, KidnappedALeprechaun},
            { LargeAndInCharge.Id, LargeAndInCharge},
            { RansackingObsession.Id, RansackingObsession},
            { BornLeader.Id, BornLeader},
            { OhWowBandages.Id, OhWowBandages},
            { SellsMagicToMages.Id, SellsMagicToMages},
            { WorksSmarter.Id, WorksSmarter},
            { MotivatesOthers.Id, MotivatesOthers},
            { OhWowPotions.Id, OhWowPotions},
            { LikeYouStoleIt.Id, LikeYouStoleIt},
            { DoesntPlayWellWithOthers.Id, DoesntPlayWellWithOthers},
            { MobMentality.Id, MobMentality},
            { SettingAnExample.Id, SettingAnExample},

            { UncleKilledByGiant.Id, UncleKilledByGiant},
            { BrotherMauledByGrizzlies.Id, BrotherMauledByGrizzlies},
            { StrangeSenseOfHumor.Id, StrangeSenseOfHumor},
            { NeverKnocks.Id, NeverKnocks},
            { HasABigBrother.Id, HasABigBrother},
            { TriesTooHard.Id, TriesTooHard},
            { AmateurVeterinarian.Id, AmateurVeterinarian},
            { RipThatSuckerOpen.Id, RipThatSuckerOpen},
            { CatEatenByAGnoll.Id, CatEatenByAGnoll},
            { SisterEatenByAnOgre.Id, SisterEatenByAnOgre},
            { DogKilledByPrideHunters.Id, DogKilledByPrideHunters},
            { GrandmotherEatenByATroll.Id, GrandmotherEatenByATroll},
            { ItsMine.Id, ItsMine},
            { NotScaredOfStatues.Id, NotScaredOfStatues},
            { SoldiersTookMyHorse.Id, SoldiersTookMyHorse},
            { HasUltimateSetOfTools.Id, HasUltimateSetOfTools},

            { EnjoysPain.Id, EnjoysPain},
            { HighPainTolerance.Id, HighPainTolerance},
            { ExecutionAdvantage.Id, ExecutionAdvantage},
            { ImNotTouchingYou.Id, ImNotTouchingYou},
            { WalksItOff.Id, WalksItOff},
            { TakesLessonsFromCygnus.Id, TakesLessonsFromCygnus},
            { FeelsSafeAtHome.Id, FeelsSafeAtHome},
            { GuardianVandalism.Id, GuardianVandalism},
            { PracticesWitchcraft.Id, PracticesWitchcraft},
            { IsAWalkingPincushion.Id, IsAWalkingPincushion},
            { ShowOff.Id, ShowOff},
        };

        public static SiegeTrait GetById(int id)
        {
            if (TraitsById.TryGetValue(id, out var trait))
            {
                return trait;
            }
            return new SiegeTrait { Id = 0, Name = "Unknown" };
        }
    }
}
