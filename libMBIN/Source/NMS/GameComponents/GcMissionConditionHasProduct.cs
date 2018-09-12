namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F2EFAFE6C5E4FCB0)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        public GcProductTableEnum Product;
        public int Amount;
    }
}
