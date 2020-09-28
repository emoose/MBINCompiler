using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x54971262FD29B899, NameHash = 0x9D5EE4FB6274CF9E)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default;
        public GcSubstanceTableEnum Substance;
        public int Amount;

    }
}