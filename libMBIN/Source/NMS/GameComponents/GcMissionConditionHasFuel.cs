using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5EEB19C3B738D569, Broken = true)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        public GcStatsTypes TargetStat;
        public int Amount;
    }
}
