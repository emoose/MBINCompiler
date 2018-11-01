using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x841CEF70EF53F678)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ChatText;
        [NMS(Size = 0x10)]
        /* 0x040 */ public string AnimationName;

        /* 0x050 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;
        
        [NMS(Size = 0x10)]
        /* 0x0D8 */ public string LinkedSpecialID;
        [NMS(Size = 0x10)]
        /* 0x0E8 */ public string LoopAnimUntilMov;

        /* 0x0F8 */ public bool CloseMenuOnSelect;
        /* 0x0F9 */ public bool AvailableUnderwater;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x0FA */ public byte[] Endpadding;
    }
}
