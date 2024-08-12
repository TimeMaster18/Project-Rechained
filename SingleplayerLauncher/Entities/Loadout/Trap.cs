using System.Collections.Generic;
using static SingleplayerLauncher.Names.Trap;
using static SingleplayerLauncher.Names.TrapPartSlot;

namespace SingleplayerLauncher.Model
{
    public class Trap : SlotItem
    {

        public string[] TrapPartSlots { get; private set; }

        // static members
        public static Trap ArcaneBowlingBall = new()
        {
            Id = 100,
            Name = ARCANE_BOWLING_BALL,
            Description = "Fires an orb in a straight line, dealing arcane damage. The orb's damage causes subsequent Arcane attacks to deal more damage. +25% damage when used by Stinkeye.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapArcaneOrb",
            SiegeDescription = "Shoots an arcane orb in a long, straight line, dealing arcane damage to enemies. Arcane damage from the orb causes subsequent arcane attacks to deal more damage."
        };
        public static Trap ArcanePhaser = new()
        {
            Id = 101,
            Name = ARCANE_PHASER,
            Description = "Emits a cloud of Arcane energy when triggered, dealing Arcane damage to enemies that walk across it. Trap expires after firing 9 times.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, RESONATOR },
            ItemTemplateName = "SpitfireGame.RItemTrapArcanePhase",
            SiegeDescription = "Emits a cloud of arcane energy when triggered, dealing arcane damage to enemies that walk across it. Trap expires after firing 10 times."
        };
        public static Trap ArrowWall = new()
        {
            Id = 102,
            Name = ARROW_WALL,
            Description = "Fires a barrage of arrows in a straight line when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapArrowWall",
            SiegeDescription = "Fires a barrage of arrows in a straight line when triggered, dealing physical damage."
        };
        public static Trap BGHArrowWall = new()
        {
            Id = 103,
            Name = BGH_ARROW_WALL,
            SiegeName = HERO_SEEKER_ARROW_WALL,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Fires a barrage of magical, mercenary and boss seeking arrows, dealing a portion of the target's max health and a bonus as damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapArrowWallGlorySeeker",
            SiegeDescription = "Fires a barrage of magical, hero-seeking arrows when triggered, dealing physical damage."
        };
        public static Trap CeilingBallista = new()
        {
            Id = 104,
            Name = CEILING_BALLISTA,
            Description = "Fires long-range arrows radially from above when triggered, dealing Physical damage. It also targets Unstable Rifts but deals very low damage to them opposed to the Big Game Hunting Ballista.Ballistas, activation range is lengthened / shortened by Line of Sight(LoS).So if minions come around a corner, the activation range is changed based on the trap's LoS and any Triggers would activate at that point.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeiling",
            SiegeDescription = "Fires long-range arrows radially from above when triggered, dealing physical damage."
        };
        public static Trap DragonsLance = new()
        {
            Id = 105,
            Name = DRAGONS_LANCE,
            Description = "Fires a magical lance when triggered, dealing Arcane damage. Lance casts a debuff, causing Arcane attacks to deal more damage. Dragon's Lance, activation range is lengthened / shortened by Line of Sight(LoS).So if minions come around a corner, the activation range is changed based on the trap's LoS and any Triggers would activate at that point.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeilingArcane",
            SiegeDescription = "Fires a magical lance when triggered, dealing arcane damage. Lance casts a debuff, causing arcane attacks to deal more damage."
        };
        public static Trap BGHCeilingBallista = new()
        {
            Id = 106,
            Name = BGH_CEILING_BALLISTA,
            SiegeName = HERO_SEEKER_BALLISTA,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Also attacks Unstable Rifts Fires Mercenary and Boss seeking arrows, dealing a portion of the target's max health plus a bonus as damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeilingGlorySeeker",
            SiegeDescription = "Fires hero-seeking arrows from above when triggered. Heroes can only be targeted by one Hero-Seeker Ballista at a time."
        };
        public static Trap Barricade = new()
        {
            Id = 107,
            Name = BARRICADE,
            Description = "Blocks and redirects Minion paths. Useful for forcing Minions into Traps.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapBarricade",
            SiegeDescription = "Blocks and redirects minion paths and useful for forcing minions into traps."
        };
        public static Trap GreatWallBarricade = new()
        {
            Id = 108,
            Name = GREAT_WALL_BARRICADE,
            Description = "Blocks and redirects minions. The Great Wall Barricade is a longer version of the Barricade.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapBarricadeGreatWall",
            SiegeDescription = "Blocks and redirects minions. The Great Wall Barricade is a longer version of the Barricade."
        };
        public static Trap BoomBarrel = new()
        {
            Id = 109,
            Name = BOOM_BARREL,
            Description = "Explodes when hit, dealing damage in a small area. -20% cost when used by Deadeye.",
            TrapPartSlots = new string[] { RESONATOR, COMPONENTS, RESONATOR },
            ItemTemplateName = "SpitfireGame.RItemTrapBoomBarrel",
            SiegeDescription = "Explodes when hit, dealing damage in a small AoE."
        };
        public static Trap BoomBarrelRoller = new()
        {
            Id = 110,
            Name = BOOM_BARREL_ROLLER,
            Description = "Occasionally rolls out Boom Barrels which explode when hit, dealing damage in a small area.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, COIL },
            ItemTemplateName = "SpitfireGame.RItemTrapBoomBarrelDispenser",
            SiegeDescription = "Occasionally rolls out Boom Barrels which explode when hit, dealing damage in a small AoE."
        };
        public static Trap BoulderChute = new()
        {
            Id = 111,
            Name = BOULDER_CHUTE,
            Description = "Drops boulders on Enemies when shot by a hero. Boulders deal Physical damage.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBoulderChute",
            SiegeDescription = "Drops boulders on enemies when shot by a Hero. Boulders deal physical damage which increases based on the trap's height."
        };
        public static Trap IcicleImpaler = new()
        {
            Id = 112,
            Name = ICICLE_IMPALER,
            Description = "Drops sharp icicles when shot by a Hero, dealing Frost damage and casting Chilled on Enemies.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBoulderChuteFrost",
            SiegeDescription = "Drops sharp icicles when shot by a hero, dealing frost damage and casting Chilled on enemies."
        };
        public static Trap Brimstone = new()
        {
            Id = 113,
            Name = BRIMSTONE,
            Description = "Burns Enemies that walk across its embers, dealing Fire damage over time. Fire damage from multiple brimstones does not stack.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBrimstone",
            SiegeDescription = "Burns enemies that walk across its embers, dealing fire damage over time. Fire damage from multiple brimstones does not stack."
        };
        public static Trap CoinForge = new()
        {
            Id = 114,
            Name = COIN_FORGE,
            Description = "Enemies are worth 64% additional coin if they are killed on this trap. +10% additional coin when used by Dobbin.",
            TrapPartSlots = new string[] { FIELD, FIELD, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapCoinForge",
            SiegeDescription = "Enemies are worth twice as much coin if they are killed on this trap."
        };
        public static Trap CursedGround = new()
        {
            Id = 115,
            Name = CURSED_GROUND,
            Description = "Deals Arcane damage that increases as Enemies stay on this tile. Also causes subsequent Arcane attacks to deal more damage. +25% damage when used by Oziel.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapCursedGround",
            SiegeDescription = "Deals arcane damage that increases as enemies stay on the trap. It also casts an arcane debuff, causing arcane attacks to deal more damage."
        };
        public static Trap Decoy = new()
        {
            Id = 116,
            Name = DECOY,
            Description = "Attracts Enemies to attack it until it is destroyed. The decoy does not respawn and must be replaced. Trap is free when used by Maximilian.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapDecoySturdy",
            SiegeDescription = "Attracts enemies to attack it until it is destroyed. The decoy does not respawn."
        };
        public static Trap SpitfireWall = new()
        {
            Id = 117,
            Name = SPITFIRE_WALL,
            Description = "Spits fireballs at Enemies, dealing Fire damage over time. Fire damage from multiple spitfire walls does not stack.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFireArrowWall",
            SiegeDescription = "Spits fireballs at enemies, dealing fire damage over time when triggered. Fire damage from multiple spitfire walls does not stack."
        };
        public static Trap FireCracker = new()
        {
            Id = 118,
            Name = FIRE_CRACKER,
            Description = "Emits a fiery mist, dealing Fire damage over time when triggered. Fire damage from multiple fire crackers does not stack.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapFireCracks",
            SiegeDescription = "Emits a fiery mist, dealing fire damage over time when triggered. Fire damage from multiple fire crackers does not stack."
        };
        public static Trap FlipTrap = new()
        {
            Id = 119,
            Name = FLIP_TRAP,
            Description = "Flips enemies into the air when triggered. This trap is useful for propelling Enemies into other traps.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFlip",
            SiegeDescription = "Flips enemies into the air when triggered. This trap is useful for propelling enemies into other traps."
        };
        public static Trap FloorScorcher = new()
        {
            Id = 120,
            Name = FLOOR_SCORCHER,
            Description = "Scorches Enemies when triggered, dealing Fire damage over time. Fire damage from multiple floor scorchers does not stack.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFloorScorcher",
            SiegeDescription = "Scorches enemies when triggered, dealing fire damage over time. Fire damage from multiple floor scorchers does not stack."
        };
        public static Trap TempleAlarmGong = new()
        {
            Id = 121,
            Name = TEMPLE_ALARM_GONG,
            Description = "This ancient gong sounds an alarm when Enemies approach and slows them by 70%. -20% cooldown when used by Yi-Lin.",
            TrapPartSlots = new string[] { FIELD, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapGong",
        };
        public static Trap Grinder = new()
        {
            Id = 122,
            Name = GRINDER,
            Description = "Grinds up Enemies walking past it, dealing Physical damage until it jams. After jamming, the Grinder must cooldown to reset.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapGrinder",
            SiegeDescription = "Grinds up enemies walking past it, dealing physical damage until it jams. After jamming, the Grinder must reset."
        };
        public static Trap QuarterPounder = new()
        {
            Id = 123,
            Name = QUARTER_POUNDER,
            Description = "Pounds one quarter of the trap area when triggered, dealing high Physical damage and stunning Minions.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapHammerDrop",
            SiegeDescription = "Pounds one quarter of the trap area when triggered, dealing high physical damage."
        };
        public static Trap Haymaker = new()
        {
            Id = 124,
            Name = HAYMAKER,
            Description = "Descends from the ceiling and spins when triggered, knocking Enemies around and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapHaymaker",
            SiegeDescription = "Descends from the ceiling and spins when triggered, knocking enemies around and dealing physical damage."
        };
        public static Trap HealingWell = new()
        {
            Id = 125,
            Name = HEALING_WELL,
            Description = "Casts a health regeneration buff on an ally. The buff is dispelled upon taking damage. Once used, it must reset.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapHealingWell",
            SiegeDescription = "Casts a health regeneration buff on an ally. The buff is dispelled upon taking damage. Once used, it must reset."
        };
        public static Trap IceShard = new()
        {
            Id = 126,
            Name = ICE_SHARD,
            Description = "Cuts enemies, dealing Frost damage and casting Chilled on them. Enemies are frozen after multiple stacks of Chilled (5 stacks).",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapIceSpike",
            SiegeDescription = "Cuts enemies, dealing frost damage and casting Chilled on them."
        };
        public static Trap IceVent = new()
        {
            Id = 127,
            Name = ICE_VENT,
            Description = "Emits icy mist that deals Frost damage and casts Chilled on enemies. Enemies are frozen after multiple stacks of Chilled (5 stacks). +25% damage when used by Hogarth.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapIceVent",
            SiegeDescription = "Emits icy mist that deals frost damage and casts Chilled on minons while they are on it. Freezes minions after multiple stacks of Chilled."
        };
        public static Trap LightningRod = new()
        {
            Id = 128,
            Name = LIGHTNING_ROD,
            Description = "Shocks Enemies beneath it with lightning when triggered. Every few times this trap fires, it becomes more powerful, allowing its attack to chain to additional Enemies.",
            TrapPartSlots = new string[] { COMPONENTS, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapLightningRod",
            SiegeDescription = "Shocks enemies beneath it with lightning when triggered. Attacks build, chaining to nearby enemies. Recharges automatically."
        };
        public static Trap ManaWell = new()
        {
            Id = 129,
            Name = MANA_WELL,
            Description = "Grants a mana regeneration buff to a nearby ally. Buff is lost upon taking damage. Once used, the Mana Well must reset.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapManaWell",
            SiegeDescription = "Grants a mana regeneration buff to a nearby ally. Buff is lost upon taking damage. Once used, the Mana Well must reset."
        };
        public static Trap SummonerTrap = new()
        {
            Id = 130,
            Name = SUMMONER_TRAP,
            Description = "Calls a ghostly summoned retainer to fight for the Hero. If it is killed, the trap must reset. Limit 2 at a time. +25 trap health if used by Gabriella.Revenge Rune and Reusable Shielding have a cooldown of 300 seconds(5 minutes) when used in Summoner Trap.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapMinionSpawner",
            SiegeDescription = "Calls a ghostly summoned retainer to fight on behalf of Gabriella. If the summoned retainer is killed, the trap must reset before another is called."
        };
        public static Trap NaphthaSprayer = new()
        {
            Id = 131,
            Name = NAPHTHA_SPRAYER,
            Description = "Sprays enemies with naphtha when triggered. Naphtha causes Enemies to take increased Fire damage. Trap is free when used by Smolder.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapNapthaSprayer",
            SiegeDescription = "Coats enemies with naphtha, a flammable material, when triggered. The naphtha causes targets to take increased fire damage."
        };
        public static Trap OverloadTrap = new()
        {
            Id = 132,
            Name = OVERLOAD_TRAP,
            Description = "Overloads traps, dealing damage when triggered and disabling floor traps that deal damage. +25% damage when used by Zoey.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapOverload",
            SiegeDescription = "Overloads traps, dealing damage when triggered and disabling nearby traps."
        };
        public static Trap PowerupDamage = new()
        {
            Id = 133,
            Name = POWERUP_DAMAGE,
            Description = "Drops a Powerup that boosts player damage for a short time.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapPlayerPowerup",
            SiegeDescription = "Drops a powerup that boosts player damage for a short time."
        };
        public static Trap Pounder = new()
        {
            Id = 134,
            Name = POUNDER,
            Description = "Pounds Enemies that pass beneath it when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPounder",
            SiegeDescription = "Pounds enemies that pass beneath it when triggered, dealing physical damage."
        };
        public static Trap ConcussivePounder = new()
        {
            Id = 135,
            Name = CONCUSSIVE_POUNDER,
            Description = "Pounds Enemies into the ground when triggered, stunning them. Deals no damage.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPounderConcussive",
            SiegeDescription = "Pounds enemies into the ground when triggered, stunning them. Deals no damage."
        };
        public static Trap PowerGenerator = new()
        {
            Id = 136,
            Name = POWER_GENERATOR,
            Description = "Generates coin for the owner if Enemies walk in front of it. Loses health each time it generates coin. Doesn't return coin when sold. Note: Generates 468 coins per wave at Tier 7.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapPowerGenerator",
            SiegeDescription = "Generates coin for the owner if enemies walk in front of it. Can be disabled by attacks."
        };
        public static Trap PushTrap = new()
        {
            Id = 137,
            Name = PUSH_TRAP,
            Description = "Shoves Enemies when triggered, pushing them away and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPushTrap",
            SiegeDescription = "Shoves enemies when triggered, pushing them away and dealing physical damage."
        };
        public static Trap SawOfArctos = new()
        {
            Id = 138,
            Name = SAW_OF_ARCTOS,
            Description = "Slices through Enemies with an ice blade, dealing Frost damage and casting Chilled on them. Enemies are frozen with 5 Chilled Stacks. + 25% damage when used by Tundra.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSawOfArctos",
            SiegeDescription = "Slices though enemy minions with an ice blade, dealing frost damage and casting Chilled on them."
        };
        public static Trap ShieldPowerup = new()
        {
            Id = 139,
            Name = SHIELD_POWERUP,
            Description = "Drops a Powerup for Heroes that temporarily reduces damage taken.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapShieldSpawner",
            SiegeDescription = "Drops a powerup for heroes that temporarily reduces damage taken."
        };
        public static Trap SpeedPad = new()
        {
            Id = 140,
            Name = SPEED_PAD,
            Description = "Increases the movement speed of a Hero crossing it. Pad must reset after use.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapSpeedPad",
            SiegeDescription = "Increases the movement speed of a hero crossing it. Pad must reset after use."
        };
        public static Trap FloorSpikes = new()
        {
            Id = 141,
            Name = FLOOR_SPIKES,
            Description = "Skewers Enemies from below when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSpikes",
            SiegeDescription = "Skewers enemies from below when triggered, dealing physical damage."
        };
        public static Trap SpikeWall = new()
        {
            Id = 142,
            Name = SPIKE_WALL,
            Description = "Swings a wall of spikes at Enemies when triggered, knocking them back and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSpikeWall",
            SiegeDescription = "Swings a wall of spikes at enemies when triggered, knocking them back and dealing physical damage."
        };
        public static Trap SteamVent = new()
        {
            Id = 143,
            Name = STEAM_VENT,
            Description = "Blows small and normal-sized Minions into the air when triggered. Slows large Minions. Trap deals no damage.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSteamVent",
            SiegeDescription = "Blows small and normal-sized minions into the air when triggered. Slows large minions. Trap deals no damage."
        };
        public static Trap SwingingMace = new()
        {
            Id = 144,
            Name = SWINGING_MACE,
            Description = "Continuously swings a large mace, pummeling enemies that pass beneath it and dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapSwingingMace",
            SiegeDescription = "Continuously swings a large mace, pummeling enemies that pass beneath it and dealing physical damage."
        };
        public static Trap TarTrap = new()
        {
            Id = 145,
            Name = TAR_TRAP,
            Description = "Tars the feet of Enemies crossing it, causing them to be slowed while on the trap.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTar",
            SiegeDescription = "Tars the feet of enemies crossing it, causing them to be slowed while on the trap."
        };
        public static Trap ViscousTar = new()
        {
            Id = 146,
            Name = VISCOUS_TAR,
            Description = "Tars the feet of Enemies crossing it, causing them to be slowed while on the trap and for a short duration afterwards.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTarViscous",
            SiegeDescription = "Tars the feet of enemies crossing it, causing them to be slowed while on the trap and for a 1.75s afterwards."
        };
        public static Trap ShockZapper = new()
        {
            Id = 147,
            Name = SHOCK_ZAPPER,
            Description = "Zaps enemies with Lightning, dealing Lightning damage. Enemies killed by Lightning explode, dealing damage in an area.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapTeslaCoil",
            SiegeDescription = "Zaps enemies with lightning, dealing lightning damage. Enemies killed by lightning explode, dealing AoE damage."
        };
        public static Trap BGHShockZapper = new()
        {
            Id = 148,
            Name = BGH_SHOCK_ZAPPER,
            SiegeName = HERO_SEEKER_ZAPPER,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Zaps Mercenaries and Bosses with Lightning, dealing a portion of targets' max health as damage plus a bonus.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapTeslaCoilGlorySeeker",
            SiegeDescription = "Zaps enemy heroes with hero-seeking lightning when triggered."
        };
        public static Trap TripWire = new()
        {
            Id = 149,
            Name = TRIP_WIRE,
            Description = "When a Minion 'trips' on the trip wire, it triggers nearby Traps. Wire is destroyed on use. -20% trap cost when used by Midnight.",
            TrapPartSlots = new string[] { COMPONENTS, TRIGGER, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTripwire"
        };
        public static Trap WallBlades = new()
        {
            Id = 150,
            Name = WALL_BLADES,
            Description = "Slices and dices Enemies when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWallBlades",
            SiegeDescription = "Slices and dices enemies when triggered, dealing physical damage."
        };
        public static Trap WallCharger = new()
        {
            Id = 151,
            Name = WALL_CHARGER,
            Description = "Shocks Enemies that walk by it, dealing Lightning damage. Enemies killed by Lightning explode, dealing damage in an area.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWallBladesCharged",
            SiegeDescription = "Shocks enemies that walk by it, dealing lightning damage. Enemies killed by lightning explode for AoE damage."
        };
        public static Trap WebSpinner = new()
        {
            Id = 152,
            Name = WEB_SPINNER,
            Description = "Spins a web around Enemies when triggered, slowing their attack speed and causing them to be slowed.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWebSpinner",
            SiegeDescription = "Spins a web around enemies when triggered, slowing their attack speed and causing them to be slowed."
        };

        // Siege Only
        public static Trap AntiMagicField = new()
        {
            Id = 153,
            Name = ANTI_MAGIC_FIELD,
            ItemTemplateName = "SpitfireGame.RTrapAntiMagicFieldGreater",
            SiegeDescription = "Emits a magic-dampening field that disables enemy abilities and removes one glyph buff. This trap is charge based.",
        };
        public static Trap BuffPylon = new()
        {
            Id = 154,
            Name = BUFF_PYLON,
            ItemTemplateName = "SpitfireGame.RItemTrapPylon",
            SiegeDescription = "",
        };


        public static Dictionary<string, SlotItem> Traps = new()
        {
            //{ "Acid Sprayer", null },
            { ARCANE_BOWLING_BALL, ArcaneBowlingBall },
            { ARCANE_PHASER, ArcanePhaser },
            { ARROW_WALL, ArrowWall },
            { BGH_ARROW_WALL, BGHArrowWall },
            { CEILING_BALLISTA, CeilingBallista },
            { DRAGONS_LANCE, DragonsLance },
            { BGH_CEILING_BALLISTA, BGHCeilingBallista },
            { BARRICADE, Barricade },
            { GREAT_WALL_BARRICADE, GreatWallBarricade },
            { BOOM_BARREL, BoomBarrel },
            { BOOM_BARREL_ROLLER, BoomBarrelRoller },
            { BOULDER_CHUTE, BoulderChute },
            { ICICLE_IMPALER, IcicleImpaler },
            { BRIMSTONE, Brimstone },
            { COIN_FORGE, CoinForge },
            { CURSED_GROUND, CursedGround },
            { DECOY, Decoy },
            { SPITFIRE_WALL, SpitfireWall },
            { FIRE_CRACKER, FireCracker },
            { FLIP_TRAP, FlipTrap },
            { FLOOR_SCORCHER, FloorScorcher },
            { TEMPLE_ALARM_GONG, TempleAlarmGong },
            { GRINDER, Grinder },
            { QUARTER_POUNDER, QuarterPounder },
            { HAYMAKER, Haymaker },
            { HEALING_WELL, HealingWell },
            { ICE_SHARD, IceShard },
            { ICE_VENT, IceVent },
            { LIGHTNING_ROD, LightningRod },
            { MANA_WELL, ManaWell },
            { SUMMONER_TRAP, SummonerTrap },
            { NAPHTHA_SPRAYER, NaphthaSprayer },
            { OVERLOAD_TRAP, OverloadTrap },
            { POWERUP_DAMAGE, PowerupDamage },
            { POUNDER, Pounder },
            { CONCUSSIVE_POUNDER, ConcussivePounder },
            { POWER_GENERATOR, PowerGenerator },
            //{ "Projectile Shield", null },
            { PUSH_TRAP, PushTrap },
            { SAW_OF_ARCTOS, SawOfArctos },
            { SHIELD_POWERUP, ShieldPowerup },
            { SPEED_PAD, SpeedPad },
            { FLOOR_SPIKES, FloorSpikes },
            { SPIKE_WALL, SpikeWall },
            { STEAM_VENT, SteamVent },
            { SWINGING_MACE, SwingingMace },
            { TAR_TRAP, TarTrap },
            { VISCOUS_TAR, ViscousTar },
            { SHOCK_ZAPPER, ShockZapper },
            { BGH_SHOCK_ZAPPER, BGHShockZapper },
            { TRIP_WIRE, TripWire},
            { WALL_BLADES, WallBlades },
            { WALL_CHARGER, WallCharger },
            { WEB_SPINNER, WebSpinner }
        };


        public static Dictionary<string, SlotItem> SiegeTraps = new()
        {
            // { ARCANE_BOWLING_BALL, ArcaneBowlingBall },
            { ARCANE_PHASER, ArcanePhaser },
            { ARROW_WALL, ArrowWall },
            { HERO_SEEKER_ARROW_WALL, BGHArrowWall },
            { CEILING_BALLISTA, CeilingBallista },
            { DRAGONS_LANCE, DragonsLance },
            { HERO_SEEKER_BALLISTA, BGHCeilingBallista },
            { BARRICADE, Barricade },
            { GREAT_WALL_BARRICADE, GreatWallBarricade },
            { BOOM_BARREL, BoomBarrel },
            { BOOM_BARREL_ROLLER, BoomBarrelRoller },
            { BOULDER_CHUTE, BoulderChute },
            { ICICLE_IMPALER, IcicleImpaler },
            { BRIMSTONE, Brimstone },
            // { COIN_FORGE, CoinForge },
            { CURSED_GROUND, CursedGround },
            // { DECOY, Decoy },
            { SPITFIRE_WALL, SpitfireWall },
            { FIRE_CRACKER, FireCracker },
            { FLIP_TRAP, FlipTrap },
            { FLOOR_SCORCHER, FloorScorcher },
            // { TEMPLE_ALARM_GONG, TempleAlarmGong },
            { GRINDER, Grinder },
            { QUARTER_POUNDER, QuarterPounder },
            { HAYMAKER, Haymaker },
            { HEALING_WELL, HealingWell },
            { ICE_SHARD, IceShard },
            { ICE_VENT, IceVent },
            { LIGHTNING_ROD, LightningRod },
            { MANA_WELL, ManaWell },
            // { SUMMONER_TRAP, SummonerTrap },
            // { NAPHTHA_SPRAYER, NaphthaSprayer },
            // { OVERLOAD_TRAP, OverloadTrap },
            { POWERUP_DAMAGE, PowerupDamage },
            { POUNDER, Pounder },
            { CONCUSSIVE_POUNDER, ConcussivePounder },
            { POWER_GENERATOR, PowerGenerator },
            // { "Projectile Shield", null },
            { PUSH_TRAP, PushTrap },
            // { SAW_OF_ARCTOS, SawOfArctos },
            { SHIELD_POWERUP, ShieldPowerup },
            { SPEED_PAD, SpeedPad },
            { FLOOR_SPIKES, FloorSpikes },
            { SPIKE_WALL, SpikeWall },
            { STEAM_VENT, SteamVent },
            { SWINGING_MACE, SwingingMace },
            { TAR_TRAP, TarTrap },
            { VISCOUS_TAR, ViscousTar },
            { SHOCK_ZAPPER, ShockZapper },
            { HERO_SEEKER_ZAPPER, BGHShockZapper },
            // { TRIP_WIRE, TripWire},
            { WALL_BLADES, WallBlades },
            { WALL_CHARGER, WallCharger },
            { WEB_SPINNER, WebSpinner }
        };


        public static Dictionary<int, SlotItem> TrapsById = new()
        {
            //{ AcidSprayer.Id, null },
            { ArcaneBowlingBall.Id, ArcaneBowlingBall },
            { ArcanePhaser.Id, ArcanePhaser },
            { ArrowWall.Id, ArrowWall },
            { BGHArrowWall.Id, BGHArrowWall },
            { CeilingBallista.Id, CeilingBallista },
            { DragonsLance.Id, DragonsLance },
            { BGHCeilingBallista.Id, BGHCeilingBallista },
            { Barricade.Id, Barricade },
            { GreatWallBarricade.Id, GreatWallBarricade },
            { BoomBarrel.Id, BoomBarrel },
            { BoomBarrelRoller.Id, BoomBarrelRoller },
            { BoulderChute.Id, BoulderChute },
            { IcicleImpaler.Id, IcicleImpaler },
            { Brimstone.Id, Brimstone },
            { CoinForge.Id, CoinForge },
            { CursedGround.Id, CursedGround },
            { Decoy.Id, Decoy },
            { SpitfireWall.Id, SpitfireWall },
            { FireCracker.Id, FireCracker },
            { FlipTrap.Id, FlipTrap },
            { FloorScorcher.Id, FloorScorcher },
            { TempleAlarmGong.Id, TempleAlarmGong },
            { Grinder.Id, Grinder },
            { QuarterPounder.Id, QuarterPounder },
            { Haymaker.Id, Haymaker },
            { HealingWell.Id, HealingWell },
            { IceShard.Id, IceShard },
            { IceVent.Id, IceVent },
            { LightningRod.Id, LightningRod },
            { ManaWell.Id, ManaWell },
            { SummonerTrap.Id, SummonerTrap },
            { NaphthaSprayer.Id, NaphthaSprayer },
            { OverloadTrap.Id, OverloadTrap },
            { PowerupDamage.Id, PowerupDamage },
            { Pounder.Id, Pounder },
            { ConcussivePounder.Id, ConcussivePounder },
            { PowerGenerator.Id, PowerGenerator },
            //{ ShieldProjectile.Id, null },
            { PushTrap.Id, PushTrap },
            { SawOfArctos.Id, SawOfArctos },
            { ShieldPowerup.Id, ShieldPowerup },
            { SpeedPad.Id, SpeedPad },
            { FloorSpikes.Id, FloorSpikes },
            { SpikeWall.Id, SpikeWall },
            { SteamVent.Id, SteamVent },
            { SwingingMace.Id, SwingingMace },
            { TarTrap.Id, TarTrap },
            { ViscousTar.Id, ViscousTar },
            { ShockZapper.Id, ShockZapper },
            { BGHShockZapper.Id, BGHShockZapper },
            { TripWire.Id, TripWire},
            { WallBlades.Id, WallBlades },
            { WallCharger.Id, WallCharger },
            { WebSpinner.Id, WebSpinner }
        };
    }
}
