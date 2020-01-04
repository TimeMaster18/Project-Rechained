using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Resources
{
    class SpitfireGameUPK
    {

        public class HeroObject
        {
            public string Name;
            public int Offset; // index of offset from start of SpitfireGame.upk
            public int Size; // n of Bytes
            public HeroObject(string name, int offset, int size)
            {
                Name = name;
                Offset = offset;
                Size = size;
            }
        }


        public static readonly Dictionary<string, HeroObject> HeroObjects = new Dictionary<string, HeroObject>
        {
            {"Maximilian",  new HeroObject("Maximilian",    0x028AB495,     1542) },
            {"Bionka",      new HeroObject("Bionka",        0x028a992b,     1388) },
            {"Hogarth",     new HeroObject("Hogarth",       0x028a9e97,     1505) },
            {"Ivy",         new HeroObject("Ivy",           0x028aa478,     1372) },
            {"Smolder",     new HeroObject("Smolder",       0x028aa9d4,     1397) },
            {"Gabriella",   new HeroObject("Gabriella",     0x028aaf49,     1356) }
        };

        public static readonly byte[] HeroObjectLoadoutHeader = new byte[] {   0xC6, 0x2C, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00,
                                                                                0xC5, 0x07, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly byte[] HeroObjectGuardiansHeader = new byte[] { 0xBA, 0x2C, 0x00, 0x00,
                                                                                 0x00, 0x00, 0x00, 0x00,
                                                                                 0xC5, 0x07, 0x00, 0x00,
                                                                                 0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly int HeroObjectDefaultWaveClassesSectionLength = 64;
        public static readonly byte[] HeroObjectDefaultWaveClassesHeader = new byte[] {
                                                                                    0xF3, 0x2c, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly int HeroObjectHeroDamageTypeSectionLength = 40;
        public static readonly byte[] HeroObjectHeroDamageTypeHeader = new byte[] {
                                                                                    0x0E, 0x46, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly int HeroObjectStrategicRoleSectionLength = 40;
        public static readonly byte[] HeroObjectStrategicRoleHeader = new byte[] {
                                                                                    0x74, 0xA3, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly int HeroObjectDefaultRoleClassSectionLength = 28;
        public static readonly byte[] HeroObjectDefaultRoleClassHeader = new byte[] {
                                                                                    0xE4, 0x2C, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };


        public static readonly byte[] HeroObjectSkinPattern = new byte[] { 0x52, 0x1E, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x6B, 0x66, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x04, 0x00, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00
                                                                            };
        public static readonly byte[] HeroObjectWeaverTreeDefaultHeader = new byte[] { 0x00, 0xB4, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
        };
    }
}
