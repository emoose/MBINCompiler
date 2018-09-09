namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, Size = 0xA0, GUID = 0x7F57711DB208B3F0)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Event;
        [NMS(Size = 0x80)]
        /* 0x20 */ public string DebugText;
    }
}
