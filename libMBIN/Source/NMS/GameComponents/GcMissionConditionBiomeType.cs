using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xED0A1D0C59B50FC9, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        public GcBiomeType Type;
    }
}