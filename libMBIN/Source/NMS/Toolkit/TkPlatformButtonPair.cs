using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0E2FDB3256F6FF4CD)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PlatformId;
        [NMS(Size = 0x10)]
        public string ButtonId;
        public Vector2f Size;
    }

}
