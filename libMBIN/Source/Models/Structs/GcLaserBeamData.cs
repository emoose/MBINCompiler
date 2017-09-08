using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x10)]
    public class GcLaserBeamData : NMSTemplate      // size: 0x1A0
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string BeamFile;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string BeamCoreFile;
        /* 0x110 */ public float Width;
        /* 0x114 */ public float HitWidth;
        /* 0x118 */ public float PulseFrequency;
        /* 0x11C */ public float PulseAmplitude;
        /* 0x120 */ public float StartTime;
        /* 0x124 */ public float EndTime;
        /* 0x128 */ public GcAudioWwiseEvents AudioStart;
        /* 0x12C */ public GcAudioWwiseEvents AudioStop;
        /* 0x130 */ public GcAudioWwiseEvents AudioOverheat;
        /* 0x134 */ public int Damage;
        [NMS(Size = 0x10)]
        /* 0x138 */ public string PlayerDamage;
        [NMS(Size = 0x10)]
        /* 0x148 */ public string ImpactEffect;
        /* 0x158 */ public List<GcProjectileImpactData> Impacts;
        /* 0x168 */ public float HitRate;
        /* 0x16C */ public float RagdollPush;
        /* 0x170 */ public float MiningHitRate;
        /* 0x174 */ public bool HasLight;
        /* 0x175 */ public bool CanMine;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding176;
        /* 0x178 */ public float LightScale;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding17C;
        /* 0x180 */ public Colour LightColour;
        /* 0x190 */ public Colour Colour;
    }

}
