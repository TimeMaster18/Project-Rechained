using System.Collections.Generic;
using static SingleplayerLauncher.Names.Hero;
using static SingleplayerLauncher.Names.Trap;

namespace SingleplayerLauncher.Model
{
    public class Trap : SlotItem
    {
        public static readonly List<byte[]> DEFAULT_TRAP_TEXTURE_IDS = new List<byte[]>() {    new byte[] { 0x31 },
                                                                            new byte[] { 0x32 }, new byte[] { 0x32 },
                                                                            new byte[] { 0x33 }, new byte[] { 0x33 },
                                                                            new byte[] { 0x34 }, new byte[] { 0x34 } };

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
        public List<StatModifierExpression> StatModifierExpressions { get; private set; }
        public int[] TextureOffsets { get; private set; } // in SpitfireUPK
        public List<byte[]> TextureIds { get; private set; } = DEFAULT_TRAP_TEXTURE_IDS; // in SpitfireUPK
        public int IconOffset { get; private set; } // in SpitfireUPK
        public List<byte[]> IconIds { get; private set; } // ids linking the trap icons
        public float IncreasePerTier { get; private set; }
        public int CoinCostOffset { get; private set; } // in SpitfireUPK
        public int CoinCost { get; private set; }

        // private constructor
        Trap() { }

        // static members
        public static Trap ArcaneBowlingBall = new Trap()
        {
            Name = ARCANE_BOWLING_BALL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x88, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x1C, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x5D, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x46, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x67, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x2A, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xEA, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x06, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x24, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F218B, "120.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x183E781 },
            IconOffset = 0x27164C7,
            IconIds = new List<byte[]>() { new byte[] { 0xA2 }, new byte[] { 0xA3 }, new byte[] { 0xA4 }, new byte[] { 0xA5 } }
        };
        public static Trap ArcanePhaser = new Trap()
        {
            Name = ARCANE_PHASER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x87, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x1B, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x5C, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x45, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x66, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x29, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE9, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x05, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x23, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F22D9, "110.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x183EF16 },
            IconOffset = 0x271650B,
            IconIds = new List<byte[]>() { new byte[] { 0xE2 }, new byte[] { 0xE3 }, new byte[] { 0xE4 }, new byte[] { 0xE5 } }
        };
        public static Trap ArrowWall = new Trap()
        {
            Name = ARROW_WALL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x75, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x1A, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x5B, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x44, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x65, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x28, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE8, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x04, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x22, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2427, "30.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x183F5D5 },
            IconOffset = 0x271654F,
            IconIds = new List<byte[]>() { new byte[] { 0xEA }, new byte[] { 0xEB }, new byte[] { 0xEC }, new byte[] { 0xED } }
        };
        public static Trap BGHArrowWall = new Trap()
        {
            Name = BGH_ARROW_WALL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x86, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x19, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x5A, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x43, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x64, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x27, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE7, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x03, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x21, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2594, "18 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x183FD96 },
            IconOffset = 0x2716593,
            IconIds = new List<byte[]>() { new byte[] { 0xE6 }, new byte[] { 0xE7 }, new byte[] { 0xE8 }, new byte[] { 0xE9 } }
        };
        public static Trap CeilingBallista = new Trap()
        {
            Name = CEILING_BALLISTA,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x85, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x18, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x59, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x42, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x63, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x26, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE6, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x02, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x20, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F26E7, "185.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18423EB },
            IconOffset = 0x27165D7,
            IconIds = new List<byte[]>() { new byte[] { 0xF2 }, new byte[] { 0xF3 }, new byte[] { 0xF4 }, new byte[] { 0xF5 } }
        };
        public static Trap DragonsLance = new Trap()
        {
            Name = DRAGONS_LANCE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x84, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x17, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x58, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x41, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x62, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x25, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE5, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x01, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1F, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2837, "100.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1843290 },
            IconOffset = 0x271661B,
            IconIds = new List<byte[]>() { new byte[] { 0xEE }, new byte[] { 0xEF }, new byte[] { 0xF0 }, new byte[] { 0xF1 } }
        };
        public static Trap BGHCeilingBallista = new Trap()
        {
            Name = BGH_CEILING_BALLISTA,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x83, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x16, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x57, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x40, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x61, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x24, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE4, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0x00, 0xFE, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1E, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F29A3, "38 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1844A3E },
            IconOffset = 0x271665F,
            IconIds = new List<byte[]>() { new byte[] { 0x2A }, new byte[] { 0x2B }, new byte[] { 0x2C }, new byte[] { 0x2D } }
        };
        public static Trap Barricade = new Trap()
        {
            Name = BARRICADE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x82, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x15, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x56, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3F, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x60, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x23, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE3, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFF, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1D, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2A9E, "(src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1846B9F },
            IconOffset = 0x27166A3,
            IconIds = new List<byte[]>() { new byte[] { 0xFA }, new byte[] { 0xFB }, new byte[] { 0xFC }, new byte[] { 0xFD } }
        };
        public static Trap GreatWallBarricade = new Trap()
        {
            Name = GREAT_WALL_BARRICADE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x81, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x14, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x55, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3E, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5F, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x22, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE2, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFE, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1C, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2A9E, "(src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1847B72 },
            IconOffset = 0x27166E7,
            IconIds = new List<byte[]>() { new byte[] { 0xF6 }, new byte[] { 0xF7 }, new byte[] { 0xF8 }, new byte[] { 0xF9 } }
        };
        public static Trap BoomBarrel = new Trap()
        {
            Name = BOOM_BARREL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x80, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x13, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x54, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3D, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5E, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x21, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE1, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFD, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1B, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2B1B, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184820A },
            IconOffset = 0x271672B,
            IconIds = new List<byte[]>() { new byte[] { 0x02 }, new byte[] { 0x03 }, new byte[] { 0x04 }, new byte[] { 0x05 } }
        };
        public static Trap BoomBarrelRoller = new Trap()
        {
            Name = BOOM_BARREL_ROLLER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7F, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x12, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x53, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3C, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5D, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x20, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xE0, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFC, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x1A, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2CCB, "100.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184A0FC },
            IconOffset = 0x271676F,
            IconIds = new List<byte[]>() { new byte[] { 0xFE, 0xCA }, new byte[] { 0xFF, 0xCA }, new byte[] { 0x00, 0xCB }, new byte[] { 0x01, 0xCB } }
        };
        public static Trap BoulderChute = new Trap()
        {
            Name = BOULDER_CHUTE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7E, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x11, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x52, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3B, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5C, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1F, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDF, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFB, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x19, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F2E67, "200.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184B628 },
            IconOffset = 0x27167CC,
            IconIds = new List<byte[]>() { new byte[] { 0x06 }, new byte[] { 0x07 }, new byte[] { 0x08 }, new byte[] { 0x09 } }
        };
        public static Trap IcicleImpaler = new Trap()
        {
            Name = ICICLE_IMPALER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7D, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x10, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x51, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x3A, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5B, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1E, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDE, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xFA, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x18, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3003, "200.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184CE4A },
            IconOffset = 0x2716829,
            IconIds = new List<byte[]>() { new byte[] { 0x3E }, new byte[] { 0x3F }, new byte[] { 0x40 }, new byte[] { 0x41 } }
        };
        public static Trap Brimstone = new Trap()
        {
            Name = BRIMSTONE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x74, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0F, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x50, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x39, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x5A, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1D, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDD, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF9, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x17, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3143, "30.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184D529 },
            IconOffset = 0x271686D,
            IconIds = new List<byte[]>() { new byte[] { 0x0A }, new byte[] { 0x0B }, new byte[] { 0x0C }, new byte[] { 0x0D } }
        };
        public static Trap CoinForge = new Trap()
        {
            Name = COIN_FORGE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7C, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0E, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4F, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x38, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x59, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1C, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDC, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF8, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x16, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3238, "1.64f + (src.IncreasePerTier * src.TrapStrength)") },
            TextureOffsets = new int[] { 0x184DD4C },
            IconOffset = 0x27168B1,
            IconIds = new List<byte[]>() { new byte[] { 0x12 }, new byte[] { 0x13 }, new byte[] { 0x14 }, new byte[] { 0x15 } }
        };
        public static Trap CursedGround = new Trap()
        {
            Name = CURSED_GROUND,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7B, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0D, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4E, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x37, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x58, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1B, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDB, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF7, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x15, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() {   new StatModifierExpression(0x28F33C1, "14.0 * (src.IncreasePerTier ^ src.TrapStrength)"),
                                                                                 new StatModifierExpression(0x28F3349, "27.0 * (src.IncreasePerTier ^ src.TrapStrength)"),
                                                                                 new StatModifierExpression(0x28F32D1, "95.0 * (src.IncreasePerTier ^ src.TrapStrength)")},
            TextureOffsets = new int[] { 0x184F600 },
            IconOffset = 0x27168F5,
            IconIds = new List<byte[]>() { new byte[] { 0x16 }, new byte[] { 0x17 }, new byte[] { 0x18 }, new byte[] { 0x19 }, }
        };
        public static Trap Decoy = new Trap()
        {
            Name = DECOY,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x7A, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0C, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4D, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x36, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x57, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x1A, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xDA, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF6, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x14, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3459, "(150.0 + src.DamageIncreaseFromLvl) * ((1 + src.IncreasePerTier) ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1850BD9, 0x1850C36 },
            IconIds = null
        };
        public static Trap SpitfireWall = new Trap()
        {
            Name = SPITFIRE_WALL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x79, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0B, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4C, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x35, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x56, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x19, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD9, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF5, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x13, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3774, "15.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1851A47 },
            IconOffset = 0x2716965,
            IconIds = new List<byte[]>() { new byte[] { 0x1A }, new byte[] { 0x1B }, new byte[] { 0x1C }, new byte[] { 0x1D } }
        };
        public static Trap FireCracker = new Trap()
        {
            Name = FIRE_CRACKER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x78, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x0A, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4B, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x34, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x55, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x18, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD8, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF4, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x12, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F38B2, "14 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185214F },
            IconOffset = 0x27169A9,
            IconIds = new List<byte[]>() { new byte[] { 0x0E }, new byte[] { 0x0F }, new byte[] { 0x10 }, new byte[] { 0x11 } }
        };
        public static Trap FlipTrap = new Trap()
        {
            Name = FLIP_TRAP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x77, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x09, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x4A, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x33, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x54, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x17, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD7, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF3, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x11, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F51AD, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x185290F },
            IconOffset = 0x27169ED,
            IconIds = new List<byte[]>() { new byte[] { 0x1E }, new byte[] { 0x1F }, new byte[] { 0x20 }, new byte[] { 0x21 } }
        };
        public static Trap FloorScorcher = new Trap()
        {
            Name = FLOOR_SCORCHER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x76, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x08, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x49, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x32, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x53, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x16, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD6, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF2, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x10, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3D6B, "31.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185330B },
            IconOffset = 0x2716A31,
            IconIds = new List<byte[]>() { new byte[] { 0x22 }, new byte[] { 0x23 }, new byte[] { 0x24 }, new byte[] { 0x25 } }
        };
        public static Trap TempleAlarmGong = new Trap()
        {
            Name = TEMPLE_ALARM_GONG,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x75, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x07, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x48, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x31, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x52, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x15, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD5, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF1, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0F, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = null,
            TextureOffsets = new int[] { 0x185399C },
            IconOffset = 0x2716A75,
            IconIds = new List<byte[]>() { new byte[] { 0x2E }, new byte[] { 0x2F }, new byte[] { 0x30 }, new byte[] { 0x31 } },
            CoinCostOffset = 0x1617D7E,
            CoinCost = 1000,
            IncreasePerTier = 0.15F
        };
        public static Trap Grinder = new Trap()
        {
            Name = GRINDER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x74, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x06, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x47, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x30, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x51, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x14, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD4, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xF0, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0E, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F3F5E, "54.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18561F1 },
            IconOffset = 0x2716AB9,
            IconIds = new List<byte[]>() { new byte[] { 0x32 }, new byte[] { 0x33 }, new byte[] { 0x34 }, new byte[] { 0x35 } }
        };
        public static Trap QuarterPounder = new Trap()
        {
            Name = QUARTER_POUNDER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x73, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x05, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x46, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2F, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x50, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x13, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD3, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xEF, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0D, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F40B0, "525.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18569A5 },
            IconOffset = 0x2716AFD,
            IconIds = new List<byte[]>() { new byte[] { 0x5E }, new byte[] { 0x5F }, new byte[] { 0x60 }, new byte[] { 0x61 } }
        };
        public static Trap Haymaker = new Trap()
        {
            Name = HAYMAKER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x72, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x04, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x45, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2E, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4F, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x12, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD2, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xEE, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0C, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F41A7, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x1858016 },
            IconOffset = 0x2716B41,
            IconIds = new List<byte[]>() { new byte[] { 0x36 }, new byte[] { 0x37 }, new byte[] { 0x38 }, new byte[] { 0x39 } }
        };
        public static Trap HealingWell = new Trap()
        {
            Name = HEALING_WELL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x71, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x03, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x44, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2D, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4E, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x11, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD1, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xED, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0B, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4307, "(0.09 + (src.TrapStrength * 0.024))*(1 + src.mExtraBoost)*tgt.HealthMax") },
            TextureOffsets = new int[] { 0x18586EC },
            IconOffset = 0x2716B85,
            IconIds = new List<byte[]>() { new byte[] { 0x3A }, new byte[] { 0x3B }, new byte[] { 0x3C }, new byte[] { 0x3D } }
        };
        public static Trap IceShard = new Trap()
        {
            Name = ICE_SHARD,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x70, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x02, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x43, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2C, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4D, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x10, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xD0, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xEC, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x0A, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F458D, "130.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185A670 },
            IconOffset = 0x2716BC9,
            IconIds = new List<byte[]>() { new byte[] { 0x42 }, new byte[] { 0x43 }, new byte[] { 0x44 }, new byte[] { 0x45 } }
        };
        public static Trap IceVent = new Trap()
        {
            Name = ICE_VENT,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6F, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x01, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x42, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2B, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4C, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0F, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCF, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xEB, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x09, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F46CD, "25.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185AD42 },
            IconOffset = 0x2716C0D,
            IconIds = new List<byte[]>() { new byte[] { 0x46 }, new byte[] { 0x47 }, new byte[] { 0x48 }, new byte[] { 0x49 } }
        };
        public static Trap LightningRod = new Trap()
        {
            Name = LIGHTNING_ROD,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6E, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x00, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x41, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x2A, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4B, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0E, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCE, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xEA, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x08, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F481C, "85.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185B5AB },
            IconOffset = 0x2716C51,
            IconIds = new List<byte[]>() { new byte[] { 0x4A }, new byte[] { 0x4B }, new byte[] { 0x4C }, new byte[] { 0x4D } }
        };
        public static Trap ManaWell = new Trap()
        {
            Name = MANA_WELL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6D, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFF, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x40, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x29, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x4A, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0D, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCD, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE9, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x07, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4971, "(0.09 + (src.TrapStrength * 0.024))*(1 + src.mExtraBoost)*tgt.ManaMax") },
            TextureOffsets = new int[] { 0x185BC7A },
            IconOffset = 0x2716C95,
            IconIds = new List<byte[]>() { new byte[] { 0x4E }, new byte[] { 0x4F }, new byte[] { 0x50 }, new byte[] { 0x51 } }
        };
        public static Trap SummonerTrap = new Trap()
        {
            Name = SUMMONER_TRAP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6C, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFE, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3F, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x28, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x49, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0C, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCC, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE8, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x06, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() {   new StatModifierExpression(0x28F4B7F, "src.HealthMax * (src.IncreasePerTier ^ src.TrapStrength)"),
                                                                                 new StatModifierExpression(0x28F4AE6, "160.0 * (src.IncreasePerTier ^ src.TrapStrength)")},
            TextureOffsets = new int[] { 0x185D7D4 },
            IconOffset = 0x2716CD9,
            IconIds = new List<byte[]>() { new byte[] { 0x52 }, new byte[] { 0x53 }, new byte[] { 0x54 }, new byte[] { 0x55 } }
        };
        public static Trap NaphthaSprayer = new Trap()
        {
            Name = NAPHTHA_SPRAYER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6B, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFD, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3E, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x27, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x48, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0B, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCB, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE7, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x05, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4C94, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x185E8BB },
            IconOffset = 0x2716D1D,
            IconIds = new List<byte[]>() { new byte[] { 0x56 }, new byte[] { 0x57 }, new byte[] { 0x58 }, new byte[] { 0x59 } }
        };
        public static Trap OverloadTrap = new Trap()
        {
            Name = OVERLOAD_TRAP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x6A, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFC, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3D, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x26, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x47, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x0A, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xCA, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE6, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x04, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4D75, "140.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x185F21D },
            IconOffset = 0x2716D61,
            IconIds = new List<byte[]>() { new byte[] { 0x5A }, new byte[] { 0x5B }, new byte[] { 0x5C }, new byte[] { 0x5D } }
        };
        public static Trap PowerupDamage = new Trap()
        {
            Name = POWERUP_DAMAGE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x69, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFB, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3C, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x25, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x46, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x09, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC9, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE5, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x03, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4E6C, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x185F9CC },
            IconOffset = 0x2716DA5,
            IconIds = new List<byte[]>() { new byte[] { 0x6E }, new byte[] { 0x6F }, new byte[] { 0x70 }, new byte[] { 0x71 } }
        };
        public static Trap Pounder = new Trap()
        {
            Name = POUNDER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x68, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xFA, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3B, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x24, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x45, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x08, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC8, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE4, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x02, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F4FB4, "145.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x1860151 },
            IconOffset = 0x2716DE9,
            IconIds = new List<byte[]>() { new byte[] { 0x66 }, new byte[] { 0x67 }, new byte[] { 0x68 }, new byte[] { 0x69 } }
        };
        public static Trap ConcussivePounder = new Trap()
        {
            Name = CONCUSSIVE_POUNDER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x67, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF9, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x3A, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x23, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x44, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x07, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC7, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE3, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x01, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F50AB, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x18607F9 },
            IconOffset = 0x2716E2D,
            IconIds = new List<byte[]>() { new byte[] { 0x62 }, new byte[] { 0x63 }, new byte[] { 0x64 }, new byte[] { 0x65 } }
        };
        public static Trap PowerGenerator = new Trap()
        {
            Name = POWER_GENERATOR,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x66, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF8, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x39, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x22, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x43, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x06, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC6, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE2, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0x00, 0xFE, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5133, "25 * (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x186225E },
            IconOffset = 0x2716E71,
            IconIds = new List<byte[]>() { new byte[] { 0x6A }, new byte[] { 0x6B }, new byte[] { 0x6C }, new byte[] { 0x6D } }
        };
        public static Trap PushTrap = new Trap()
        {
            Name = PUSH_TRAP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x73, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF6, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x37, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x20, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x41, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x04, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC4, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xE0, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xFE, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F51AD, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x186337A },
            IconOffset = 0x2716EE1,
            IconIds = new List<byte[]>() { new byte[] { 0x76 }, new byte[] { 0x77 }, new byte[] { 0x78 }, new byte[] { 0x79 } }
        };
        public static Trap SawOfArctos = new Trap()
        {
            Name = SAW_OF_ARCTOS,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x64, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF5, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x36, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1F, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x40, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x03, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC3, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDF, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xFD, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F543D, "190 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18646E0 },
            IconOffset = 0x2716F25,
            IconIds = new List<byte[]>() { new byte[] { 0x7A }, new byte[] { 0x7B }, new byte[] { 0x7C }, new byte[] { 0x7D } }
        };
        public static Trap ShieldPowerup = new Trap()
        {
            Name = SHIELD_POWERUP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x63, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF4, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x35, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1E, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3F, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x02, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC2, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDE, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xFC, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F552F, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1") },
            TextureOffsets = new int[] { 0x1864F99 },
            IconOffset = 0x2716F69,
            IconIds = new List<byte[]>() { new byte[] { 0x72 }, new byte[] { 0x73 }, new byte[] { 0x74 }, new byte[] { 0x75 } }
        };
        public static Trap SpeedPad = new Trap()
        {
            Name = SPEED_PAD,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x62, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF3, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x34, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1D, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3E, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x01, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC1, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDD, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xFB, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5E0D, "(1.50 + (src.TrapStrength * src.IncreasePerTier) + src.mExtraBoost)") },
            TextureOffsets = new int[] { 0x186CB15 },
            IconOffset = 0x2716FAD,
            IconIds = new List<byte[]>() { new byte[] { 0x86 }, new byte[] { 0x87 }, new byte[] { 0x88 }, new byte[] { 0x89 } }
        };
        public static Trap FloorSpikes = new Trap()
        {
            Name = FLOOR_SPIKES,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x61, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF2, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x33, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1C, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3D, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0x00, 0xFD, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xC0, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDC, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xFA, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F5F98, "160.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x186D798 },
            IconOffset = 0x2716FF1,
            IconIds = new List<byte[]>() { new byte[] { 0x26 }, new byte[] { 0x27 }, new byte[] { 0x28 }, new byte[] { 0x29 } }
        };
        public static Trap SpikeWall = new Trap()
        {
            Name = SPIKE_WALL,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x60, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF1, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x32, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1B, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3C, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFF, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBF, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDB, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF9, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F608F, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x186DE77 },
            IconOffset = 0x2717035,
            IconIds = new List<byte[]>() { new byte[] { 0xAA }, new byte[] { 0xAB }, new byte[] { 0xAC }, new byte[] { 0xAD } }
        };
        public static Trap SteamVent = new Trap()
        {
            Name = STEAM_VENT,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5F, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xF0, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x31, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x1A, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3B, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFE, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBE, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xDA, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF8, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F62C6, "src.BaseCooldown / (src.TrapStrength * src.IncreasePerTier + 1)") },
            TextureOffsets = new int[] { 0x186E503 },
            IconOffset = 0x2717079,
            IconIds = new List<byte[]>() { new byte[] { 0x8A }, new byte[] { 0x8B }, new byte[] { 0x8C }, new byte[] { 0x8D } }
        };
        public static Trap SwingingMace = new Trap()
        {
            Name = SWINGING_MACE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5E, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xEF, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x30, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x19, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x3A, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFD, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBD, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD9, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF7, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F648C, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x186F027 },
            IconOffset = 0x27170BD,
            IconIds = new List<byte[]>() { new byte[] { 0x8E }, new byte[] { 0x8F }, new byte[] { 0x90 }, new byte[] { 0x91 } }
        };
        public static Trap TarTrap = new Trap()
        {
            Name = TAR_TRAP,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5D, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xEE, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2F, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x18, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x39, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFC, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBC, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD8, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF6, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6583, "(0.60 - (src.TrapStrength * src.IncreasePerTier))") },
            TextureOffsets = new int[] { 0x186F6A0 },
            IconOffset = 0x2717101,
            IconIds = new List<byte[]>() { new byte[] { 0x92 }, new byte[] { 0x93 }, new byte[] { 0x94 }, new byte[] { 0x95 } }
        };
        public static Trap ViscousTar = new Trap()
        {
            Name = VISCOUS_TAR,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5C, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xED, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2E, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x17, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x38, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFB, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBB, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD7, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF5, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F65FD, "(0.60 - (src.TrapStrength * src.IncreasePerTier))") },
            TextureOffsets = new int[] { 0x186FD29 },
            IconOffset = 0x2717145,
            IconIds = new List<byte[]>() { new byte[] { 0x96 }, new byte[] { 0x97 }, new byte[] { 0x98 }, new byte[] { 0x99 } }
        };
        public static Trap ShockZapper = new Trap()
        {
            Name = SHOCK_ZAPPER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x72, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xEC, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2D, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x16, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x37, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xFA, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xBA, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD6, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF4, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F66D0, "400.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18703C3 },
            IconOffset = 0x2717189,
            IconIds = new List<byte[]>() { new byte[] { 0x82 }, new byte[] { 0x83 }, new byte[] { 0x84 }, new byte[] { 0x85 } }
        };
        public static Trap BGHShockZapper = new Trap()
        {
            Name = BGH_SHOCK_ZAPPER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5B, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xEB, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2C, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x15, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x36, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xF9, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xB9, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD5, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF3, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6826, "MIN(((0.08 * tgt.HealthMax) + 40 * (src.IncreasePerTier ^ src.TrapStrength)),1200)") },
            TextureOffsets = new int[] { 0x1870C22, 0x1870C61 },
            IconOffset = 0x27171CD,
            IconIds = new List<byte[]>() { new byte[] { 0x7E }, new byte[] { 0x7F }, new byte[] { 0x80 }, new byte[] { 0x81 } }
        };
        public static Trap TripWire = new Trap()
        {
            Name = TRIP_WIRE,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x5A, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xEA, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2B, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x14, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x35, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xF8, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xB8, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD4, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF2, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = null,
            TextureOffsets = new int[] { 0x1877088 },
            IconOffset = 0x2717211,
            IconIds = new List<byte[]>() { new byte[] { 0x9E }, new byte[] { 0x9F }, new byte[] { 0xA0 }, new byte[] { 0xA1 } },
            CoinCostOffset = 0x161AFD4,
            CoinCost = 1000,
            IncreasePerTier = 0.05F
        };
        public static Trap WallBlades = new Trap()
        {
            Name = WALL_BLADES,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x59, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE9, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x2A, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x13, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x34, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xF7, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xB7, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD3, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF1, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6AE5, "250.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18778BD },
            IconOffset = 0x2717255,
            IconIds = new List<byte[]>() { new byte[] { 0xA6 }, new byte[] { 0xA7 }, new byte[] { 0xA8 }, new byte[] { 0xA9 } }
        };
        public static Trap WallCharger = new Trap()
        {
            Name = WALL_CHARGER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x58, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE8, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x29, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x12, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x33, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xF6, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xB6, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD2, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xF0, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6C35, "255.0 * (src.IncreasePerTier ^ src.TrapStrength)") },
            TextureOffsets = new int[] { 0x18785DB },
            IconOffset = 0x2717299,
            IconIds = new List<byte[]>() { new byte[] { 0x9A }, new byte[] { 0x9B }, new byte[] { 0x9C }, new byte[] { 0x9D } }
        };
        public static Trap WebSpinner = new Trap()
        {
            Name = WEB_SPINNER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xCC, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x57, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE7, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x28, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x11, 0xFD, 0xFF, 0xFF } },
                { CYGNUS, new byte[] { 0x32, 0xFD, 0xFF, 0xFF } },
                { DEADEYE, new byte[] { 0xF5, 0xFC, 0xFF, 0xFF } },
                { DOBBIN, new byte[] { 0xB5, 0xFD, 0xFF, 0xFF } },
                { MIDNIGHT, new byte[] { 0xD1, 0xFD, 0xFF, 0xFF } },
                { YI_LIN, new byte[] { 0xEF, 0xFD, 0xFF, 0xFF } },
            },
            StatModifierExpressions = new List<StatModifierExpression>() { new StatModifierExpression(0x28F6D8B, "(0.75 - (src.TrapStrength * src.IncreasePerTier))") },
            TextureOffsets = new int[] { 0x1878C34 },
            TextureIds = new List<byte[]>() {   new byte[] { 0x31, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x31, 0x5F, 0x4D, 0x61, 0x74, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x31, 0x00, 0x00, 0x00 },
                                                    new byte[] { 0x31, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x32, 0x5F, 0x4D, 0x61, 0x74, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x31, 0x00, 0x00, 0x00 },
                                                    new byte[] { 0x31, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x32, 0x5F, 0x4D, 0x61, 0x74, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x31, 0x00, 0x00, 0x00 },
                                                    new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x33, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x35, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF },
                                                    new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x33, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x35, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF },
                                                    new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x34, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x35, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF },
                                                    new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x4D, 0x61, 0x74, 0x2E, 0x4D, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x2E, 0x57, 0x65, 0x62, 0x53, 0x70, 0x72, 0x61, 0x79, 0x65, 0x72, 0x54, 0x69, 0x65, 0x72, 0x34, 0x5F, 0x49, 0x4E, 0x53, 0x54, 0x00, 0x35, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } },
            IconOffset = 0x27172DD,
            IconIds = new List<byte[]>() { new byte[] { 0xAE }, new byte[] { 0xAF }, new byte[] { 0xB0 }, new byte[] { 0xB1 } }
        };


        public static Dictionary<string, SlotItem> Traps = new Dictionary<string, SlotItem>
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
    }
}
