namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD498A2B13A82D839, NameHash = 0x93BCED5E009EBA47)]
    public class GcRewardSettlementCustomJudgement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CustomJudgement;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public bool CanOverrideNonCustomJudgement;
    }
}
