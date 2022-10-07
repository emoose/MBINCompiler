using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FBFEA4437A3DE87, NameHash = 0x977CF58471E48CD1)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ShipResource;
        /* 0x2A8 */ public GcInventoryLayout ShipLayout;
        /* 0x2C8 */ public GcInventoryContainer ShipInventory;
        /* 0x420 */ public GcSpaceshipClasses ShipType;
        /* 0x428 */ public NMSString0x20A NameOverride;
        /* 0x448 */ public bool IsGift;
        /* 0x449 */ public bool IsRewardShip;
        /* 0x44A */ public bool FormatAsSeasonal;
    }
}
