using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C43CCD85B6DEFABA)]
    public class GcMissionConditionIsLookingAtAnomaly : NMSTemplate
    {
        public float FOV;
        public float MaxDistance;
    }
}
