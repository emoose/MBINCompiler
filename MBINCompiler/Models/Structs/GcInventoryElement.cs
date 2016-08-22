using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryElement : NMSTemplate
    {
        public GcInventoryType Type;
        public int EmptyNode1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int Amount;
        public int MaxAmount;
        public float DamageFactor;
        public GcInventoryIndex Index;
        public int EmptyNode2;
    }
}
