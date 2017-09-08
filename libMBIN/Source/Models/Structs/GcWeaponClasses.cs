namespace libMBIN.Models.Structs
{
    public class GcWeaponClasses : NMSTemplate
    {
        public int WeaponClass;
        public string[] WeaponClassValues()
        {
            return new[] { "Pistol", "Rifle", "Pristine", "Alien"};
        }
    }
}
