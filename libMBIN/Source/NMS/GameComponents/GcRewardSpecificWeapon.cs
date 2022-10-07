using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA219A0DD330092AD, NameHash = 0xF3710AB8A6F40A88)]
    public class GcRewardSpecificWeapon : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer WeaponInventory;
        /* 0x158 */ public GcInventoryLayout WeaponLayout;
        /* 0x178 */ public GcExactResource WeaponResource;
        /* 0x208 */ public GcWeaponClasses WeaponType;
        /* 0x210 */ public NMSString0x20A NameOverride;
        /* 0x230 */ public bool IsGift;
        /* 0x231 */ public bool IsRewardWeapon;
        /* 0x232 */ public bool FormatAsSeasonal;
    }
}
