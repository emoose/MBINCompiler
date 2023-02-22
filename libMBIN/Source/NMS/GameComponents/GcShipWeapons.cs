namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AB116C33852A2C3, NameHash = 0xCBDFDF631D9C73E8)]
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
