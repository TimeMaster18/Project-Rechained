using SingleplayerLauncher.Utils;

namespace SingleplayerLauncher.Mods
{
    public class TrapsInTraps : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1D, 0xEE, 0x00, 0x00, 0x35, 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 99;

        private const int CHANGE_INDEX = 0x15444BC;
        
        public override bool InstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideSingleByte(0, indexToModify);

            return true;
        }

        public override bool UninstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideSingleByte(1, indexToModify);

            return true;
        }
    }
}
