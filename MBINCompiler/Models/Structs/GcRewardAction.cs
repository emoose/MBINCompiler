using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
