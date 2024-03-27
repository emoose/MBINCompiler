using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD4A075B52F129B27, NameHash = 0x6AA5D445686C3721)]
    public class TkProceduralTextureLayer : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float Probability;
        /* 0x18 */ public NMSString0x10 Group;
        /* 0x28 */ public bool SelectToMatchBase;
        /* 0x30 */ public List<TkProceduralTexture> Textures;
    }
}
