using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, Alignment = 0x8, GUID = 0x5DFFEFFFBF758C28, NameHash = 0xCE47B2B5ED8374E1)]
    public class GcCreatureGenerationDomainTable : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public List<GcCreatureGenerationDomainEntry> Tables;
        /* 0x20 */ public float ChanceOfHemisphereLimit;
        /* 0x24 */ public int MaxToHemisphereLimit;
    }
}
