using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF7269993F8A4F96E, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // 0xC entries
		public enum WeaponModeEnum { Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield, TerrainEdit, SunLaser, SoulLaser }
		public WeaponModeEnum WeaponMode;
    }
}
