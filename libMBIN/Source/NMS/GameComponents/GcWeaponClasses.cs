namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6843E86F2C6F7CEB, NameHash = 0xAD17D6D6D824A77D)]
    public class GcWeaponClasses : NMSTemplate
    {
        // size: 0x6
        public enum WeaponStatClassEnum : uint {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal,
            Robot,
        }
        /* 0x0 */ public WeaponStatClassEnum WeaponStatClass;
    }
}
