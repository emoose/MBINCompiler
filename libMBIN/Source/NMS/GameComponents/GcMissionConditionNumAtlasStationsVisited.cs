using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7F550CECD9352EFD)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        public int Count;
        public TkEqualityEnum Test;
    }
}
