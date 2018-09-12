using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B7EE815D03617CCC, Broken = true)]
    public class GcAudioWwiseEvents : NMSTemplate
    {
        public uint AkEvent; // should be an enum, but it will be massive...
    }
}
