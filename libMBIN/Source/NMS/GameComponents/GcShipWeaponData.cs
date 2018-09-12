namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x33E13148993114E9)]
    public class GcShipWeaponData : NMSTemplate
    {
		public enum ShipWeaponEnum { Laser, Projectile, Shotgun, Minigun, Plasma, Missile, Rocket }
		public ShipWeaponEnum ShipWeapon;
    }
}
