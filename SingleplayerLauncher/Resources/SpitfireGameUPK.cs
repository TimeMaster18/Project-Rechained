using System.Collections.Generic;

namespace SingleplayerLauncher.Resources
{
    internal class SpitfireGameUPK
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
            {"Maximilian",  new HeroObject("Maximilian",    0x28AB495,     1542) },
            {"Bionka",      new HeroObject("Bionka",        0x28a992b,     1388) },
            {"Hogarth",     new HeroObject("Hogarth",       0x28a9e97,     1505) },
            {"Ivy",         new HeroObject("Ivy",           0x28aa478,     1372) },
            {"Smolder",     new HeroObject("Smolder",       0x28aa9d4,     1397) },
            {"Gabriella",   new HeroObject("Gabriella",     0x28aaf49,     1356) }
        };

        // Archetype (Weapon/Skill set) (DefaultInventoryArchetypes(0)=RItem'PawnWeapon_Warmage.Weapon_Warmage')
        public static readonly int HeroObjectDefaultInventoryArchetypesSectionLength = 32;
        public static readonly byte[] HeroObjectDefaultInventoryArchetypesHeader = new byte[] { 0xC5, 0x2C, 0x00, 0x00,
                                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };

        // Loadout (DefaultInventoryClasses(0)=class'RItemTrinketHealing') 
        // Size is variable, full loadout makes it length = 
        public static readonly byte[] HeroObjectLoadoutHeader = new byte[] {    0xC6, 0x2C, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly byte[] HeroObjectLoadoutFieldType = new byte[] {     0xC5, 0x07, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        // Guardians (DefaultGuardianArchetypes(0)="Pawn_GuardianDragon.Placeable_Dragon")
        // Size is variable
        public static readonly byte[] HeroObjectGuardiansHeader = new byte[] {  0xBA, 0x2C, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly byte[] HeroObjectGuardiansFieldType = new byte[] {   0xC5, 0x07, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        // Hero Skin
        public static readonly int HeroObjectCurrentSkinClassSectionLength = 28;
        public static readonly byte[] HeroObjectCurrentSkinClassHeader = new byte[] {   0x52, 0x1E, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };
        // Hero Health
        public static readonly int HeroObjectHealthSectionLength = 28;
        public static readonly byte[] HeroObjectHealthHeader = new byte[] {   0x8D, 0x45, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };
        // Hero HealthMax
        public static readonly int HeroObjectHealthMaxSectionLength = 28;
        public static readonly byte[] HeroObjectHealthMaxHeader = new byte[] {   0x9E, 0x45, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };

        // Hero weaver tree (is after Inventory/Guardians)
        public static readonly int HeroObjectWeaverTreeDefaultSectionLength = 28;
        public static readonly byte[] HeroObjectWeaverTreeDefaultHeader = new byte[] {  0x00, 0xB4, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };

        // Default WaveClasses (only in Maximilian)
        public static readonly int HeroObjectDefaultWaveClassesSectionLength = 64;
        public static readonly byte[] HeroObjectDefaultWaveClassesHeader = new byte[] { 0xF3, 0x2c, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };
        public static readonly int HeroObjectHeroDamageTypeSectionLength = 40;
        public static readonly byte[] HeroObjectHeroDamageTypeHeader = new byte[] { 0x0E, 0x46, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };

        // Strategic Role, probably from siege
        public static readonly int HeroObjectStrategicRoleSectionLength = 40;
        public static readonly byte[] HeroObjectStrategicRoleHeader = new byte[] {  0x74, 0xA3, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        // Controls what role bots will pick in siege
        public static readonly int HeroObjectDefaultRoleClassSectionLength = 28;
        public static readonly byte[] HeroObjectDefaultRoleClassHeader = new byte[] {   0xE4, 0x2C, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };

        // EndGameDanceSegment
        public static readonly int HeroObjectEndGameDanceSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectEndGameDanceSegmentHeader = new byte[] {   0x78, 0x33, 0x00, 0x00,
                                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        // EndGameLockMovementSegment
        public static readonly int HeroObjectEndGameLockMovementSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectEndGameLockMovementSegmentHeader = new byte[] {    0x7E, 0x33, 0x00, 0x00,
                                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };
        // EndGameDefeatedSegment
        public static readonly int HeroObjectEndGameDefeatedSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectEndGameDefeatedSegmentHeader = new byte[] {    0x7C, 0x33, 0x00, 0x00,
                                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };


        // BeginStealthClientSegment
        public static readonly int HeroObjectBeginStealthClientSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectBeginStealthClientSegmentHeader = new byte[] {  0x5F, 0x0D, 0x00, 0x00,
                                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        // EndStealthClientSegment
        public static readonly int HeroObjectEndStealthClientSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectEndStealthClientSegmentHeader = new byte[] {    0xA6, 0x33, 0x00, 0x00,
                                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        // TeamStealthSegment
        public static readonly int HeroObjectTeamStealthSegmentSectionLength = 28;
        public static readonly byte[] HeroObjectTeamStealthSegmentHeader = new byte[] { 0x09, 0xA7, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };


        // NetRelComponent
        public static readonly int HeroObjectNetRelComponentSectionLength = 28;
        public static readonly byte[] HeroObjectNetRelComponentHeader = new byte[] {    0xF9, 0x63, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                };

        // ActionManager
        public static readonly int HeroObjectActionManagerSectionLength = 28;
        public static readonly byte[] HeroObjectActionManagerHeader = new byte[] {  0x8D, 0x01, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };

        // mAIResponsiveBehaviors
        public static readonly int HeroObjectmAIResponsiveBehaviorsSectionLength = 52;
        public static readonly byte[] HeroObjectmAIResponsiveBehaviorsHeader = new byte[] { 0x82, 0x54, 0x00, 0x00,
                                                                                            0x00, 0x00, 0x00, 0x00
                                                                                };
    }
}
