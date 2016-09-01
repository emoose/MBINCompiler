using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechId;
    }
}
