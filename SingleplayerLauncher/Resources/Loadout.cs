using System.Collections.Generic;

namespace SingleplayerLauncher.Resources
{
    internal static class Loadout
    {
        public class Trap
        {
            public class StatModifierExpression
            {
                public int Offset;
                public string Expression;
                public StatModifierExpression(int offset, string expression)
                {
                    Offset = offset;
                    Expression = expression;
                }
            }

            public string Name { get; private set; }
            public byte[] Id { get; private set; } // id linking the trap, in SpitfireGame.upk
            public List<StatModifierExpression> StatModifierExpressions { get; private set; }
            public int TextureOffset { get; private set; } // in SpitfireUPK
            public int IconOffset { get; private set; } // in SpitfireUPK
            public List<byte[]> IconIds { get; private set; } // ids linking the trap icons
			public float IncreasePerTier { get; private set; }
			public int CoinCostOffset { get; private set; } // in SpitfireUPK
			public int CoinCost { get; private set; }

			// private constructor
			Trap() { }

            // static members
            public static Trap FloorSpikes = new Trap()
            {                
                Name = "Floor Spikes",
                Id = new byte[] { 0xB6, 0xC4, 0x00, 0x00 },
                StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5F98, "160.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
                TextureOffset = 0x186D798,
                IconOffset = 0x2716FF1,
                IconIds = new List<byte[]>() { new byte[] { 0x26 }, new byte[] { 0x27 }, new byte[] { 0x28 }, new byte[] { 0x29 } }
            };
			public static Trap ArcaneBowlingBall = new Trap()
			{
				Name = "Arcane Bowling Ball",
				Id = new byte[] { 0x62, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F218B, "120.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x183E781,
				IconOffset = 0x27164C7,
				IconIds = new List<byte[]>() { new byte[] { 0xA2 }, new byte[] { 0xA3 }, new byte[] { 0xA4 }, new byte[] { 0xA5 } }
			};
			public static Trap ArcanePhaser = new Trap()
			{
				Name = "Arcane Phaser",
				Id = new byte[] { 0x64, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F22D9, "110.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x183EF16,
				IconOffset = 0x271650B,
				IconIds = new List<byte[]>() { new byte[] { 0xE2 }, new byte[] { 0xE3 }, new byte[] { 0xE4 }, new byte[] { 0xE5 } }
			};
			public static Trap ArrowWall = new Trap()
			{
				Name = "Arrow Wall",
				Id = new byte[] { 0x66, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2427, "30.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x183F5D5,
				IconOffset = 0x271654F,
				IconIds = new List<byte[]>() { new byte[] { 0xEA }, new byte[] { 0xEB }, new byte[] { 0xEC }, new byte[] { 0xED } }
			};
			public static Trap BGHArrowWall = new Trap()
			{
				Name = "BGH Arrow Wall",
				Id = new byte[] { 0x68, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2594, "18 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x183FD96,
				IconOffset = 0x2716593,
				IconIds = new List<byte[]>() { new byte[] { 0xE6 }, new byte[] { 0xE7 }, new byte[] { 0xE8 }, new byte[] { 0xE9 } }
			};
			public static Trap CeilingBallista = new Trap()
			{
				Name = "Ceiling Ballista",
				Id = new byte[] { 0x6A, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F26E7, "185.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18423EB,
				IconOffset = 0x27165D7,
				IconIds = new List<byte[]>() { new byte[] { 0xF2 }, new byte[] { 0xF3 }, new byte[] { 0xF4 }, new byte[] { 0xF5 } }
			};
			public static Trap DragonsLance = new Trap()
			{
				Name = "Dragons Lance",
				Id = new byte[] { 0x6C, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2837, "100.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1843290,
				IconOffset = 0x271661B,
				IconIds = new List<byte[]>() { new byte[] { 0xEE }, new byte[] { 0xEF }, new byte[] { 0xF0 }, new byte[] { 0xF1 } }
			};
			public static Trap BGHCeilingBallista = new Trap()
			{
				Name = "BGH Ceiling Ballista",
				Id = new byte[] { 0x6E, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F29A3, "38 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1844A3E,
				IconOffset = 0x271665F,
				IconIds = new List<byte[]>() { new byte[] { 0x2A }, new byte[] { 0x2B }, new byte[] { 0x2C }, new byte[] { 0x2D } }
			};
			public static Trap Barricade = new Trap()
			{
				Name = "Barricade",
				Id = new byte[] { 0x70, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2A9E, "(src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1846B9F,
				IconOffset = 0x27166A3,
				IconIds = new List<byte[]>() { new byte[] { 0xFA }, new byte[] { 0xFB }, new byte[] { 0xFC }, new byte[] { 0xFD } }
			};
			public static Trap GreatWallBarricade = new Trap()
			{
				Name = "Great Wall Barricade",
				Id = new byte[] { 0x72, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2A9E, "(src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1847B72,
				IconOffset = 0x27166E7,
				IconIds = new List<byte[]>() { new byte[] { 0xF6 }, new byte[] { 0xF7 }, new byte[] { 0xF8 }, new byte[] { 0xF9 } }
			};
			public static Trap BoomBarrel = new Trap()
			{
				Name = "Boom Barrel",
				Id = new byte[] { 0x74, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2B1B, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x184820A,
				IconOffset = 0x271672B,
				IconIds = new List<byte[]>() { new byte[] { 0x02 }, new byte[] { 0x03 }, new byte[] { 0x04 }, new byte[] { 0x05 } }
			};
			public static Trap BoomBarrelRoller = new Trap()
			{
				Name = "Boom Barrel Dispenser",
				Id = new byte[] { 0x76, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2CCB, "100.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x184A0FC,
				IconOffset = 0x271676F,
				IconIds = new List<byte[]>() { new byte[] { 0xFE, 0xCA }, new byte[] { 0xFF, 0xCA }, new byte[] { 0x00, 0xCB }, new byte[] { 0x01, 0xCB } }
			};
			public static Trap BoulderChute = new Trap()
			{
				Name = "Boulder Chute",
				Id = new byte[] { 0x78, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2E67, "200.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x184B628,
				IconOffset = 0x27167CC,
				IconIds = new List<byte[]>() { new byte[] { 0x06 }, new byte[] { 0x07 }, new byte[] { 0x08 }, new byte[] { 0x09 } }
			};
			public static Trap IcicleImpaler = new Trap()
			{
				Name = "Icicle Impaler",
				Id = new byte[] { 0x7A, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3003, "200.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x184CE4A,
				IconOffset = 0x2716829,
				IconIds = new List<byte[]>() { new byte[] { 0x3E }, new byte[] { 0x3F }, new byte[] { 0x40 }, new byte[] { 0x41 } }
			};
			public static Trap Brimstone = new Trap()
			{
				Name = "Brimstone",
				Id = new byte[] { 0x7C, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3143, "30.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x184D529,
				IconOffset = 0x271686D,
				IconIds = new List<byte[]>() { new byte[] { 0x0A }, new byte[] { 0x0B }, new byte[] { 0x0C }, new byte[] { 0x0D } }
			};
			public static Trap CoinForge = new Trap()
			{
				Name = "Coin Forge",
				Id = new byte[] { 0x7E, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3238, "1.64f + (src.IncreasePerTier * src.TrapStrength)") },
				TextureOffset = 0x184DD4C,
				IconOffset = 0x27168B1,
				IconIds = new List<byte[]>() { new byte[] { 0x12 }, new byte[] { 0x13 }, new byte[] { 0x14 }, new byte[] { 0x15 } }
			};
			public static Trap CursedGround = new Trap()
			{
				Name = "Cursed Ground",
				Id = new byte[] { 0x80, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() {   new StatModifierExpression(0x28F33C1, "14.0 * (src.IncreasePerTier ^ src.TrapStrength)"),
																				 new StatModifierExpression(0x28F3349, "27.0 * (src.IncreasePerTier ^ src.TrapStrength)"),
																				 new StatModifierExpression(0x28F32D1, "95.0 * (src.IncreasePerTier ^ src.TrapStrength)")},
				TextureOffset = 0x184F600,
				IconOffset = 0x27168F5,
				IconIds = new List<byte[]>() { new byte[] { 0x16 }, new byte[] { 0x17 }, new byte[] { 0x18 }, new byte[] { 0x19 }, }
			};
			public static Trap Decoy = new Trap()
			{
				Name = "Decoy",
				Id = new byte[] { 0x82, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3459, "(150.0 + src.DamageIncreaseFromLvl) * ((1 + src.IncreasePerTier) ^ src.TrapStrength)") },
				TextureOffset = 0x1850BD9,
				IconIds = null
			};
			public static Trap SpitfireWall = new Trap()
			{
				Name = "Spitfire Wall",
				Id = new byte[] { 0x84, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3774, "15.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1851A47,
				IconOffset = 0x2716965,
				IconIds = new List<byte[]>() { new byte[] { 0x1A }, new byte[] { 0x1B }, new byte[] { 0x1C }, new byte[] { 0x1D } }
			};
			public static Trap FireCracker = new Trap()
			{
				Name = "Fire Cracker",
				Id = new byte[] { 0x86, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F38B2, "14 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185214F,
				IconOffset = 0x27169A9,
				IconIds = new List<byte[]>() { new byte[] { 0x0E }, new byte[] { 0x0F }, new byte[] { 0x10 }, new byte[] { 0x11 } }
			};
			public static Trap FlipTrap = new Trap()
			{
				Name = "Flip Trap",
				Id = new byte[] { 0x88, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F51AD, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x185290F,
				IconOffset = 0x27169ED,
				IconIds = new List<byte[]>() { new byte[] { 0x1E }, new byte[] { 0x1F }, new byte[] { 0x20 }, new byte[] { 0x21 } }
			};
			public static Trap FloorScorcher = new Trap()
			{
				Name = "Floor Scorcher",
				Id = new byte[] { 0x8A, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3D6B, "31.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185330B,
				IconOffset = 0x2716A31,
				IconIds = new List<byte[]>() { new byte[] { 0x22 }, new byte[] { 0x23 }, new byte[] { 0x24 }, new byte[] { 0x25 } }
			};
			public static Trap TempleAlarmGong = new Trap()
			{
				Name = "Temple Alarm Gong",
				Id = new byte[] { 0x8C, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = null,
				TextureOffset = 0x185399C,
				IconOffset = 0x2716A75,
				IconIds = new List<byte[]>() { new byte[] { 0x2E }, new byte[] { 0x2F }, new byte[] { 0x30 }, new byte[] { 0x31 } },
				CoinCostOffset = 0x1617D7E,
				CoinCost = 1000,
				IncreasePerTier = 0.15F
			};
			public static Trap Grinder = new Trap()
			{
				Name = "Grinder",
				Id = new byte[] { 0x8E, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3F5E, "54.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18561F1,
				IconOffset = 0x2716AB9,
				IconIds = new List<byte[]>() { new byte[] { 0x32 }, new byte[] { 0x33 }, new byte[] { 0x34 }, new byte[] { 0x35 } }
			};
			public static Trap QuarterPounder = new Trap()
			{
				Name = "Quarter Pounder",
				Id = new byte[] { 0x90, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F40B0, "525.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18569A5,
				IconOffset = 0x2716AFD,
				IconIds = new List<byte[]>() { new byte[] { 0x5E }, new byte[] { 0x5F }, new byte[] { 0x60 }, new byte[] { 0x61 } }
			};
			public static Trap Haymaker = new Trap()
			{
				Name = "Haymaker",
				Id = new byte[] { 0x92, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F41A7, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x1858016,
				IconOffset = 0x2716B41,
				IconIds = new List<byte[]>() { new byte[] { 0x36 }, new byte[] { 0x37 }, new byte[] { 0x38 }, new byte[] { 0x39 } }
			};
			public static Trap HealingWell = new Trap()
			{
				Name = "Healing Well",
				Id = new byte[] { 0x94, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4307, "(0.09 + (src.TrapStrength * 0.024))*(1 + src.mExtraBoost)*tgt.HealthMax") },
				TextureOffset = 0x18586EC,
				IconOffset = 0x2716B85,
				IconIds = new List<byte[]>() { new byte[] { 0x3A }, new byte[] { 0x3B }, new byte[] { 0x3C }, new byte[] { 0x3D } }
			};
			public static Trap IceShard = new Trap()
			{
				Name = "Ice Shard",
				Id = new byte[] { 0x96, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F458D, "130.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185A670,
				IconOffset = 0x2716BC9,
				IconIds = new List<byte[]>() { new byte[] { 0x42 }, new byte[] { 0x43 }, new byte[] { 0x44 }, new byte[] { 0x45 } }
			};
			public static Trap IceVent = new Trap()
			{
				Name = "Ice Vent",
				Id = new byte[] { 0x98, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F46CD, "25.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185AD42,
				IconOffset = 0x2716C0D,
				IconIds = new List<byte[]>() { new byte[] { 0x46 }, new byte[] { 0x47 }, new byte[] { 0x48 }, new byte[] { 0x49 } }
			};
			public static Trap LightningRod = new Trap()
			{
				Name = "Lightning Rod",
				Id = new byte[] { 0x9A, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F481C, "85.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185B5AB,
				IconOffset = 0x2716C51,
				IconIds = new List<byte[]>() { new byte[] { 0x4A }, new byte[] { 0x4B }, new byte[] { 0x4C }, new byte[] { 0x4D } }
			};
			public static Trap ManaWell = new Trap()
			{
				Name = "Mana Well",
				Id = new byte[] { 0x9C, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4971, "(0.09 + (src.TrapStrength * 0.024))*(1 + src.mExtraBoost)*tgt.ManaMax") },
				TextureOffset = 0x185BC7A,
				IconOffset = 0x2716C95,
				IconIds = new List<byte[]>() { new byte[] { 0x4E }, new byte[] { 0x4F }, new byte[] { 0x50 }, new byte[] { 0x51 } }
			};
			public static Trap SummonerTrap = new Trap()
			{
				Name = "Summoner Trap",
				Id = new byte[] { 0x9E, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() {   new StatModifierExpression(0x28F4B7F, "src.HealthMax * (src.IncreasePerTier ^ src.TrapStrength)"),
																				 new StatModifierExpression(0x28F4AE6, "160.0 * (src.IncreasePerTier ^ src.TrapStrength)")},
				TextureOffset = 0x185D7D4,
				IconOffset = 0x2716CD9,
				IconIds = new List<byte[]>() { new byte[] { 0x52 }, new byte[] { 0x53 }, new byte[] { 0x54 }, new byte[] { 0x55 } }
			};
			public static Trap NaphthaSprayer = new Trap()
			{
				Name = "Naphtha Sprayer",
				Id = new byte[] { 0xA0, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4C94, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x185E8BB,
				IconOffset = 0x2716D1D,
				IconIds = new List<byte[]>() { new byte[] { 0x56 }, new byte[] { 0x57 }, new byte[] { 0x58 }, new byte[] { 0x59 } }
			};
			public static Trap OverloadTrap = new Trap()
			{
				Name = "Overload Trap",
				Id = new byte[] { 0xA2, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4D75, "140.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x185F21D,
				IconOffset = 0x2716D61,
				IconIds = new List<byte[]>() { new byte[] { 0x5A }, new byte[] { 0x5B }, new byte[] { 0x5C }, new byte[] { 0x5D } }
			};
			public static Trap PowerupDamage = new Trap()
			{
				Name = "Powerup Damage",
				Id = new byte[] { 0xA4, 0xC4, 0x00, 0x00  },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4E6C, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x185F9CC,
				IconOffset = 0x2716DA5,
				IconIds = new List<byte[]>() { new byte[] { 0x6E }, new byte[] { 0x6F }, new byte[] { 0x70 }, new byte[] { 0x71 } }
			};
			public static Trap Pounder = new Trap()
			{
				Name = "Pounder",
				Id = new byte[] { 0xA6, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4FB4, "145.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x1860151,
				IconOffset = 0x2716DE9,
				IconIds = new List<byte[]>() { new byte[] { 0x66 }, new byte[] { 0x67 }, new byte[] { 0x68 }, new byte[] { 0x69 } }
			};
			public static Trap ConcussivePounder = new Trap()
			{
				Name = "Concussive Pounder",
				Id = new byte[] { 0xA8, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F50AB, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x18607F9,
				IconOffset = 0x2716E2D,
				IconIds = new List<byte[]>() { new byte[] { 0x62 }, new byte[] { 0x63 }, new byte[] { 0x64 }, new byte[] { 0x65 } }
			};
			public static Trap PowerGenerator = new Trap()
			{
				Name = "Power Generator",
				Id = new byte[] { 0xAA, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5133, "25 * (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x186225E,
				IconOffset = 0x2716E71,
				IconIds = new List<byte[]>() { new byte[] { 0x6A }, new byte[] { 0x6B }, new byte[] { 0x6C }, new byte[] { 0x6D } }
			};
			public static Trap PushTrap = new Trap()
			{
				Name = "Push Trap",
				Id = new byte[] { 0xAE, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F51AD, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x186337A,
				IconOffset = 0x2716EE1,
				IconIds = new List<byte[]>() { new byte[] { 0x76 }, new byte[] { 0x77 }, new byte[] { 0x78 }, new byte[] { 0x79 } }
			};
			public static Trap SawOfArctos = new Trap()
			{
				Name = "Saw Of Arctos",
				Id = new byte[] { 0xB0, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F543D, "190 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18646E0,
				IconOffset = 0x2716F25,
				IconIds = new List<byte[]>() { new byte[] { 0x7A }, new byte[] { 0x7B }, new byte[] { 0x7C }, new byte[] { 0x7D } }
			};
			public static Trap ShieldPowerup = new Trap()
			{
				Name = "Shield Powerup",
				Id = new byte[] { 0xB2, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F552F, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1") },
				TextureOffset = 0x1864F99,
				IconOffset = 0x2716F69,
				IconIds = new List<byte[]>() { new byte[] { 0x72 }, new byte[] { 0x73 }, new byte[] { 0x74 }, new byte[] { 0x75 } }
			};
			public static Trap SpeedPad = new Trap()
			{
				Name = "Speed Pad",
				Id = new byte[] { 0xB4, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5E0D, "(1.50 + (src.TrapStrength * src.IncreasePerTier) + src.mExtraBoost)") },
				TextureOffset = 0x186CB15,
				IconOffset = 0x2716FAD,
				IconIds = new List<byte[]>() { new byte[] { 0x86 }, new byte[] { 0x87 }, new byte[] { 0x88 }, new byte[] { 0x89 } }
			};
			public static Trap SpikeWall = new Trap()
			{
				Name = "Spike Wall",
				Id = new byte[] { 0xB8, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F608F, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x186DE77,
				IconOffset = 0x2717035,
				IconIds = new List<byte[]>() { new byte[] { 0xAA }, new byte[] { 0xAB }, new byte[] { 0xAC }, new byte[] { 0xAD } }
			};
			public static Trap SteamVent = new Trap()
			{
				Name = "Steam Vent",
				Id = new byte[] { 0xBA, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F62C6, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
				TextureOffset = 0x186E503,
				IconOffset = 0x2717079,
				IconIds = new List<byte[]>() { new byte[] { 0x8A }, new byte[] { 0x8B }, new byte[] { 0x8C }, new byte[] { 0x8D } }
			};
			public static Trap SwingingMace = new Trap()
			{
				Name = "Swinging Mace",
				Id = new byte[] { 0xBC, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F648C, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x186F027,
				IconOffset = 0x27170BD,
				IconIds = new List<byte[]>() { new byte[] { 0x8E }, new byte[] { 0x8F }, new byte[] { 0x90 }, new byte[] { 0x91 } }
			};
			public static Trap TarTrap = new Trap()
			{
				Name = "Tar Trap",
				Id = new byte[] { 0xBE, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6583, "(0.60 - (src.TrapStrength * src.IncreasePerTier))") },
				TextureOffset = 0x186F6A0,
				IconOffset = 0x2717101,
				IconIds = new List<byte[]>() { new byte[] { 0x92 }, new byte[] { 0x93 }, new byte[] { 0x94 }, new byte[] { 0x95 } }
			};
			public static Trap ViscousTar = new Trap()
			{
				Name = "Viscous Tar",
				Id = new byte[] { 0xC0, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F65FD, "(0.60 - (src.TrapStrength * src.IncreasePerTier))") },
				TextureOffset = 0x186FD29,
				IconOffset = 0x2717145,
				IconIds = new List<byte[]>() { new byte[] { 0x96 }, new byte[] { 0x97 }, new byte[] { 0x98 }, new byte[] { 0x99 } }
			};
			public static Trap ShockZapper = new Trap()
			{
				Name = "Shock Zapper",
				Id = new byte[] { 0xC2, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F66D0, "400.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18703C3,
				IconOffset = 0x2717189,
				IconIds = new List<byte[]>() { new byte[] { 0x82 }, new byte[] { 0x83 }, new byte[] { 0x84 }, new byte[] { 0x85 } }
			};
			public static Trap BGHShockZapper = new Trap()
			{
				Name = "BGH Zapper",
				Id = new byte[] { 0xC4, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6826, "MIN(((0.08 * tgt.HealthMax) + 40 * (src.IncreasePerTier ^ src.TrapStrength)),1200)") },
				TextureOffset = 0x1870C22,
				IconOffset = 0x27171CD,
				IconIds = new List<byte[]>() { new byte[] { 0x7E }, new byte[] { 0x7F }, new byte[] { 0x80 }, new byte[] { 0x81 } }
			};
			public static Trap TripWire = new Trap()
			{
				Name = "Trip Wire",
				Id = new byte[] { 0xC6, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = null,
				TextureOffset = 0x1877088,
				IconOffset = 0x2717211,
				IconIds = new List<byte[]>() { new byte[] { 0x9E }, new byte[] { 0x9F }, new byte[] { 0xA0 }, new byte[] { 0xA1 } },
				CoinCostOffset = 0x161AFD4,
				CoinCost = 1000,
				IncreasePerTier = 0.05F
			};
			public static Trap WallBlades = new Trap()
			{
				Name = "Wall Blades",
				Id = new byte[] { 0xC8, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6AE5, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18778BD,
				IconOffset = 0x2717255,
				IconIds = new List<byte[]>() { new byte[] { 0xA6 }, new byte[] { 0xA7 }, new byte[] { 0xA8 }, new byte[] { 0xA9 } }
			};
			public static Trap WallCharger = new Trap()
			{
				Name = "Wall Charger",
				Id = new byte[] { 0xCA, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6C35, "255.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
				TextureOffset = 0x18785DB,
				IconOffset = 0x2717299,
				IconIds = new List<byte[]>() { new byte[] { 0x9A }, new byte[] { 0x9B }, new byte[] { 0x9C }, new byte[] { 0x9D } }
			};
			public static Trap WebSpinner = new Trap()
			{
				Name = "Web Spinner",
				Id = new byte[] { 0xCC, 0xC4, 0x00, 0x00 },
				StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6D8B, "(0.75 - (src.TrapStrength * src.IncreasePerTier))") },
				TextureOffset = 0x1878C5E,
				IconOffset = 0x27172DD,
				IconIds = new List<byte[]>() { new byte[] { 0xAE }, new byte[] { 0xAF }, new byte[] { 0xB0 }, new byte[] { 0xB1 } }
			};
        }

        //Traps (Name, Hex)
        // Hex representation in SpitfireGame.upk
        public static Dictionary<string, Trap> Traps = new Dictionary<string, Trap>
        {
            //{ "Acid Sprayer", null },
            { "Arcane Bowling Ball", Trap.ArcaneBowlingBall },
            { "Arcane Phaser", Trap.ArcanePhaser },
            { "Arrow Wall", Trap.ArrowWall },
            { "BGH Arrow Wall", Trap.BGHArrowWall },
            { "Ceiling Ballista", Trap.CeilingBallista },
            { "Dragons Lance", Trap.DragonsLance },
            { "BGH Ceiling Ballista", Trap.BGHCeilingBallista },
            { "Barricade", Trap.Barricade },
            { "Great Wall Barricade", Trap.GreatWallBarricade },
            { "Boom Barrel", Trap.BoomBarrel },
            { "Boom Barrel Roller", Trap.BoomBarrelRoller },
            { "Boulder Chute", Trap.BoulderChute },
            { "Icicle Impaler", Trap.IcicleImpaler },
            { "Brimstone", Trap.Brimstone },
            { "Coin Forge", Trap.CoinForge },
            { "Cursed Ground", Trap.CursedGround },
            { "Decoy", Trap.Decoy },
            { "Spitfire Wall", Trap.SpitfireWall },
            { "Fire Cracker", Trap.FireCracker },
            { "Flip Trap", Trap.FlipTrap },
            { "Floor Scorcher", Trap.FloorScorcher },
            { "Temple Alarm Gong", Trap.TempleAlarmGong },
            { "Grinder", Trap.Grinder },
            { "Quarter Pounder", Trap.QuarterPounder },
            { "Haymaker", Trap.Haymaker },
            { "Healing Well", Trap.HealingWell },
            { "Ice Shard", Trap.IceShard },
            { "Ice Vent", Trap.IceVent },
            { "Lightning Rod", Trap.LightningRod },
            { "Mana Well", Trap.ManaWell },
            { "Summoner Trap", Trap.SummonerTrap },
            { "Naphtha Sprayer", Trap.NaphthaSprayer },
            { "Overload Trap", Trap.OverloadTrap },
            { "Powerup Damage", Trap.PowerupDamage },
            { "Pounder", Trap.Pounder },
            { "Concussive Pounder", Trap.ConcussivePounder },
            { "Power Generator", Trap.PowerGenerator },
            //{ "Projectile Shield", null },
            { "Push Trap", Trap.PushTrap },
            { "Saw Of Arctos", Trap.SawOfArctos },
            { "Shield Powerup", Trap.ShieldPowerup },
            { "Speed Pad", Trap.SpeedPad },
            { "Floor Spikes", Trap.FloorSpikes },
            { "Spike Wall", Trap.SpikeWall },
            { "Steam Vent", Trap.SteamVent },
            { "Swinging Mace", Trap.SwingingMace },
            { "Tar Trap", Trap.TarTrap },
            { "Viscous Tar", Trap.ViscousTar },
            { "Shock Zapper", Trap.ShockZapper },
            { "BGH Shock Zapper", Trap.BGHShockZapper },
            { "Trip Wire", Trap.TripWire},
            { "Wall Blades", Trap.WallBlades },
            { "Wall Charger", Trap.WallCharger },
            { "Web Spinner", Trap.WebSpinner }
        };

        public static List<byte[]> TrapTextureIds = new List<byte[]>() {    new byte[] { 0x31 },
                                                                            new byte[] { 0x32 }, new byte[] { 0x32 },
                                                                            new byte[] { 0x33 }, new byte[] { 0x33 },
                                                                            new byte[] { 0x34 }, new byte[] { 0x34 } };

		        
        // Gear   (Name, Hex)
        // Hex representation in SpitfireGame.upk
        public static Dictionary<string, byte[]> Gear = new Dictionary<string, byte[]>
        {
            { "Freedom Trinket", new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
            { "Greater Freedom Trinket", new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
            { "Mending Root", new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
            { "Hobgoblin Charm", new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
            { "Ring of Last Stand", new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
            { "Mage's Picnic", new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
            { "Mage's Clover", new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
            { "Gnomish Repair Kit", new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
            { "Teleportation Ring", new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
            { "Arcane Bubble Blower", new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
            { "Fire Wall Bracers", new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
            { "Ice Amulet", new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
            { "Ring of Storms", new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
            { "Lightning Ring", new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
            { "AntiTrap Vambrace", new byte[] { 0x02, 0xC4, 0x00, 0x00 } }
        };

        // Guardians (Name (Hex String code, Length))
        // Hex string representation in SpitfireGame.upk
        public static Dictionary<string, Tuple<byte[], byte>> Guardians = new Dictionary<string, Tuple<byte[], byte>>
        {
            { "Bartender Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x62, 0x61, 0x72, 0x6d, 0x61, 0x69, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x42, 0x61, 0x72, 0x6d, 0x61, 0x69, 0x64, 0x00 }, 47
                )
            },
            { "Blacksmith Guardian",new Tuple<byte[], byte>
                (
                     new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x42, 0x65, 0x61, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x42, 0x65, 0x61, 0x72, 0x00 }, 33
                )
            },
            { "Cook Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x6f, 0x6f, 0x6b, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x43, 0x6f, 0x6f, 0x6b, 0x00 }, 33
                )
            },
            { "Deckhand Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x64, 0x65, 0x63, 0x6b, 0x68, 0x61, 0x6e, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x44, 0x65, 0x63, 0x6b, 0x68, 0x61, 0x6e, 0x64, 0x00 }, 49
                )
            },
            { "Dragon Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x44, 0x72, 0x61, 0x67, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x44, 0x72, 0x61, 0x67, 0x6f, 0x6e, 0x00 }, 37
                )
            },
            { "Friar Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x6f, 0x72, 0x63, 0x70, 0x72, 0x69, 0x65, 0x73, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4f, 0x72, 0x63, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x00 }, 51
                )
            },
            { "Headhunter Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x74, 0x72, 0x6f, 0x6c, 0x6c, 0x63, 0x6f, 0x6d, 0x6d, 0x61, 0x6e, 0x64, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x54, 0x72, 0x6f, 0x6c, 0x6c, 0x43, 0x6f, 0x6d, 0x6d, 0x61, 0x6e, 0x64, 0x65, 0x72, 0x00 }, 61
                )
            },
            { "Jade Empire", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x63, 0x68, 0x69, 0x6e, 0x65, 0x73, 0x65, 0x6a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x68, 0x69, 0x6e, 0x65, 0x73, 0x65, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x00 }, 59
                )
            },
            { "Jailer Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x00 }, 45
                )
            },
            { "Lion Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4c, 0x69, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x4c, 0x69, 0x6f, 0x6e, 0x00 }, 33
                )
            },
            { "Moon Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4d, 0x6f, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x4d, 0x6f, 0x6f, 0x6e, 0x00 }, 33
                )
            },
            { "Priest Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x00 }, 45
                )
            },
            { "Quartermaster Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x63, 0x61, 0x70, 0x74, 0x61, 0x69, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x61, 0x70, 0x74, 0x61, 0x69, 0x6e, 0x00 }, 47
                )
            },
            { "Ranch Hand Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x73, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x6d, 0x69, 0x6e, 0x6f, 0x74, 0x61, 0x75, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x4d, 0x69, 0x6e, 0x6f, 0x74, 0x61, 0x75, 0x72, 0x00 }, 69
                )
            },
            { "Rumrudder Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x63, 0x75, 0x72, 0x76, 0x79, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x63, 0x75, 0x72, 0x76, 0x79, 0x00 }, 45
                )
            },
            { "Serpent Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x52, 0x61, 0x7a, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x52, 0x61, 0x7a, 0x65, 0x72, 0x00 }, 35
                )
            },
            { "Stablehand Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x73, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x00 }, 53
                )
            },
            { "Sun Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x75, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x53, 0x75, 0x6e, 0x00 }, 31
                )
            },
            { "WeaponWright Guardian", new Tuple<byte[], byte>
                (
                    new byte [] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x77, 0x65, 0x61, 0x70, 0x6f, 0x6e, 0x77, 0x72, 0x69, 0x67, 0x68, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x57, 0x65, 0x61, 0x70, 0x6f, 0x6e, 0x77, 0x72, 0x69, 0x67, 0x68, 0x74, 0x00 }, 57
                )
            }
        };
    }
}
