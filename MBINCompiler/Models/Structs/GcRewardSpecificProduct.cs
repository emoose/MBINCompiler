namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
    }
}
