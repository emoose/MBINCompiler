using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x6E0, GUID = 0x2369A7BC5405CBED, Broken = true)]
    public class GcTradeSettings : NMSTemplate
    {
        public GcTradeData SpaceStation;
        public GcTradeData Shop;
        public GcTradeData TechShop;
        public GcTradeData ShipTechSpecialist;
        public GcTradeData SuitTechSpecialist;
        public GcTradeData WeapTechSpecialist;
        public GcTradeData Ship;
        public GcTradeData ExpShip;
        public GcTradeData TraShip;
        public GcTradeData WarShip;
    }
}
