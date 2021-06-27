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
        public string[] Guardians { get; set; } = DefaultValues.Guardians;
        public string Name { get; set; }
        public int AccountLevel { get; set; }

        private const int LoadoutSlotByteSize = 4;
        private const int LoadoutSlotsNumber = 9;
        // Where the actual array of the loadout starts is + 28 bytes from the start of the loadout header.
        // Header + Field Type + Field Size in bytes + Array (start?) index + Array number of elements (8 + 8 + 4 + 4 + 4)
        private const int LoadoutArraySizeOffset = 16;
        private const int LoadoutArrayElementCountOffset = 24;
        private const int LoadoutSlotsOffset = 28;
        private const int LoadoutSectionLength = LoadoutSlotsOffset + 4 * LoadoutSlotsNumber;

        private const int GuardianSlotsNumber = 2;
        // Where the actual array of the guardians starts is + 28 bytes from the start of the guardians header.
        // Header + Field type + Field Size in bytes + Array (start?) index + Array number of elements (8 + 8 + 4 + 4 + 4)
        private const int GuardiansArraySizeOffset = 16;
        private const int GuardiansArrayElementCountOffset = 24;
        private const int GuardiansOffset = 28;


        // Header + Field type + Size in bytes + (start?) index  (8 + 8 + 4 + 4)
        private const int SkinOffsetFromHeader = 24;

        // Header + Field type + Size in bytes + (start?) index  (8 + 8 + 4 + 4)
        private const int HealthOffsetFromHeader = 24;
        private const int HealthMaxOffsetFromHeader = 24;

        private const string nameMaximilian = "Maximilian";


        private static readonly byte[] StartHeaderAfterGuardians = SpitfireGameUPK.HeroObjectWeaverTreeDefaultHeader;

        public void ApplyLoadoutChanges()
        {
            RemoveByteSection(SpitfireGameUPK.HeroObjectDefaultRoleClassHeader, SpitfireGameUPK.HeroObjectDefaultRoleClassSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectStrategicRoleHeader, SpitfireGameUPK.HeroObjectStrategicRoleSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectmAIResponsiveBehaviorsHeader, SpitfireGameUPK.HeroObjectmAIResponsiveBehaviorsSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectActionManagerHeader, SpitfireGameUPK.HeroObjectActionManagerSectionLength);
            RemoveByteSection(SpitfireGameUPK.HeroObjectNetRelComponentHeader, SpitfireGameUPK.HeroObjectNetRelComponentSectionLength);

            if (!Name.Equals(nameMaximilian)) // Maximilian has already part of the bytes we have to insert for the rest. Extra bytes would need to code the size of extra space going past 255, using more than 1 byte for size of guardians.
            {
                RemoveByteSection(SpitfireGameUPK.HeroObjectBeginStealthClientSegmentHeader, SpitfireGameUPK.HeroObjectBeginStealthClientSegmentSectionLength);
                RemoveByteSection(SpitfireGameUPK.HeroObjectEndStealthClientSegmentHeader, SpitfireGameUPK.HeroObjectEndStealthClientSegmentSectionLength);
                RemoveByteSection(SpitfireGameUPK.HeroObjectTeamStealthSegmentHeader, SpitfireGameUPK.HeroObjectTeamStealthSegmentSectionLength);
            }

            ApplyTrapsGear(); // May insert bytes
            //ApplyTraits();

            if (UPKFile.nBytesRemoved > 0)
            {
                int positionToFillRemovedBytesWithZeros = UPKFile.FindBytesKMP(StartHeaderAfterGuardians, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);
                FillRemovedBytes(positionToFillRemovedBytesWithZeros);
            }

            ApplyGuardians(); // Should go after everything else since it's where we are inserting the extra bytes and needs to know the size

            // from here, only edits bytes
            ApplyHealthFix();
            ApplySkin();
        }


        private void ApplyTrapsGear()
        {
            if (Loadout == null || Loadout.Length != LoadoutSlotsNumber)
                throw new Exception("9 traps/gear must be used");

            int startIndexLoadout = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectLoadoutHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size - UPKFile.nBytesRemoved);

            if (startIndexLoadout == -1)
            {
                // Get position after Archetype and Add Header and Field Type
                startIndexLoadout = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectDefaultInventoryArchetypesHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size) + SpitfireGameUPK.HeroObjectDefaultInventoryArchetypesSectionLength;

                UPKFile.InsertZeroedBytes(startIndexLoadout, LoadoutSectionLength);

                UPKFile.OverrideBytes(SpitfireGameUPK.HeroObjectLoadoutHeader, startIndexLoadout);
                UPKFile.OverrideBytes(SpitfireGameUPK.HeroObjectLoadoutFieldType, startIndexLoadout + SpitfireGameUPK.HeroObjectLoadoutHeader.Length);
            }

            int arraySizeIndex = startIndexLoadout + LoadoutArraySizeOffset;
            int arrayElementCountIndex = startIndexLoadout + LoadoutArrayElementCountOffset;
            int loadoutSlotsIndex = startIndexLoadout + LoadoutSlotsOffset;

            // IF there aren't 9 slots set up we create them and insert necessary bytes
            int loadoutSlotsUsed = UPKFile.GetByte(arrayElementCountIndex);
            if (loadoutSlotsUsed != LoadoutSlotsNumber)
            {
                UPKFile.OverrideSingleByte((LoadoutSlotsNumber + 1) * LoadoutSlotByteSize, arraySizeIndex); // Array Size (+1 to count the size field itself too)
                UPKFile.OverrideSingleByte(LoadoutSlotsNumber, arrayElementCountIndex); // Array Element Count ( the 4 bytes inbetween are "index 0")

                // Add new slots (as many as missing)
                int indexAfterUsedSlots = loadoutSlotsIndex + (loadoutSlotsUsed * LoadoutSlotByteSize);

                UPKFile.InsertZeroedBytes(indexAfterUsedSlots, (LoadoutSlotsNumber - loadoutSlotsUsed) * LoadoutSlotByteSize);
            }

            // Convert and apply Loadout
            byte[] loadoutBytes = ConvertLoadoutToBytes(Loadout);
            UPKFile.OverrideBytes(loadoutBytes, loadoutSlotsIndex);
        }

        private void ApplyGuardians()
        {
            if (Guardians == null || Guardians.Length != 2)
                throw new Exception("2 guardians must be used");

            int startIndexGuardians = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectGuardiansHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);

            if (startIndexGuardians == -1)
            {
                // Get position after Loadout and Add Header and Field Type
                startIndexGuardians = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectLoadoutHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size) + LoadoutSectionLength;

                UPKFile.OverrideBytes(SpitfireGameUPK.HeroObjectGuardiansHeader, startIndexGuardians);
                UPKFile.OverrideBytes(SpitfireGameUPK.HeroObjectGuardiansFieldType, startIndexGuardians + SpitfireGameUPK.HeroObjectGuardiansHeader.Length);
            }

            int endIndex = UPKFile.FindBytesKMP(StartHeaderAfterGuardians, startIndexGuardians + GuardiansOffset, SpitfireGameUPK.HeroObjects[Name].Size);
            int totalSize = endIndex - (startIndexGuardians + GuardiansArrayElementCountOffset); // Everything after header

            int guardiansArraySizeIndex = startIndexGuardians + GuardiansArraySizeOffset;
            int guardiansArrayElementCountIndex = startIndexGuardians + GuardiansArrayElementCountOffset;
            int guardiansIndex = startIndexGuardians + GuardiansOffset;

            byte[] firstGuardian = Resources.Loadout.Guardians[Guardians[0]].First; // Extra space after each guardian is already included
            byte[] secondGuardian = Resources.Loadout.Guardians[Guardians[1]].First;

            byte[] sizeFirstGuardian = new byte[] { Resources.Loadout.Guardians[Guardians[0]].Second, 0x00, 0x00, 0x00 }; // Add the 0x00 to complete the 4 bytes field

            int secondGuardianOffset = firstGuardian.Length + sizeFirstGuardian.Length + GuardiansOffset + 4; // 4 from second guardian size itself
            byte[] sizeSecondGuardian = new byte[] { (byte)(totalSize - secondGuardianOffset), 0x00, 0x00, 0x00 }; // Counting extra space

            int emptySpaceOffset = secondGuardianOffset + Resources.Loadout.Guardians[Guardians[1]].Second;

            byte[] emptySpace = Enumerable.Repeat((byte)0x00, totalSize - emptySpaceOffset).ToArray();
            // Combining arrays to SizeGuardian1 + Guardian1 + SizeGuardian2 + Guardian2 + emptySpace
            byte[] guardiansBytes = sizeFirstGuardian.Concat(firstGuardian).Concat(sizeSecondGuardian).Concat(secondGuardian).Concat(emptySpace).ToArray();

            UPKFile.OverrideBytes(guardiansBytes, guardiansIndex);

            UPKFile.OverrideSingleByte((byte)totalSize, guardiansArraySizeIndex); // Size (counts array element count and both guardians and their sizes but not itself or index so -8)
            //TODO check single byte and avoid override?
            UPKFile.OverrideSingleByte(GuardianSlotsNumber, guardiansArrayElementCountIndex); // Array Element Count 
        }        

        private void ApplySkin()
        {
            int startIndexSkin = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectCurrentSkinClassHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);
            UPKFile.OverrideBytes(GameInfo.Heroes[Name].GetSkinHex(Skin), startIndexSkin + SkinOffsetFromHeader);
        }

        private void ApplyHealthFix()
        {
            int startIndexHealth = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectHealthHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);
            int startIndexHealthMax = UPKFile.FindBytesKMP(SpitfireGameUPK.HeroObjectHealthMaxHeader, SpitfireGameUPK.HeroObjects[Name].Offset, SpitfireGameUPK.HeroObjects[Name].Size);
            // Original Game Formula. Past lvl 100 it has diminishing returns (first operand of the sum stops incrementing and the second one starts doing so at a much lower rate)
            double healthMultiplier = Math.Pow(1.00763, (Math.Min(this.AccountLevel, 100) - 1)) + (0.00033 * Math.Max((this.AccountLevel - 100), 0));
            int baseHealth = GameInfo.Heroes[Name].BaseHealth;

            double health = baseHealth * healthMultiplier;

            byte[] healthAsByteArray = BitConverter.GetBytes((float)health);
            UPKFile.OverrideBytes(healthAsByteArray, startIndexHealth + HealthOffsetFromHeader);
            UPKFile.OverrideBytes(healthAsByteArray, startIndexHealthMax + HealthMaxOffsetFromHeader);
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
                    slotBytes = Resources.Loadout.Traps[loadout[i]].Id;
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
