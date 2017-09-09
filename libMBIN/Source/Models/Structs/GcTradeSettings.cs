namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x120)]
    public class GcTradeSettings : NMSTemplate
    {
        public GcTradeData SpaceStation;
        public GcTradeData Shop;
    }
}
