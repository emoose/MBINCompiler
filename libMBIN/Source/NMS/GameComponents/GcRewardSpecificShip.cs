using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x817C1DBE87C98F46, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ShipResource;
        /* 0x2A8 */ public GcInventoryLayout ShipLayout;
        /* 0x2C8 */ public GcInventoryContainer ShipInventory;
        /* 0x420 */ public int CostAmount;
        /* 0x424 */ public GcCurrency CostCurrency;
        /* 0x428 */ public GcSpaceshipClasses ShipType;
        /* 0x42C */ public bool UseOverrideSizeType;
        /* 0x430 */ public GcInventoryLayoutSizeType OverrideSizeType;
        /* 0x438 */ public NMSString0x20A NameOverride;
        /* 0x458 */ public bool IsGift;
        /* 0x459 */ public bool IsRewardShip;
        /* 0x45A */ public bool FormatAsSeasonal;
    }
}
