namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8ED76BBC5E9E0941, NameHash = 0x8A1CA9D7910E2ABB)]
    public class GcJudgementMessageOptions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageInSettlement;
        /* 0x080 */ public NMSString0x80 MessageInSettlementSystem;
        /* 0x100 */ public NMSString0x80 MessageOutOfSettlementSystem;
    }
}
