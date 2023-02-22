namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A51F0A05E5EB04B, NameHash = 0xAD17D6D6D824A77D)]
    public class GcWeaponClasses : NMSTemplate
    {
        // size: 0x5
        public enum WeaponStatClassEnum {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal,
        }
        /* 0x0 */ public WeaponStatClassEnum WeaponStatClass;
    }
}
