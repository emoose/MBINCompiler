using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x88, GUID = 0x5C0A92328BBE7F0F, NameHash = 0xE2442EEFEFEF9518)]
    public class TkNoiseCaveData : NMSTemplate
    {
        public TkNoiseFeatureData Mouth;
        public TkNoiseFeatureData Tunnel;
    }
}