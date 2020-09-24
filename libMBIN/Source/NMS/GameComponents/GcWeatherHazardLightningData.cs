using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x160, Alignment = 0x8, GUID = 0xD4EB4CC418A78EC4, NameHash = 0xD85F7F00F1F64BD1)]
    public class GcWeatherHazardLightningData : NMSTemplate
    {
        /* 0x000 */ public TkModelResource IndicatorDecal;
        /* 0x084 */ public TkModelResource StaticDecal;
        /* 0x108 */ public float MinRadius;
        /* 0x10C */ public float MaxRadius;
        /* 0x110 */ public float EarliestImpact;
        /* 0x114 */ public float EarliestImpactFirstInstance;
        /* 0x118 */ public float StormDuration;
        /* 0x11C */ public int MinStrikes;
        /* 0x120 */ public int MaxStrikes;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x124 */ public byte[] Padding124;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string ShakeID;
        [NMS(Size = 0x10)]
        /* 0x138 */ public string ImpactParticle;
        [NMS(Size = 0x10)]
        /* 0x148 */ public string DamageID;
        /* 0x158 */ public float FullDamageRadius;
        /* 0x15C */ public float DamageRadius;
    }
}
