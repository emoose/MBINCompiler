namespace libMBIN.Models.Structs
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
