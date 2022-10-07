namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0F049A601EDA573, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 WaitMessageID;
        /* 0x90 */ public NMSString0x80 DebugText;
    }
}
