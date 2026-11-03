using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6828351B3DCCCE9, NameHash = 0xCA1CBBFC)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Vector3f AnimOffset;
        [NMS(Index = 7)]
        /* 0x010 */ public Vector3f Offset;
        [NMS(Index = 8)]
        /* 0x020 */ public Vector3f RotationOffset;
        [NMS(Index = 10)]
        /* 0x030 */ public Vector3f VROffset;
        [NMS(Index = 0)]
        /* 0x040 */ public NMSString0x20A PartName;
        [NMS(Index = 15)]
        /* 0x060 */ public NMSString0x10 DefaultRidingAnim;
        [NMS(Index = 14)]
        /* 0x070 */ public NMSString0x10 IdleRidingAnim;
        [NMS(Index = 16)]
        /* 0x080 */ public List<GcCreatureRidingAnimation> RidingAnims;
        [NMS(Index = 11)]
        /* 0x090 */ public float HeadCounterRotation;
        [NMS(Index = 12)]
        /* 0x094 */ public float LegSpreadOffset;
        [NMS(Index = 3)]
        /* 0x098 */ public float MaxScale;
        [NMS(Index = 2)]
        /* 0x09C */ public float MinScale;
        [NMS(Index = 4)]
        /* 0x0A0 */ public NMSString0x100 AdditionalScaleJoint;
        [NMS(Index = 1)]
        /* 0x1A0 */ public NMSString0x100 JointName;
        [NMS(Index = 5)]
        /* 0x2A0 */ public bool BreakIfNotSelected;
        [NMS(Index = 13)]
        /* 0x2A1 */ public bool OverrideAnims;
        [NMS(Index = 6)]
        /* 0x2A2 */ public bool RelativeOffset;
    }
}
