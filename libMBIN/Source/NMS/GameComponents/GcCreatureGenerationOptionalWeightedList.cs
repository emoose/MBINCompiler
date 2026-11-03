using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF417ACF7BB67FB6F, NameHash = 0x9AC9845E)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcCreatureGenerationWeightedList Archetypes;
        [NMS(Index = 0)]
        /* 0x40 */ public float Probability;
        [NMS(Index = 1)]
        /* 0x44 */ public bool OverrideAllDomains;
    }
}
