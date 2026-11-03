using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9603ADC81D78A12, NameHash = 0x2D8333E5)]
    public class GcModelSpaceFollowerEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public AxisSpecification FollowingJointRotateAxis;
        [NMS(Index = 12)]
        /* 0x20 */ public AxisSpecification ReferenceAxis;
        [NMS(Index = 13)]
        /* 0x40 */ public AxisSpecification ReferenceRotationAxis;
        [NMS(Index = 11)]
        /* 0x60 */ public List<GcModelSpaceFollowerBoneEntry> FollowedJoints;
        [NMS(Index = 4)]
        /* 0x70 */ public float AngleOffsetRoot;
        [NMS(Index = 5)]
        /* 0x74 */ public float AngleOffsetTip;
        // size: 0x3
        public enum BoneFollowAngleModeEnum : uint {
            Min,
            Max,
            Average,
        }
        [NMS(Index = 10)]
        /* 0x78 */ public BoneFollowAngleModeEnum BoneFollowAngleMode;
        [NMS(Index = 3)]
        /* 0x7C */ public float FollowingAngleMax;
        [NMS(Index = 2)]
        /* 0x80 */ public float FollowingAngleMin;
        [NMS(Index = 8)]
        /* 0x84 */ public float FollowingAngleScaleRoot;
        [NMS(Index = 9)]
        /* 0x88 */ public float FollowingAngleScaleTip;
        [NMS(Index = 6)]
        /* 0x8C */ public float SmoothReturnTimeRoot;
        [NMS(Index = 7)]
        /* 0x90 */ public float SmoothReturnTimeTip;
        [NMS(Index = 0)]
        /* 0x94 */ public NMSString0x100 FollowingJoint;
    }
}
