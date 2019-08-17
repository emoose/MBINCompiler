using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8F1C9CDF19E76136, Broken = true, SubGUID = 0x1E4A17D964305DC4)]
    public class GcMissionConditionTechnologyKnown : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
    }
}
