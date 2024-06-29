using System.Collections.Generic;
using static SingleplayerLauncher.Names.TrapPart;
using static SingleplayerLauncher.Names.TrapPartSlot;

namespace SingleplayerLauncher.Model
{
    public class TrapPart
    {
        public string Name { get; private set; }
        public string ItemTinkerEffect { get; private set; }
        public string Description { get; private set; }
        public string PartSlot { get; private set; }
        public string FlavourText { get; private set; }

        public static TrapPart DoubleTankAccumulator = new TrapPart
        {
            Name = DOUBLE_TANK_ACCUMULATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectDoubleTankAccumulator",
            Description = "Increases the Trap's knock-back by 25%.",
            PartSlot = ACCUMULATOR,
            FlavourText = "This part really knocks them out of the park."
        };
        public static TrapPart StunningAccumulator = new TrapPart
        {
            Name = STUNNING_ACCUMULATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectStunningAccumulator",
            Description = "Causes knocked-back Enemies (Large enemies aren't affected) to take 100% more damage for 5s.",
            PartSlot = ACCUMULATOR,
            FlavourText = "Stunningly, minions hate this part."
        };
        public static TrapPart CapacitanceAttuner = new TrapPart
        {
            Name = CAPACITANCE_ATTUNER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectCapacitanceAttuner",
            Description = "Amplifies the buffs cast by this Trap by 100% when first placed. Amplification weakens to 0% over 90s.",
            PartSlot = ATTUNER,
            FlavourText = "Now with easy, plug-and-play installation."
        };
        public static TrapPart DeepCellAttuner = new TrapPart
        {
            Name = DEEP_CELL_ATTUNER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectDeepCellAttuner",
            Description = "Amplifies the buffs cast by this Trap by 25%.",
            PartSlot = ATTUNER,
            FlavourText = "Keeps heroes in the buff."
        };
        public static TrapPart ReflectiveArmor = new TrapPart
        {
            Name = REFLECTIVE_ARMOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectReflectiveArmor",
            Description = "Reflects 200% of damage dealt to the Trap in a radius.",
            PartSlot = CLADDING,
            FlavourText = "\"Hey, I know THAT trick!\" - Maximilian, the War Mage"
        };
        public static TrapPart ReusableShielding = new TrapPart
        {
            Name = REUSABLE_SHIELDING,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectReusableShielding",
            Description = "Returns 25% of its base cost to its owner when the Trap is destroyed. It has a cooldown of 300 seconds (5 minutes) when used in Summoner Trap",
            PartSlot = CLADDING,
            FlavourText = "\"One dwarf's trash is another dwarf's treasure!\" - Dobbin, Claim Jumper"
        };
        public static TrapPart RevengeRune = new TrapPart
        {
            Name = REVENGE_RUNE,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectRevengeRune",
            Description = "When this Trap is killed, the attacker takes 75% of their max health in damage. It has a cooldown of 300 seconds (5 minutes) when used in Summoner Trap",
            PartSlot = CLADDING,
            FlavourText = "\"This rune understands me.\" - Smolder, the Fireborn"
        };
        public static TrapPart BraidedCoil = new TrapPart
        {
            Name = BRAIDED_COIL,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectBraidedCoil",
            Description = "Improves the Trap's refire rate, making it 20% faster.",
            PartSlot = COIL,
            FlavourText = "For (almost) instant gibletization."
        };
        public static TrapPart DiscountCoil = new TrapPart
        {
            Name = DISCOUNT_COIL,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectDiscountCoil",
            Description = "Reduces the Trap's build cost by 25% but increases its cooldown by 10%.",
            PartSlot = COIL,
            FlavourText = "\"Oo! I LOVE a good sale!\" - Gabriella, the Redeemed Sorceress"
        };
        public static TrapPart SelfImprovingCoil = new TrapPart
        {
            Name = SELF_IMPROVING_COIL,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectSelfImprovingCoil",
            Description = "Reduces the Trap's cooldown by 3% per wave (max 30%).",
            PartSlot = COIL,
            FlavourText = "\"Sadly, I know a few people who could use some 'self-improvement,' coils.\" - Gabriella, the Redeemed Sorceress"
        };
        public static TrapPart QuickTrapComponents = new TrapPart
        {
            Name = QUICK_TRAP_COMPONENTS,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectQuikTrapComponents",
            Description = "Needs to be tested",
            PartSlot = COMPONENTS,
            FlavourText = ""
        };
        public static TrapPart RentalParts = new TrapPart
        {
            Name = RENTAL_PARTS,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectRentalParts",
            Description = "Reduces Trap build cost by 50% but Trap cannot be sold. Trap is \"returned\" after two waves, selling itself back to owner at 50% its value.",
            PartSlot = COMPONENTS,
            FlavourText = "\"Professor Stipends are so LOW these days. I had to do SOMEthing.\" - Gabriella, the Redeemed Sorceress"
        };
        public static TrapPart StampedParts = new TrapPart
        {
            Name = STAMPED_PARTS,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectStampedParts",
            Description = "Reduces build cost by 20%.",
            PartSlot = COMPONENTS,
            FlavourText = "No, you can't use them in lieu of postage."
        };
        public static TrapPart SubsidizedParts = new TrapPart
        {
            Name = SUBSIDIZED_PARTS,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectSubsidizedParts",
            Description = "Reduces the build cost of the Trap by 10% and grants +500 coin at the start of a match.",
            PartSlot = COMPONENTS,
            FlavourText = "\"Subsidized? Don't go thinkin' I need any handouts, now!\" - Dobbin, Claim Jumper"
        };
        public static TrapPart VanityPlating = new TrapPart
        {
            Name = VANITY_PLATING,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectVanityPlating",
            Description = "Increases the Trap's build cost by 10%, but generates XP for the Traps' owner per second.",
            PartSlot = COMPONENTS,
            FlavourText = "\"My vanity plates say '2DMAXX!' Yeah!\" - Maximilian, the War Mage"
        };
        public static TrapPart BountyGenerator = new TrapPart
        {
            Name = BOUNTY_GENERATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectBountyGenerator",
            Description = "Increases the coin reward of Enemies affected by the trap by 2% (stacks to max 20%).",
            PartSlot = FIELD,
            FlavourText = "\"All those bounties. All for me... ow.\" - Midnight, Twilight's Razor"
        };
        public static TrapPart HealthSiphon = new TrapPart
        {
            Name = HEALTH_SIPHON,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectHealthSiphon",
            Description = "Restores +0.25% of owner's max health each time an enemy crosses the trap.",
            PartSlot = FIELD,
            FlavourText = "\"I will add their lifeforce to my own. And they will like it.\" - Oziel, the Soul Thief"
        };
        public static TrapPart ManaSiphon = new TrapPart
        {
            Name = MANA_SIPHON,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectManaSiphon",
            Description = "Restores 0.25% of owner's max mana each time an enemy crosses the Trap.",
            PartSlot = FIELD,
            FlavourText = "\"At my age, I need all the mana I can get!\" - Cygnus, Master of the Order"
        };
        public static TrapPart XPSiphon = new TrapPart
        {
            Name = XP_SIPHON,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectXPSiphon",
            Description = "Grants +3XP to the Trap's owner each time an enemy crosses the Trap.",
            PartSlot = FIELD,
            FlavourText = "\"Oh. My. Goodness. Where was this when I was taking that alchemy test?\" Zoey, the Chaotic Apprentice"
        };
        public static TrapPart DoubleStruts = new TrapPart
        {
            Name = DOUBLE_STRUTS,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectDoubleStruts",
            Description = "Reduces damage taken by the Trap by 40%.",
            PartSlot = FRAME,
            FlavourText = "\"She's a sturdy one, ain't she?\" - Dobbin, Claim Jumper"
        };
        public static TrapPart HeroRunedFrame = new TrapPart
        {
            Name = HERO_RUNED_FRAME,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectHeroRunedFrame",
            Description = "Reduces damage taken by Heroes near the Trap by 10%.",
            PartSlot = FRAME,
            FlavourText = "\"Aw, you mean I can't put my picture in it?\" - Maximilian, the War Mage"
        };
        public static TrapPart ControlledResonator = new TrapPart
        {
            Name = CONTROLLED_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectControlledResonator",
            Description = "Increases the Trap's damage to stunned, slowed or rooted Enemies by 30%.",
            PartSlot = RESONATOR,
            FlavourText = "For when you really want to kick them when they're down."
        };
        public static TrapPart FireResonator = new TrapPart
        {
            Name = FIRE_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectFireResonator",
            Description = "Increases the Trap's damage to burning Enemies by 30%.",
            PartSlot = RESONATOR,
            FlavourText = "\"I just want the world to burn.\" - Smolder, the Fireborn"
        };
        public static TrapPart IceResonator = new TrapPart
        {
            Name = ICE_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectIceResonator",
            Description = "Increases the Trap's damage to frozen Enemies by 90%.",
            PartSlot = RESONATOR,
            FlavourText = "\"STAY FROZEN LONGER? NEED THAT!\" - Hogarth, the Frozen Shield of Deg Itan"
        };
        public static TrapPart KineticResonator = new TrapPart
        {
            Name = KINETIC_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectKineticResonator",
            Description = "Slows Minions damaged by the trap by 10% for 2s.",
            PartSlot = RESONATOR,
            FlavourText = "\"Egad! They're slow enough even I can catch them!\" - Cygnus, Master of the Order"
        };
        public static TrapPart UnchainedResonator = new TrapPart
        {
            Name = UNCHAINED_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectUnchainedResonator",
            Description = "Causes Enemies killed by the Trap to increase its owner's Unchained Meter by a small amount.",
            PartSlot = RESONATOR,
            FlavourText = "Unchain your unchained."
        };
        public static TrapPart WeaknessResonator = new TrapPart
        {
            Name = WEAKNESS_RESONATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectWeaknessResonator",
            Description = "Reduces the Physical Armor of Enemies damaged by the trap by -50 for 2s. Debuff does not stack with other Debilitation Resonators.",
            PartSlot = RESONATOR,
            FlavourText = "\"The flesh is weak... But the spirit is strong!\" - Oziel, the Soul Thief"
        };
        public static TrapPart ChargingSpring = new TrapPart
        {
            Name = CHARGING_SPRING,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectChargingSpring",
            Description = "Improves the Trap's refire rate, making it 20% faster.",
            PartSlot = SPRING,
            FlavourText = "For a happier, snappier trap."
        };
        public static TrapPart DoubleSpring = new TrapPart
        {
            Name = DOUBLE_SPRING,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectDoubleSpring",
            Description = "Improves the Trap's refire rate, making it 35% faster. It also increases its build cost by 25%.",
            PartSlot = SPRING,
            FlavourText = "Puts a spring in their deaths."
        };
        public static TrapPart ShortSpring = new TrapPart
        {
            Name = SHORT_SPRING,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectShortSpring",
            Description = "Penalizes the Trap's refire rate, slowing it by 15% but reduces the Traps build cost by 30%.",
            PartSlot = SPRING,
            FlavourText = "\"I've always used short fuses, so what the heck, eh?\" - Dobbin, Claim Jumper"
        };
        public static TrapPart AmbushTrigger = new TrapPart
        {
            Name = AMBUSH_TRIGGER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectAmbushTrigger",
            Description = "This Trap will only trigger if there is a Minion with more than 75% health in range. In addition, increases the damage of the Trap by 25%.",
            PartSlot = TRIGGER,
            FlavourText = "\"You must always wait for the purrrfect time to pounce.\" - Midnight, Twilight's Razor"
        };
        public static TrapPart ComboGenerator = new TrapPart
        {
            Name = COMBO_GENERATOR,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectComboGenerator",
            Description = "Adds +1 Combo Point to frozen, stunned, or mid-air Minions while on the Trap. In addition, increases the damage of the trap by 10%. Does not stack with other combo generators.",
            PartSlot = TRIGGER,
            FlavourText = "\"Momma loves combos. You know another good combo? Peanut butter and donkey fat!\" - Bionka, Queen Momma"
        };
        public static TrapPart CrowdControlTrigger = new TrapPart
        {
            Name = CROWD_CONTROL_TRIGGER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectCrowdControlTrigger",
            Description = "Causes the Trap to be triggered only if 3 or more Minions are within range. In addition, increases damage by 10%.",
            PartSlot = TRIGGER,
            FlavourText = "\"Orcs that stay together, pay together!\" - Maximilian, the War Mage"
        };
        public static TrapPart ExecutionTrigger = new TrapPart
        {
            Name = EXECUTION_TRIGGER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectExecutionTrigger",
            Description = "This Trap will only trigger if there is a Minion with less than 25% health in range. In addition, increases the damage of the trap by 25%.",
            PartSlot = TRIGGER,
            FlavourText = "\"How... Efficient.\" - Bloodspike, the Brutal"
        };
        public static TrapPart HeatActivatedTrigger = new TrapPart
        {
            Name = HEAT_ACTIVATED_TRIGGER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectHeatActivated",
            Description = "Adds a 10% chance for the Trap to reset if burning Minions are nearby, regardless of the traps' cooldown state. The Heat Activated Trigger will only trigger, when an enemy crosses into the trigger range for a trap.",
            PartSlot = TRIGGER,
            FlavourText = "\"Let THEM feel the heat!\" - Smolder, the Fireborn"
        };
        public static TrapPart HeavyPressurePlate = new TrapPart
        {
            Name = HEAVY_PRESSURE_PLATE,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectHeavyPressurePlate",
            Description = "Causes only heavy/Large Minions to trigger the trap. In addition, increases the damage of the trap by 25%. Not compatible with Big Game Hunting Traps.",
            PartSlot = TRIGGER,
            FlavourText = "\"HEY! That ain't FAIR!\" - Bionka, Queen Momma"
        };
        public static TrapPart KineticReclaimer = new TrapPart
        {
            Name = KINETIC_RECLAIMER,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectKineticReclaimer",
            Description = "Adds a 10% chance for a Trap reset if Minions are thrown into it, regardless of cooldown. Trap jams and resets normally if it resets too many times too quickly.",
            PartSlot = TRIGGER,
            FlavourText = "\"It's impolite to play with your food--but it's SO fun.\" - Midnight, Twilight's Razor"
        };
        public static TrapPart LightPressurePlate = new TrapPart
        {
            Name = LIGHT_PRESSURE_PLATE,
            ItemTinkerEffect = "SpitfireGame.RTrapTinkeringEffectLightPressurePlate",
            Description = "Causes only light Minions to trigger the Trap. In addition, increases the damage of the trap by 15%. Not compatible with Big Game Hunting Traps.",
            PartSlot = TRIGGER,
            FlavourText = "Kobolds beware."
        };

        public static Dictionary<string, TrapPart> TrapParts = new Dictionary<string, TrapPart>
        {
            { DOUBLE_TANK_ACCUMULATOR, DoubleTankAccumulator },
            { STUNNING_ACCUMULATOR, StunningAccumulator },
            { CAPACITANCE_ATTUNER, CapacitanceAttuner },
            { DEEP_CELL_ATTUNER, DeepCellAttuner },
            { REFLECTIVE_ARMOR, ReflectiveArmor },
            { REUSABLE_SHIELDING, ReusableShielding },
            { REVENGE_RUNE, RevengeRune },
            { BRAIDED_COIL, BraidedCoil },
            { DISCOUNT_COIL, DiscountCoil },
            { SELF_IMPROVING_COIL, SelfImprovingCoil },
            { QUICK_TRAP_COMPONENTS, QuickTrapComponents },
            { RENTAL_PARTS, RentalParts },
            { STAMPED_PARTS, StampedParts },
            { SUBSIDIZED_PARTS, SubsidizedParts },
            { VANITY_PLATING, VanityPlating },
            { BOUNTY_GENERATOR, BountyGenerator },
            { HEALTH_SIPHON, HealthSiphon },
            { MANA_SIPHON, ManaSiphon },
            { XP_SIPHON, XPSiphon },
            { DOUBLE_STRUTS, DoubleStruts },
            { HERO_RUNED_FRAME, HeroRunedFrame },
            { CONTROLLED_RESONATOR, ControlledResonator },
            { FIRE_RESONATOR, FireResonator },
            { ICE_RESONATOR, IceResonator },
            { KINETIC_RESONATOR, KineticResonator },
            { UNCHAINED_RESONATOR, UnchainedResonator },
            { WEAKNESS_RESONATOR, WeaknessResonator },
            { CHARGING_SPRING, ChargingSpring },
            { DOUBLE_SPRING, DoubleSpring },
            { SHORT_SPRING, ShortSpring },
            { AMBUSH_TRIGGER, AmbushTrigger },
            { COMBO_GENERATOR, ComboGenerator },
            { CROWD_CONTROL_TRIGGER, CrowdControlTrigger },
            { EXECUTION_TRIGGER, ExecutionTrigger },
            { HEAT_ACTIVATED_TRIGGER, HeatActivatedTrigger },
            { HEAVY_PRESSURE_PLATE, HeavyPressurePlate },
            { KINETIC_RECLAIMER, KineticReclaimer },
            { LIGHT_PRESSURE_PLATE, LightPressurePlate },
        };

        public static List<TrapPart> GetTrapPartsBySlotType(string slotType)
        {
            List<TrapPart> partsBySlotType = new List<TrapPart>();

            foreach (var part in TrapParts.Values)
            {
                if (part.PartSlot == slotType)
                {
                    partsBySlotType.Add(part);
                }
            }

            return partsBySlotType;
        }
    }
}
