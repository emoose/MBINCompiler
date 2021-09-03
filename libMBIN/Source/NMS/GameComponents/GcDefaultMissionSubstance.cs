using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xC3719BD4DD781B2D, NameHash = 0x2D0C96FA112A44AA)]
    // Note: This is called "GcDefaulMissionSubstance", fixed the spelling mistake...
    public class GcDefaultMissionSubstance : NMSTemplate
    {
        public GcSubstanceTableEnum Substance;
    }
}