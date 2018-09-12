using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x33E13148993114E9)]
    public class GcShipWeaponData : NMSTemplate
    {
		public enum ShipWeaponEnum { Laser, Projectile, Shotgun, Minigun, Plasma, Missile, Rocket }
		public ShipWeaponEnum ShipWeapon;
    }
}
