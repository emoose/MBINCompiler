namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x60, GUID = 0x0E4F40DAA66FEC322)]
    public class GcCostStatCompare : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x20)]
        public string CostStringCanAfford;
        [NMS(Size = 0x20)]
        public string CostStringCantAfford;
    }
}
