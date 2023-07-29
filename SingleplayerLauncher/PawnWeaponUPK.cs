using SingleplayerLauncher.Model;

namespace SingleplayerLauncher
{
    class PawnWeaponUPK
    {
        private readonly UPKFile uPKFile;
        private readonly Hero hero;

        public PawnWeaponUPK(UPKFile uPKFile, Hero hero)
        {
            this.uPKFile = uPKFile;
            this.hero = hero;
        }

        public void ApplyLoadout()
        {
            UPKFile heroObjectContent = new UPKFile(uPKFile.GetSubArray(hero.UPKFileHeroObjectOffset, hero.UPKFileHeroObjectSize));
            UPKHeroObjectContent UPKHeroObjectContent = new UPKHeroObjectContent(heroObjectContent);
            UPKHeroObjectContent.ApplyLoadoutChanges();
            uPKFile.OverrideBytes(UPKHeroObjectContent.HeroObjectContent.Bytes, hero.UPKFileHeroObjectOffset);
        }

        public void SaveChanges()
        {
            uPKFile.Save();
        }
    }
}
