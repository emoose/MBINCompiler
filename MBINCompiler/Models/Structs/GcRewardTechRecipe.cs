using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string RewardGroup;
    }
}
