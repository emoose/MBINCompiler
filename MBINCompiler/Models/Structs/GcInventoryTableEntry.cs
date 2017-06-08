namespace MBINCompiler.Models.Structs
{
    public class GcInventoryTableEntry : NMSTemplate        // size: 0x20
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x04 */ public int MinSize;
        /* 0x08 */ public int MaxSize;
        /* 0x0C */ public GcInventoryLayoutSizeType LayoutSizeType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x10 */ public byte[] EndPadding;
    }
}
