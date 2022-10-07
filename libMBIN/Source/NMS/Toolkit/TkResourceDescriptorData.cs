using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xABD3B610D1E296E6, NameHash = 0xC24CCFE195015403)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public NMSString0x80 Name;
        /* 0xA0 */ public List<NMSString0x80> ReferencePaths;
        /* 0xB0 */ public float Chance;
        /* 0xB8 */ public List<NMSTemplate> Children;
    }
}
