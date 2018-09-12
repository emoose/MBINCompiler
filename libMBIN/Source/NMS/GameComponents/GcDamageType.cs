namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F03F99B8CA594022)]
    public class GcDamageType : NMSTemplate
    {
		public enum DamageTypeEnum { Gun, Laser, Shotgun, Burst, Rail, Explosion, Melee, ShipGun, ShipLaser, ShipShotgun, ShipMinigun, ShipRockets,
                                     ShipPlasma, VehicleGun, VehicleLaser, SentinelLaser, PlayerDamage, PlayerWeapons, ShipWeapons, VehicleWeapons }
		public DamageTypeEnum DamageType;
    }
}
