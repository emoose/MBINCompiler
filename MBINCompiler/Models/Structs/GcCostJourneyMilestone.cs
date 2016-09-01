using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCostJourneyMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RequiredMilestone;
    }
}
