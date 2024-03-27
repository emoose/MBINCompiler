using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D1667F3233DE2C9, NameHash = 0x8762991A70BCCE8C)]
    public class GcWikiPage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A PageID;
        /* 0x020 */ public TkTextureResource Icon;
        /* 0x0A4 */ public NMSString0x40 Content;
        /* 0x0E4 */ public NMSString0x40 VRContent;
        /* 0x124 */ public NMSString0x40 VRAnyHandControlContent;
        /* 0x164 */ public NMSString0x40 VRMoveControllerContent;
        /* 0x1A4 */ public TkTextureResource ContentImage;
    }
}
