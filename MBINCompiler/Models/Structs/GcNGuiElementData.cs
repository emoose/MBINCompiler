namespace MBINCompiler.Models.Structs
{
    public class GcNGuiElementData : NMSTemplate        // size: 0x50
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string PresetID;

        /* 0x20 */ public bool IsHidden;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding21;

        /* 0x24 */ public GcNGuiLayoutData Layout;
    }
}
