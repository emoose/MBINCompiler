using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public TkModelResource Model;
        public GcAudioWwiseEvents AkEvent;
        public List<GcDebrisData> Debris;
        public float Life;
        public float Scale;
        public float DistanceScale;
        public float DistanceScaleMax;
        public bool CamShake;
        public float MaxSpawnDistance;
    }
}
