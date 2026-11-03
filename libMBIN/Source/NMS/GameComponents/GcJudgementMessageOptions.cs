namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FE211E6C62D7327, NameHash = 0x2F83F7D4)]
    public class GcJudgementMessageOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x80 MessageInSettlement;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x80 MessageInSettlementSystem;
        [NMS(Index = 2)]
        /* 0x100 */ public NMSString0x80 MessageOutOfSettlementSystem;
    }
}
