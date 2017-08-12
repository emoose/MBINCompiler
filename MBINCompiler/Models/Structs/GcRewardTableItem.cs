namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItem : NMSTemplate
    {
        public float PercentageChance;      // size: 0x90
        public NMSTemplate Reward;
        [NMS(Size = 0x40)]
        public string LabelID;
    }
}
