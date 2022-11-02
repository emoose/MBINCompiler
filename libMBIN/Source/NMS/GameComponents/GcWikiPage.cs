using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6ED9592D9FF7719, NameHash = 0x8762991A70BCCE8C)]
    public class GcWikiPage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A PageID;
        /* 0x020 */ public TkTextureResource Icon;
        /* 0x0A4 */ public NMSString0x40 Content;
        /* 0x0E4 */ public NMSString0x40 VRContent;
        /* 0x124 */ public TkTextureResource ContentImage;
    }
}
