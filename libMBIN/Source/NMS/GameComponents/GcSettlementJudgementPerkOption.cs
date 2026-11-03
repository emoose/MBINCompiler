namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1978D329FF8F2892, NameHash = 0xAF730E13)]
    public class GcSettlementJudgementPerkOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Perk;
        [NMS(Index = 1)]
        /* 0x10 */ public float PerkChance;
    }
}
