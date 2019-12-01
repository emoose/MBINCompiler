using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, Alignment = 0x10, GUID = 0xCFC4E29700DBAD43, NameHash = 0xCBC8926C6C9D9A51)]
    public class GcCreatureRidingData : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x000 */ public string JointName;
        [NMS(Size = 0x100)]
        /* 0x100 */ public string AdditionalScaleJoint;
        /* 0x200 */ public Vector3f Offset;
        /* 0x210 */ public Vector3f RotationOffset;
        /* 0x220 */ public Vector3f VROffset;
        /* 0x230 */ public float UprightStrength;
        /* 0x234 */ public bool LegSpread;
        /* 0x238 */ public float ScaleForNeutralLegSpread;
        /* 0x23C */ public float ScaleForMinLegSpread;
        /* 0x240 */ public float ScaleForMaxLegSpread;
        /* 0x244 */ public float HeadPitch;
        /* 0x248 */ public List<GcCreatureRidingPartModifier> PartModifiers;  // A guess...
        [NMS(Size = 0x10)]
        /* 0x258 */ public string IdleRidingAnim;
        [NMS(Size = 0x10)]
        /* 0x268 */ public string DefaultRidingAnim;
        /* 0x278 */ public List<GcCreatureRidingAnimation> RidingAnims;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x288 */ public byte[] EndPadding;
    }
}
