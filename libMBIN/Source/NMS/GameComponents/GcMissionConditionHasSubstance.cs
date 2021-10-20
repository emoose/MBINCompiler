using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xD332F70D80FD64DE, NameHash = 0x9D5EE4FB6274CF9E)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default;
        public GcSubstanceTableEnum Substance;
        public int Amount;
        public bool TakeAmountFromSeasonData;
    }
}