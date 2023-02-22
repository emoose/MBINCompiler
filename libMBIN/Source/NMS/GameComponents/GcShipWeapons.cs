namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F1DD25465633C5D, NameHash = 0xCBDFDF631D9C73E8)]
    public class GcShipWeapons : NMSTemplate
    {
        // size: 0x7
        public enum ShipWeaponEnum {
            Laser,
            Projectile,
            Shotgun,
            Minigun,
            Plasma,
            Missile,
            Rocket,
        }
        /* 0x0 */ public ShipWeaponEnum ShipWeapon;
    }
}
