using SingleplayerLauncher.Utils;
using System;

namespace SingleplayerLauncher.Mods
{
    public class EnhancedTrapRotation : Mod
    {
        readonly byte[] DEGREES_90_IN_BYTES = BitConverter.GetBytes((int) 90);
        readonly byte[] DEGREES_10_IN_BYTES = BitConverter.GetBytes((int) 10); // Actually seems to work as 22.5 

        private const int CHANGE_INDEX = 0x1544729;

        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x00, 0x00, 0x00, 0xD6, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC8, 0x42, 0x58, 0x83, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6E, 0x4B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        public override bool InstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideBytes(DEGREES_10_IN_BYTES, indexToModify);

            return true;
        }

        public override bool UninstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideBytes(DEGREES_90_IN_BYTES, indexToModify);

            return true;
        }
    }
}