using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE99F6B225B893276, SubGUID = 0xF23D44C69F4360D8)]
    public class TkCameraWanderData : NMSTemplate
    {
        public bool CamWander;
        public float CamWanderPhase;
        public float CamWanderAmplitude;
    }
}
