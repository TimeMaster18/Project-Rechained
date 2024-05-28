using SingleplayerLauncher.Utils;

namespace SingleplayerLauncher.Mods
{
    public class TrapsAnySurface : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE_1 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDF, 0x91, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        readonly private byte[] UNIQUE_BYTES_REFERENCE_2 = { 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1D, 0xEE, 0x00, 0x00, 0x35, 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        readonly private byte[] UNIQUE_BYTES_REFERENCE_3 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3A, 0x32, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xDD, 0x1A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xBB, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        readonly private int OFFSET_FROM_UNIQUE_BYTES_1 = 0;
        readonly private int OFFSET_FROM_UNIQUE_BYTES_2 = 0;
        readonly private int OFFSET_FROM_UNIQUE_BYTES_3 = 0;


        private const int CHANGE_INDEX_1 = 0x154453A;
        private const int CHANGE_INDEX_2 = 0x1544459;
        private const int CHANGE_INDEX_3 = 0x1544D37;

        public override bool InstallMod()
        {
            int bytesReferenceIndex1 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_1, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_1));
            int indexToModify1 = bytesReferenceIndex1 + UNIQUE_BYTES_REFERENCE_1.Length + OFFSET_FROM_UNIQUE_BYTES_1;
            UPKFile.OverrideBytes(new byte[] { 0xF1, 0x6F }, indexToModify1);
            int bytesReferenceIndex2 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_2, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_2));
            int indexToModify2 = bytesReferenceIndex2 + UNIQUE_BYTES_REFERENCE_2.Length + OFFSET_FROM_UNIQUE_BYTES_2;
            UPKFile.OverrideBytes(new byte[] { 0xFA, 0x6F }, indexToModify2);
            int bytesReferenceIndex3 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_3, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_3));
            int indexToModify3 = bytesReferenceIndex3 + UNIQUE_BYTES_REFERENCE_3.Length + OFFSET_FROM_UNIQUE_BYTES_3;
            UPKFile.OverrideBytes(new byte[] { 0x16, 0x70 }, indexToModify3);

            return true;
        }

        public override bool UninstallMod()
        {
            int bytesReferenceIndex1 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_1, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_1));
            int indexToModify1 = bytesReferenceIndex1 + UNIQUE_BYTES_REFERENCE_1.Length + OFFSET_FROM_UNIQUE_BYTES_1;
            UPKFile.OverrideBytes(new byte[] { 0x32, 0x65 }, indexToModify1);
            int bytesReferenceIndex2 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_2, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_2));
            int indexToModify2 = bytesReferenceIndex2 + UNIQUE_BYTES_REFERENCE_2.Length + OFFSET_FROM_UNIQUE_BYTES_2;
            UPKFile.OverrideBytes(new byte[] { 0x3B, 0x57 }, indexToModify2);
            int bytesReferenceIndex3 = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE_3, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX_3));
            int indexToModify3 = bytesReferenceIndex3 + UNIQUE_BYTES_REFERENCE_3.Length + OFFSET_FROM_UNIQUE_BYTES_3;
            UPKFile.OverrideBytes(new byte[] { 0xE4, 0x0F }, indexToModify3);

            return true;
        }
    }
}