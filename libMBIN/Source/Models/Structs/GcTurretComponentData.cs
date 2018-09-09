namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6EB3418A4E1F3123)]
    public class GcTurretComponentData : NMSTemplate
    {
		public enum GunTypeEnum { Laser, Projectile, Missile }
		public GunTypeEnum GunType;
    }
}
