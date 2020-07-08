using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xA4FDC9350C212AB6, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        public GcBiomeType Type;
    }
}