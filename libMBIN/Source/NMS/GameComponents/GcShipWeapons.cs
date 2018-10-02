using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB1DE413EF5AFC669)]
    public class GcShipWeapons : NMSTemplate
    {
        // size: 0x7
		public enum ShipWeaponEnum { Laser, Projectile, Shotgun, Minigun, Plasma, Missile, Rocket }
		public ShipWeaponEnum ShipWeapon;
    }
}
