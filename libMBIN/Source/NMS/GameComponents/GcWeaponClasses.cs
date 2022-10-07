namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A7645C95E00A39, NameHash = 0xAD17D6D6D824A77D)]
    public class GcWeaponClasses : NMSTemplate
    {
        // size: 0x5
        public enum WeaponStatClassEnum {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal
        }
        /* 0x0 */ public WeaponStatClassEnum WeaponStatClass;
    }
}
