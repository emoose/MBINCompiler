namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceEndScanEvent : NMSTemplate      // size: 0xA0
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Event;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
