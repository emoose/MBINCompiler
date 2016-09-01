using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryElement : NMSTemplate
    {
        public GcInventoryType Type;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;
        public int MaxAmount;
        public float DamageFactor;
        public GcInventoryIndex Index;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}
