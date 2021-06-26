using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xC43CCD85B6DEFABA, NameHash = 0x65394132CAA31326)]
    public class GcMissionConditionIsLookingAtAnomaly : NMSTemplate
    {
        public float FOV;
        public float MaxDistance;
    }
}