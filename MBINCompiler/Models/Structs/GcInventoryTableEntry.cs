using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryTableEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int MinSize;
        public int MaxSize;
        public int SizeType;
        public string[] SizeTypeValues()
        {
            return new[] { "SciSmall", "SciMedium", "SciLarge", "FgtSmall", "FgtMedium", "FgtLarge", "ShuSmall", "ShtMedium", "ShtLarge", "DrpSmall", "DrpMedium", "DrpLarge", "WeaponSmall", "WeaponMedium", "WeaponLarge" }; // Shu/Sht spelling mistake(?) is from the exe
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding1C;
    }
}
