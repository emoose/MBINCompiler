using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCostProduct : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;
    }
}
