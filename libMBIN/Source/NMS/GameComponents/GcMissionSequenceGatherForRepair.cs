using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x118, GUID = 0x8E2EA875ACC910CB, NameHash = 0x535215E1DEB68BB2)]
    public class GcMissionSequenceGatherForRepair : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x088 */ public NMSString0x10 GatherResource;
        /* 0x098 */ public NMSString0x80 DebugText;
    }
}
