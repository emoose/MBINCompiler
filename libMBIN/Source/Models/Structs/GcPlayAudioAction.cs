namespace libMBIN.Models.Structs
{
    public class GcPlayAudioAction : NMSTemplate        // size: 0x88
    {
        [NMS(Size = 0x80)]
        public string Sound;
        public bool UseOcclusion;
        public float OcclusionRadius;
    }
}
