using System;

namespace SingleplayerLauncher.Mods
{
    public class EnhancedTrapRotation : Mod
    {
        readonly byte[] DEGREES_90_IN_BYTES = BitConverter.GetBytes((int) 90);
        readonly byte[] DEGREES_10_IN_BYTES = BitConverter.GetBytes((int) 10); // Actually seems to work as 22.5 

        private const int CHANGE_INDEX = 0x1544729;

        public override bool InstallMod()
        {
            UPKFile.OverrideBytes(DEGREES_10_IN_BYTES, CHANGE_INDEX);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideBytes(DEGREES_90_IN_BYTES, CHANGE_INDEX);
            return true;
        }
    }
}