using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEED51F72B40464ED, Broken = true)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
    }
}
