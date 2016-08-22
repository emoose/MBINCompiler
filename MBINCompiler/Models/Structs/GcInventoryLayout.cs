using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryLayout : NMSTemplate
    {
        public int Slots;
        public int EmptyNode1;
        public GcSeed Seed;
        public int Level;
        public int EmptyNode2;
    }
}
