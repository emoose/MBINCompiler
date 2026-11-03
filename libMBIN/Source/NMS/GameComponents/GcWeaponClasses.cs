namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4CDF5A059FAF47A, NameHash = 0xCE6DB97B)]
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
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponStatClassEnum WeaponStatClass;
    }
}
