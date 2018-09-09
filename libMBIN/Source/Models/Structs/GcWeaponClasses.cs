namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D8C84CCD6E74A53B)]
    public class GcWeaponClasses : NMSTemplate
    {
		public enum WeaponClassEnum { Pistol, Rifle, Pristine, Alien }
		public WeaponClassEnum WeaponClass;
    }
}
