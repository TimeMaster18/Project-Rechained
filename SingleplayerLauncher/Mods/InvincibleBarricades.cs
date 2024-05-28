using SingleplayerLauncher.Utils;

namespace SingleplayerLauncher.Mods
{
    public class InvincibleBarricades : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x00, 0x00, 0x00, 0x6E, 0x4B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xCB, 0x15, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        private const int CHANGE_INDEX = 0x184631A; // ( CB 15 00 00 ): CanBeDamaged

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