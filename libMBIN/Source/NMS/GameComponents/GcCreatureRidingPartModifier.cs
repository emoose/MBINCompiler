using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66B10ABD887EC31F, NameHash = 0xB9A3955D41C87D67)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A PartName;
        /* 0x020 */ public NMSString0x100 JointName;
        /* 0x120 */ public float MinScale;
        /* 0x124 */ public float MaxScale;
        /* 0x128 */ public NMSString0x100 AdditionalScaleJoint;
        /* 0x228 */ public bool BreakIfNotSelected;
        /* 0x229 */ public bool RelativeOffset;
        /* 0x230 */ public Vector3f Offset;
        /* 0x240 */ public Vector3f RotationOffset;
        /* 0x250 */ public Vector3f VROffset;
        /* 0x260 */ public float HeadCounterRotation;
        /* 0x264 */ public float LegSpreadOffset;
        /* 0x268 */ public bool OverrideAnims;
        /* 0x270 */ public NMSString0x10 IdleRidingAnim;
        /* 0x280 */ public NMSString0x10 DefaultRidingAnim;
        /* 0x290 */ public List<GcCreatureRidingAnimation> RidingAnims;
    }
}
