using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x5972CF272DDD8DCA, NameHash = 0x3FE2B5A3043E562F)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        /* 0x4 */ public bool OverrideAllDomains;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] Padding5;
        /* 0x8 */ public GcCreatureGenerationWeightedList Archetypes;
    }
}
