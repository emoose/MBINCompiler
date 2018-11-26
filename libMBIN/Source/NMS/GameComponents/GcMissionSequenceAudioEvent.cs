using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xB6F31CE03523BF82)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
