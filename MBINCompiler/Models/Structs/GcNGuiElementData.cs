namespace MBINCompiler.Models.Structs
{
    public class GcNGuiElementData : NMSTemplate        // size: 0x58
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string PresetID;

        /* 0x20 */ public long CreationTime;

        /* 0x28 */ public bool IsHidden;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding29;

        /* 0x2C */ public GcNGuiLayoutData Layout;
    }
}
