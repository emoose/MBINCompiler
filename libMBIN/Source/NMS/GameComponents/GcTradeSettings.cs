using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC60, GUID = 0xD696F1019EE4543E, NameHash = 0x4B63CD1B58DAF5A4)]
    public class GcTradeSettings : NMSTemplate
    {
        /* 0x000 */ public GcTradeData SpaceStation;
        /* 0x0B0 */ public GcTradeData Shop;
        /* 0x160 */ public GcTradeData TechShop;
        /* 0x210 */ public GcTradeData ShipTechSpecialist;
        /* 0x2C0 */ public GcTradeData SuitTechSpecialist;
        /* 0x370 */ public GcTradeData WeapTechSpecialist;
        /* 0x420 */ public GcTradeData VehicleTechSpecialist;
        /* 0x4D0 */ public GcTradeData NexusTechSpecialist;
        /* 0x580 */ public GcTradeData Ship;
        /* 0x630 */ public GcTradeData ExpShip;
        /* 0x6E0 */ public GcTradeData TraShip;
        /* 0x790 */ public GcTradeData WarShip;
        /* 0x840 */ public GcTradeData LoneExp;
        /* 0x8F0 */ public GcTradeData LoneTra;
        /* 0x9A0 */ public GcTradeData LoneWar;
        /* 0xA50 */ public GcTradeData MapShop;
        /* 0xB00 */ public GcTradeData IllegalProds;
        /* 0xBB0 */ public GcTradeData Scrap;
    }
}
