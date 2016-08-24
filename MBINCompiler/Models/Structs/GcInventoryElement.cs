using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryElement : NMSTemplate
    {
        public GcInventoryType Type;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int Amount;
        public int MaxAmount;
        public float DamageFactor;
        public GcInventoryIndex Index;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode2;
    }
}
