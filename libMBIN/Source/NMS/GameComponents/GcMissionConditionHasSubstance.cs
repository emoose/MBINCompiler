using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x959D4E2E88193C9B, NameHash = 0x9D5EE4FB6274CF9E)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default;
        public GcSubstanceTableEnum Substance;
        public int Amount;

    }
}