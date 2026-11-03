using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFD982333355248, NameHash = 0x89B31C13)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 8)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 7)]
        /* 0x30 */ public int InSystemRerolls;
        [NMS(Index = 1)]
        /* 0x34 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Index = 0)]
        /* 0x38 */ public GcScanEventTableType Table;
        [NMS(Index = 3)]
        /* 0x3C */ public float Time;
        [NMS(Index = 5)]
        /* 0x40 */ public bool AllowOtherPlayersBase;
        [NMS(Index = 4)]
        /* 0x41 */ public bool DoAerialScan;
        [NMS(Index = 6)]
        /* 0x42 */ public bool IgnoreIfAlreadyActive;
    }
}
