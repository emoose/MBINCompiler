namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string WaitMessageID;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
