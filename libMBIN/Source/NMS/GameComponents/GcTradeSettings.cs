namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x6E0, GUID = 0x16C8B39049D0C75A)]
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
