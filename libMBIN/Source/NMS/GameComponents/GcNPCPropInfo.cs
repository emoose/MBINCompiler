using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x854C615051B92EF, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Model;
        /* 0x080 */ public bool Hologram;
        /* 0x090 */ public GcScanEffectData ScanEffect;
        /* 0x0E0 */ public NMSString0x40 ScanEffectNodeName;
        /* 0x120 */ public float Weight;
        /* 0x124 */ public GcTechnologyCategory ShopType;
    }
}
