using System;
using System.Linq;

namespace SingleplayerLauncher
{

    public sealed class Hero
    {
        private static readonly Hero instance = new Hero();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit /Singleton
        static Hero() { }
        private Hero() { }

        public static Hero Instance
        {
            get
            {
                return instance;
            }
        }

        public UPKFile UPKFile { get; set; }

        public string Skin { get; set; }
        public string[] Loadout { get; set; } // Could be it's own class if we get Guardians and Traits to work.
        public string[] Guardians { get; set; }

        private const int LoadoutSlotByteSize = 4;
        private const int LoadoutSlotsNumber = 9;
        // Where the actual array of the loadout starts is + 12 bytes from the loadout header.
        // Array Size in bytes + Array (start?) index + Array number of elements (4 + 4 + 4 )
        private const int LoadoutOffsetFromHeader = 12;

        private const int GuardianSlotsNumber = 2;
        // Where the actual array of the guardians starts is + 12 bytes from the loadout header.
        // Array Size in bytes + Array (start?) index + Array number of elements (4 + 4 + 4 )
        private const int GuardiansOffsetFromHeader = 12;

        // TODO Add resource file with the rest of heroes and remove this (and use above ones only, the rest to resource files)
        private const string NameMaximilian = "Maximilian";
        private const int HeroObjectOffsetMaximillian = 0x28AB495; // Within the file offset where it starts (Maximillian currently default)
        private const int HeroObjectSizeMaximillian = 1542;
        // private const string SpitfireGameUPKMaximilian = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        private static readonly byte[] LoadoutHeaderMaximilian = new byte[] {   0xC6, 0x2C, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00,
                                                                                0xC5, 0x07, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly byte[] GuardiansHeaderMaximillian = new byte[] { 0xBA, 0x2C, 0x00, 0x00,
                                                                                 0x00, 0x00, 0x00, 0x00,
                                                                                 0xC5, 0x07, 0x00, 0x00,
                                                                                 0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly int DefaultWaveClassesSectionLength = 64;
        private static readonly byte[] DefaultWaveClassesHeaderMaximillian = new byte[] {
                                                                                    0xF3, 0x2c, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly int HeroDamageTypeSectionLength = 40;
        private static readonly byte[] HeroDamageTypeHeaderMaximillian = new byte[] {
                                                                                    0x0E, 0x46, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly int StrategicRoleSectionLength = 40;
        private static readonly byte[] StrategicRoleHeaderMaximillian = new byte[] {
                                                                                    0x74, 0xA3, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly int DefaultRoleClassSectionLength = 28;
        private static readonly byte[] DefaultRoleClassHeaderMaximillian = new byte[] {
                                                                                    0xE4, 0x2C, 0x00, 0x00,
                                                                                    0x00, 0x00, 0x00, 0x00
                                                                                };


        private static readonly byte[] SkinPatternMaximilian = new byte[] { 0x52, 0x1E, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x6B, 0x66, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x04, 0x00, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00
                                                                            };
        private static readonly byte[] WeaverTreeDefaultHeaderMaximillian = new byte[] { 0x00, 0xB4, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
        };
        private static readonly byte[] StartHeaderAfterGuardiansMaximillian = WeaverTreeDefaultHeaderMaximillian;

        public void ApplyLoadoutChanges()
        {
            RemoveByteSection(DefaultWaveClassesHeaderMaximillian, DefaultWaveClassesSectionLength);
            RemoveByteSection(HeroDamageTypeHeaderMaximillian, HeroDamageTypeSectionLength);
            RemoveByteSection(StrategicRoleHeaderMaximillian, StrategicRoleSectionLength);
            RemoveByteSection(DefaultRoleClassHeaderMaximillian, DefaultRoleClassSectionLength);

            ApplyTrapsGear();
            //ApplyTraits();
            ApplySkin();

            // FillRemovedBytes should be run after all the removing
            if (UPKFile.nBytesRemoved > 0)
            {
                int positionToFillRemovedBytesWithZeros = UPKFile.FindBytesKMP(StartHeaderAfterGuardiansMaximillian, HeroObjectOffsetMaximillian, HeroObjectSizeMaximillian);
                FillRemovedBytes(positionToFillRemovedBytesWithZeros);
            }

            ApplyGuardians(); // Should go after everything else since it's where we are inserting the extra bytes and needs to know the size
        }

        private void ApplyTrapsGear()
        {
            if (Loadout == null || Loadout.Length != 9)
                throw new Exception("9 traps/gear must be used");

            int startIndex = UPKFile.FindBytesKMP(LoadoutHeaderMaximilian, HeroObjectOffsetMaximillian, HeroObjectSizeMaximillian) + LoadoutHeaderMaximilian.Length;
            int arrayElementCountIndex = startIndex + 8;
            int arraySizeIndex = startIndex;

            // There aren't 9 slots set up so we create them and insert necessary bytes
            if (UPKFile.getByte(arrayElementCountIndex) != 9)
            {
                UPKFile.OverrideSingleByte((LoadoutSlotsNumber + 1) * LoadoutSlotByteSize, arraySizeIndex); // Array Size
                UPKFile.OverrideSingleByte(LoadoutSlotsNumber, arrayElementCountIndex); // Array Element Count ( the 4 bytes inbetween are "index 0")

                // Add new slots (2 slots)
                UPKFile.InsertZeroedBytes(startIndex + LoadoutOffsetFromHeader + 8, 2 * LoadoutSlotByteSize);
            }

            // Convert and apply Loadout
            byte[] loadoutBytes = ConvertLoadoutToBytes(Loadout);
            UPKFile.OverrideBytes(loadoutBytes, startIndex + LoadoutOffsetFromHeader);
        }

        private void ApplyGuardians()
        {
            if (Guardians == null || Guardians.Length != 2)
                throw new Exception("2 guardians must be used");

            int startIndex = UPKFile.FindBytesKMP(GuardiansHeaderMaximillian, HeroObjectOffsetMaximillian, HeroObjectSizeMaximillian) + GuardiansHeaderMaximillian.Length;
            int endIndex = UPKFile.FindBytesKMP(StartHeaderAfterGuardiansMaximillian, startIndex + GuardiansOffsetFromHeader, HeroObjectSizeMaximillian);
            int totalSize = endIndex - startIndex; // Everything after header

            byte[] firstGuardian = Resources.guardians[Guardians[0]].First; // Extra space after each guardian is already included
            byte[] secondGuardian = Resources.guardians[Guardians[1]].First;

            byte[] sizeFirstGuardian = new byte[] { Resources.guardians[Guardians[0]].Second, 0x00, 0x00, 0x00 }; // Add the 0x00 to complete the 4 bytes field

            int secondGuardianOffset = firstGuardian.Length + sizeFirstGuardian.Length + GuardiansOffsetFromHeader + 4; // 4 from second guardian size itself
            byte[] sizeSecondGuardian = new byte[] { (byte)(totalSize - secondGuardianOffset), 0x00, 0x00, 0x00 }; // Counting extra space

            int emptySpaceOffset = secondGuardianOffset + Resources.guardians[Guardians[1]].Second;
            byte[] emptySpace = Enumerable.Repeat((byte)0x00, totalSize - emptySpaceOffset).ToArray();

            // Combining arrays to SizeGuardian1 + Guardian1 + SizeGuardian2 + Guardian2 + emptySpace
            byte[] guardiansBytes = sizeFirstGuardian.Concat(firstGuardian).Concat(sizeSecondGuardian).Concat(secondGuardian).Concat(emptySpace).ToArray();

            UPKFile.OverrideBytes(guardiansBytes, startIndex + GuardiansOffsetFromHeader);

            UPKFile.OverrideSingleByte((byte)(totalSize - 8), startIndex); // Size (counts array element count and both guardians and their sizes but not itself or index so -8)
            //TODO check single byte and avoid override?
            UPKFile.OverrideSingleByte(GuardianSlotsNumber, startIndex + 8); // Array Element Count 
        }

        private void ApplySkin()
        {
            int skinIndex = UPKFile.FindBytesKMP(SkinPatternMaximilian, HeroObjectOffsetMaximillian, HeroObjectSizeMaximillian) + SkinPatternMaximilian.Length;
            UPKFile.OverrideBytes(Resources.skins[NameMaximilian][Skin], skinIndex);
        }

        private void RemoveByteSection(byte[] sectionHeaderByteArray, int length)
        {
            int removeIndex = UPKFile.FindBytesKMP(sectionHeaderByteArray, HeroObjectOffsetMaximillian, HeroObjectSizeMaximillian);

            if (removeIndex != -1)
            {
                UPKFile.RemoveBytes(removeIndex, length);
            }
        }

        private void FillRemovedBytes(int insertIndex)
        {
            UPKFile.InsertZeroedBytes(insertIndex, 0);
        }

        private byte[] ConvertLoadoutToBytes(string[] loadout)
        {
            byte[] loadoutBytes = new byte[LoadoutSlotsNumber * LoadoutSlotByteSize];

            for (int i = 0; i < loadout.Length; i++)
            {
                byte[] slotBytes;

                if (Resources.traps.ContainsKey(loadout[i]))
                {
                    slotBytes = Resources.traps[loadout[i]];
                }
                else
                {
                    slotBytes = Resources.gear[loadout[i]];
                }

                for (int j = 0; j < LoadoutSlotByteSize; j++)
                {
                    loadoutBytes[i * LoadoutSlotByteSize + j] = slotBytes[j];
                }
            }

            return loadoutBytes;
        }

    }
}
