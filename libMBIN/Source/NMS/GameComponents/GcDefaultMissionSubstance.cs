using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x90B21784B9071E05, NameHash = 0x2D0C96FA112A44AA)]
    // Note: This is called "GcDefaulMissionSubstance", fixed the spelling mistake...
    public class GcDefaultMissionSubstance : NMSTemplate
    {
        public GcSubstanceTableEnum Substance;
    }
}