using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItem : NMSTemplate
    {
        public float PercentageChance;
        public NMSTemplate Reward; // Generic
        [NMS(Size = 0x40)]
        public string LabelID;
    }
}
