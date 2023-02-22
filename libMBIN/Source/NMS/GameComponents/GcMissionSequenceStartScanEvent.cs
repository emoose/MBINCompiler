using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42C7729718B0EBF7, NameHash = 0x84E26BAA3B367507)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        /* 0x00 */ public GcScanEventTableType Table;
        /* 0x04 */ public GcPlayerMissionParticipantType Participant;
        /* 0x08 */ public NMSString0x20A Event;
        /* 0x28 */ public float Time;
        /* 0x2C */ public bool DoAerialScan;
        /* 0x2D */ public bool AllowOtherPlayersBase;
        /* 0x2E */ public NMSString0x80 DebugText;
    }
}
