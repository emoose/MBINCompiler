namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA94A18E4960C753, NameHash = 0xA0F8CF4879F9AA03)]
    public class GcMissionSequenceWaitForCompletionMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x80 DebugText;
    }
}
