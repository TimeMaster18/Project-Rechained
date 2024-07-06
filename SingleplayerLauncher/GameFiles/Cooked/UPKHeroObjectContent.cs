using SingleplayerLauncher.Model;
using System;
using System.Linq;

namespace SingleplayerLauncher
{

    public sealed class UPKHeroObjectContent
    {

        public UPKFile HeroObjectContent { get; private set; }
        private readonly GameInfo GameInfo = GameInfo.Instance;

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
        private const int DefaultArchetypesSectionSize = 32;

        public UPKHeroObjectContent(UPKFile heroObjectContent)
        {
            HeroObjectContent = heroObjectContent;
        }

        private void FillRemovedBytes(int insertIndex)
        {
            HeroObjectContent.InsertZeroedBytes(insertIndex, 0);
        }
    }
}
