namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63C6D11713FFD9E4, NameHash = 0xAD17D6D6D824A77D)]
    public class GcWeaponClasses : NMSTemplate
    {
        // size: 0xA
        public enum WeaponStatClassEnum : uint {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal,
            Robot,
            Atlas,
            AtlasYellow,
            AtlasBlue,
            Staff,
        }
        /* 0x0 */ public WeaponStatClassEnum WeaponStatClass;
    }
}
