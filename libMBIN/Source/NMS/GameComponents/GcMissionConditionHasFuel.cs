using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC724E645A16B505E)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        public GcStatsTypes TargetStat;
        public int Amount;
        [NMS(Size = 0x10)]
        public string SpecificTechID;
    }
}
