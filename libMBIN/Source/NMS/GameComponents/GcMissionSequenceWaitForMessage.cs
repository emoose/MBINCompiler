namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B465A5702D8A3AF, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 WaitMessageID;
        /* 0x90 */ public NMSString0x10 SetIconWithID;
        /* 0xA0 */ public NMSString0x20 FormatMessageWithSeasonData;
        /* 0xC0 */ public NMSString0x80 DebugText;
    }
}
