using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x94BE14A6488F8913)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        public int Level;
        public TkEqualityEnum Test;
    }
}
