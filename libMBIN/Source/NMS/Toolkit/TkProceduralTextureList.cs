using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x111DA9154F0C5DA9, NameHash = 0xBEE79269D7359654)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0 */ public TkProceduralTextureLayer[] Layers;
    }
}
