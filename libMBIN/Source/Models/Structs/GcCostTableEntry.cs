namespace MBINCompiler.Models.Structs
{
    public class GcCostTableEntry : NMSTemplate     // size: 0x60
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool DisplayCost;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x18 */ public NMSTemplate Cost;
    }
}
