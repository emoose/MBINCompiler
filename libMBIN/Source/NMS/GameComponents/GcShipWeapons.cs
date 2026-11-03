namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1AA34FEA2C7CE9, NameHash = 0x1A8F1C04)]
    public class GcShipWeapons : NMSTemplate
    {
        // size: 0x7
        public enum ShipWeaponEnum : uint {
            Laser,
            Projectile,
            Shotgun,
            Minigun,
            Plasma,
            Missile,
            Rocket,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipWeaponEnum ShipWeapon;
    }
}
