namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAE423F5DA11BB51, NameHash = 0x9384C040)]
    public class GcRegionHotspotSubstance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 SubstanceId;
        [NMS(Index = 1)]
        /* 0x10 */ public int AmountCost;
        [NMS(Index = 2)]
        /* 0x14 */ public int SubstanceYeild;
    }
}
