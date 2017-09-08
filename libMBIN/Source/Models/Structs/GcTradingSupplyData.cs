namespace libMBIN.Models.Structs
{
    public class GcTradingSupplyData : NMSTemplate      // size: 0x28
    {
        public ulong GalacticAddress;
        public float Supply;
        public float Demand;
        [NMS(Size = 0x10)]
        public string Product;
        public ulong Timestamp;
    }
}
