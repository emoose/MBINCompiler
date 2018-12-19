using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x54D72601C6AF8371)]
    public class GcMissionConditionPlanetResourceHint : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ResourceHint;
    }
}
