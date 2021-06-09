using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xDA8, GUID = 0xCFFA3BDDF2A0BDDA, NameHash = 0x4B63CD1B58DAF5A4)]
    public class GcTradeSettings : NMSTemplate
    {
        /* 0x000 */ public GcTradeData SpaceStation;
        /* 0x0B8 */ public GcTradeData Shop;
        /* 0x170 */ public GcTradeData TechShop;
        /* 0x228 */ public GcTradeData ShipTechSpecialist;
        /* 0x2E0 */ public GcTradeData SuitTechSpecialist;
        /* 0x398 */ public GcTradeData WeapTechSpecialist;
        /* 0x450 */ public GcTradeData VehicleTechSpecialist;
        /* 0x508 */ public GcTradeData NexusTechSpecialist;
        /* 0x5C0 */ public GcTradeData Ship;
        /* 0x678 */ public GcTradeData ExpShip;
        /* 0x730 */ public GcTradeData TraShip;
        /* 0x7E8 */ public GcTradeData WarShip;
        /* 0x8A0 */ public GcTradeData LoneExp;
        /* 0x958 */ public GcTradeData LoneTra;
        /* 0xA10 */ public GcTradeData LoneWar;
        /* 0xAC8 */ public GcTradeData MapShop;
        /* 0xB80 */ public GcTradeData IllegalProds;
        /* 0xC38 */ public GcTradeData Scrap;
        /* 0xCF0 */ public GcTradeData SeasonRewardsShop;
    }
}
