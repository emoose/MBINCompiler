using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0E99F6B225B893276)]
    public class TkCameraWanderData : NMSTemplate
    {
        public bool CamWander;
        public float CamWanderPhase;
        public float CamWanderAmplitude;
    }
}
