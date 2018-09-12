using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x24B0E375003A3D0C)]
    public class GcMissionSequenceGatherForRepair : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        [NMS(Size = 0x10)]
        /* 0x088 */ public string GatherResource;
        [NMS(Size = 0x80)]
        /* 0x098 */ public string DebugText;
    }
}
