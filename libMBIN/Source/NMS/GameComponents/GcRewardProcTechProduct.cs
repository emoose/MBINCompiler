namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x30, GUID = 0x89A0651B13A26E32)]
    public class GcRewardProcTechProduct : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Group;
        public int WeightedChanceNormal;
        public int WeightedChanceRare;
        public int WeightedChanceEpic;
        public int WeightedChanceLegendary;
    }
}
