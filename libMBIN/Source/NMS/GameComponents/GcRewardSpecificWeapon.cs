using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2F3F04839247B7FA)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        public GcInventoryContainer WeaponInventory;
        public GcInventoryLayout WeaponLayout;
        public GcExactResource WeaponResource;
        [NMS(Size = 0x20)]
        public string NameOverride;
    }
}
