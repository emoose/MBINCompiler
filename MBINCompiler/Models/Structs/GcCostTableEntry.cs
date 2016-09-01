using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public NMSTemplate Entry;
    }
}
