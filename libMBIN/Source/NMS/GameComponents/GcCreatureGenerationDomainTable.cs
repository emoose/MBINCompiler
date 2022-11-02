using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC38D5F906F2AA47F, NameHash = 0xCE47B2B5ED8374E1)]
    public class GcCreatureGenerationDomainTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcCreatureGenerationDomainEntry> Tables;
        /* 0x20 */ public float ChanceOfHemisphereLimit;
        /* 0x24 */ public int MaxToHemisphereLimit;
    }
}
