namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEE96C959BE0519F, NameHash = 0xBDDD4819)]
    public class GcRewardSendChatMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 StatusMessageId;
    }
}
