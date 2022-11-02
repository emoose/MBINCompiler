using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD0564895EF810A9F, NameHash = 0xBEE79269D7359654)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0 */ public TkProceduralTextureLayer[] Layers;
    }
}
