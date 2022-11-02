using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88983B208EFB6775, NameHash = 0x79652C883CA60AE)]
    public class GcMissionSequenceWaitForRepair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcStatsTypes TargetStat;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
