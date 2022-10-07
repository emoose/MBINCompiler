using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DEB8D16BD1A72D8, NameHash = 0x3FE2B5A3043E562F)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        /* 0x4 */ public bool OverrideAllDomains;
        /* 0x8 */ public GcCreatureGenerationWeightedList Archetypes;
    }
}
