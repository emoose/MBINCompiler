using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x1DDE5EBDD5ABFEDC, NameHash = 0x85905E340468CC13)]
    public class GcScannerIcon : NMSTemplate
    {
        /* 0x000 */ public TkTextureResource Main;
        /* 0x084 */ public TkTextureResource Small;
        /* 0x108 */ public GcScannerIconHighlightTypes Highlight;
    }
}
