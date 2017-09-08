namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceStartScanEvent : NMSTemplate          // size: 0xB0
    {
        /* 0x000 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string Event;
        /* 0x028 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x02C */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
