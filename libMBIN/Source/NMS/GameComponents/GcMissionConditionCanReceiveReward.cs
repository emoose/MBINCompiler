using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x96FEB7E2FEA00BC5)]
    public class GcMissionConditionCanReceiveReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
