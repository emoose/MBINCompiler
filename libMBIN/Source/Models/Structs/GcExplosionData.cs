using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xC0, GUID = 0x3C366B1E74C90E62)]
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public TkModelResource Model;
        /* 0x94 */ public GcAudioWwiseEvents AkEvent;
        /* 0x98 */ public List<GcDebrisData> Debris;
        /* 0xA8 */ public float Life;                   // 40400000
        /* 0xAC */ public float Scale;                  // 3F800000
        /* 0xB0 */ public float DistanceScale;          // 42480000
        /* 0xB4 */ public float DistanceScaleMax;
        /* 0xB8 */ public bool CamShake;                // di
        /* 0xB9 */ public bool CamShakeSpace;
        /* 0xBC */ public float MaxSpawnDistance;       // edi
    }
}
