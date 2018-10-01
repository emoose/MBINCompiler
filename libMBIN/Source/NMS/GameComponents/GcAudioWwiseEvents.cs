using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC5653EB31BD14D0D, Broken = true)]
    public class GcAudioWwiseEvents : NMSTemplate
    {
        public uint AkEvent; // should be an enum, but it will be massive...
    }
}
