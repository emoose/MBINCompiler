using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDECC7934CF57BB65, SubGUID = 0x8B94093DC3901046)]
    public class GcAudioWwiseEvents : NMSTemplate
    {
        public uint AkEvent; // should be an enum, but it will be massive...
    }
}
