using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x29F889A7F413060A)]
    public class GcMissionSequenceWaitForRepair : NMSTemplate       // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
