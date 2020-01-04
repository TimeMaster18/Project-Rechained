using SingleplayerLauncher.Resources;
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

        public static Hero Instance => instance;

        public UPKFile UPKFile { get; set; }

        public string Skin { get; set; }
        public string[] Loadout { get; set; } // Could be it's own class if we get Guardians and Traits to work.
        public string[] Guardians { get; set; }
        public string Name = "Maximilian";

        private const int LoadoutSlotByteSize = 4;
        private const int LoadoutSlotsNumber = 9;
        // Where the actual array of the loadout starts is + 12 bytes from the loadout header.
        // Array Size in bytes + Array (start?) index + Array number of elements (4 + 4 + 4 )
        private const int LoadoutOffsetFromHeader = 12;

        private const int GuardianSlotsNumber = 2;
        // Where the actual array of the guardians starts is + 12 bytes from the loadout header.
        // Array Size in bytes + Array (start?) index + Array number of elements (4 + 4 + 4 )
        private const int GuardiansOffsetFromHeader = 12;

        
        private static readonly byte[] StartHeaderAfterGuardiansMaximilian = SpitfireGameUPK.HeroObjectWeaverTreeDefaultHeader;

        public void ApplyLoadoutChanges()
        {
            RemoveByteSection(SpitfireGameUPK.HeroObjectDefaultWaveClassesHeader, SpitfireGameUPK.HeroObjectDefaultWaveClassesSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectHeroDamageTypeHeader, SpitfireGameUPK.HeroObjectHeroDamageTypeSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectStrategicRoleHeader, SpitfireGameUPK.HeroObjectStrategicRoleSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectDefaultRoleClassHeader, SpitfireGameUPK.HeroObjectDefaultRoleClassSectionLength);

            ApplyTrapsGear();
            //ApplyTraits();
            ApplySkin();

            // FillRemovedBytes should be run after all the removing
            if (UPKFile.nBytesRemoved > 0)
            {
                int positionToFillRemovedBytesWithZeros = UPKFile.FindBytesKMP(StartHeaderAfterGuardiansMaximilian, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);
                FillRemovedBytes(positionToFillRemovedBytesWithZeros);
            }

            ApplyGuardians(); // Should go after everything else since it's where we are inserting the extra bytes and needs to know the size
        }

        private void ApplyTrapsGear()
        {
            if (Loadout == null || Loadout.Length != 9)
                throw new Exception("9 traps/gear must be used");

            int startIndex = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectLoadoutHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size) + SpitfireGameUPK.HeroObjectLoadoutHeader.Length;
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

            int startIndex = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectGuardiansHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size) + SpitfireGameUPK.HeroObjectGuardiansHeader.Length;
            int endIndex = UPKFile.FindBytesKMP(StartHeaderAfterGuardiansMaximilian, startIndex + GuardiansOffsetFromHeader, SpitfireGameUPK.HeroObjects[Name].Size);
            int totalSize = endIndex - startIndex; // Everything after header

            byte[] firstGuardian = Resources.Loadout.Guardians[Guardians[0]].First; // Extra space after each guardian is already included
            byte[] secondGuardian = Resources.Loadout.Guardians[Guardians[1]].First;

            byte[] sizeFirstGuardian = new byte[] { Resources.Loadout.Guardians[Guardians[0]].Second, 0x00, 0x00, 0x00 }; // Add the 0x00 to complete the 4 bytes field

            int secondGuardianOffset = firstGuardian.Length + sizeFirstGuardian.Length + GuardiansOffsetFromHeader + 4; // 4 from second guardian size itself
            byte[] sizeSecondGuardian = new byte[] { (byte)(totalSize - secondGuardianOffset), 0x00, 0x00, 0x00 }; // Counting extra space

            int emptySpaceOffset = secondGuardianOffset + Resources.Loadout.Guardians[Guardians[1]].Second;
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
            int skinIndex = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectSkinPattern, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size) + SpitfireGameUPK.HeroObjectSkinPattern.Length;
            UPKFile.OverrideBytes(GameInfo.Heroes[Name].GetSkinHex(Skin), skinIndex);
        }

        private void RemoveByteSection(byte[] sectionHeaderByteArray, int length)
        {
            int removeIndex = UPKFile.FindBytesKMP(sectionHeaderByteArray, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);

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

                if (Resources.Loadout.Traps.ContainsKey(loadout[i]))
                {
                    slotBytes = Resources.Loadout.Traps[loadout[i]];
                }
                else
                {
                    slotBytes = Resources.Loadout.Gear[loadout[i]];
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
