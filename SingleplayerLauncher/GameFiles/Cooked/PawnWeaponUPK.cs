using SingleplayerLauncher.Model;

namespace SingleplayerLauncher
{
    class PawnWeaponUPK
    {
        // TODO: make singleton * Load after initialized

        private readonly UPKFile uPKFile;
        private readonly Hero hero;

        public PawnWeaponUPK(UPKFile uPKFile, Hero hero)
        {
            this.uPKFile = uPKFile;
            this.hero = hero;
        }

        public void SaveChanges()
        {
            uPKFile.Save();
        }
    }
}
