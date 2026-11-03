namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9127CAFE7F7D809, NameHash = 0xE7174683)]
    public class GcCreatureGenerationWeightedListDomainEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Archetype;
        [NMS(Index = 0, MxmlName = "Weight ")]
        /* 0x10 */ public float Weight;
    }
}
