using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0D878AA359F11F44D)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x084 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
