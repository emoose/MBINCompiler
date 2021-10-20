using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x303FCB7CE848E221, NameHash = 0x1E4A17D964305DC4)]
    public class GcMissionConditionTechnologyKnown : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
    }
}
