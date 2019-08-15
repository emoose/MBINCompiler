using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDECC7934CF57BB65)]
    public class GcAudioWwiseEvents : NMSTemplate
    {
        public uint AkEvent; // should be an enum, but it will be massive...
    }
}
