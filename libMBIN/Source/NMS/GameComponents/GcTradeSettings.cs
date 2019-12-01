using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA50, GUID = 0xE861E5658B30CE3A, NameHash = 0x4B63CD1B58DAF5A4)]
    public class GcTradeSettings : NMSTemplate
    {
        /* 0x000 */ public GcTradeData SpaceStation;
        /* 0x0B0 */ public GcTradeData Shop;
        /* 0x160 */ public GcTradeData TechShop;
        /* 0x210 */ public GcTradeData ShipTechSpecialist;
        /* 0x2C0 */ public GcTradeData SuitTechSpecialist;
        /* 0x370 */ public GcTradeData WeapTechSpecialist;
        /* 0x420 */ public GcTradeData VehicleTechSpecialist;
        /* 0x4D0 */ public GcTradeData Ship;
        /* 0x580 */ public GcTradeData ExpShip;
        /* 0x630 */ public GcTradeData TraShip;
        /* 0x6E0 */ public GcTradeData WarShip;
        /* 0x790 */ public GcTradeData LoneExp;
        /* 0x840 */ public GcTradeData LoneTra;
        /* 0x8F0 */ public GcTradeData LoneWar;
        /* 0x9A0 */ public GcTradeData MapShop;
    }
}
