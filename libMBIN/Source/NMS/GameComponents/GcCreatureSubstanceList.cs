namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDE0E4BE851825D6, NameHash = 0x54F731B7)]
    public class GcCreatureSubstanceList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureType;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Item;
    }
}
