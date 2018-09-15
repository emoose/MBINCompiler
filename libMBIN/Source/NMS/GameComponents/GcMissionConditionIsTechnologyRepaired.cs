using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA7B4537251A00C02)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;        // I bet this has got bigger...
        public int RepairedComponents;
    }
}
