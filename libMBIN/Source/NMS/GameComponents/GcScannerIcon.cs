using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BE5BE6D342A32E4, NameHash = 0x85905E340468CC13)]
    public class GcScannerIcon : NMSTemplate
    {
        /* 0x000 */ public TkTextureResource Main;
        /* 0x084 */ public TkTextureResource Small;
        /* 0x108 */ public GcScannerIconHighlightTypes Highlight;
    }
}
