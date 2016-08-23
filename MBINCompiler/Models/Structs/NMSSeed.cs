using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class NMSSeed : NMSTemplate
    {
        public long Seed;
        public bool UseSeedValue;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Padding9; // todo: is this always here? might be padding inside the parent template instead
    }
}
