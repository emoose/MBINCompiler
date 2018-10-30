using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xD7404F5F69F6404)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string DeathEffect;
        /* 0x28 */ public List<GcReplacementEffectData> ReplacementImpacts;
    }
}
