using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xCB4DFDB459F73DAD, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        public GcBiomeType Type;
        public bool AnyInfested;
    }
}