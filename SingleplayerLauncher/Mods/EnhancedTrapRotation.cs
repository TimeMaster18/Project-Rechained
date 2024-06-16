using SingleplayerLauncher.GameFiles;
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
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, DEGREES_10_IN_BYTES);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, DEGREES_90_IN_BYTES);
            return true;
        }
    }
}