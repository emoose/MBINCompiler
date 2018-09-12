using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C30E8192B2598E1A)]
    public class GcPlayAudioAction : NMSTemplate        // size: 0x88
    {
        [NMS(Size = 0x80)]
        public string Sound;
        public bool UseOcclusion;
        public float OcclusionRadius;
    }
}
