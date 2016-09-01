namespace MBINCompiler.Models.Structs
{
    public class GcInventoryTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int MinSize;
        public int MaxSize;
        public int SizeType;
        public string[] SizeTypeValues()
        {
            return new[] { "SciSmall", "SciMedium", "SciLarge", "FgtSmall", "FgtMedium", "FgtLarge", "ShuSmall", "ShtMedium", "ShtLarge", "DrpSmall", "DrpMedium", "DrpLarge", "WeaponSmall", "WeaponMedium", "WeaponLarge" }; // Shu/Sht spelling mistake(?) is from the exe
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
