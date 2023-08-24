namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFB73DDC290CD191, NameHash = 0xA0F8CF4879F9AA03)]
    public class GcMissionSequenceWaitForCompletionMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A ReturnToOptionalScanEvent;
        /* 0xA0 */ public NMSString0x20A MessageWhenInterstellar;
        /* 0xC0 */ public NMSString0x10 CompletionCost;
        /* 0xD0 */ public NMSString0x80 DebugText;
    }
}
