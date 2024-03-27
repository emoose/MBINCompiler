using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2BC2C0094D0DA23, NameHash = 0xC016E2C8C89F4CF4)]
    public class GcRagdollBone : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 Name;
        /* 0x048 */ public List<NMSString0x40> NodeNames;
        /* 0x058 */ public List<Vector3f> NodeTransformInBone_Position;
        /* 0x068 */ public List<Vector3f> NodeTransformInBone_AxisX;
        /* 0x078 */ public List<Vector3f> NodeTransformInBone_AxisY;
        /* 0x088 */ public List<Vector3f> NodeTransformInBone_AxisZ;
        /* 0x098 */ public NMSString0x40 ParentNodeName;
        /* 0x0E0 */ public Vector3f ParentNodeTransformInBone_Position;
        /* 0x0F0 */ public Vector3f ParentNodeTransformInBone_AxisX;
        /* 0x100 */ public Vector3f ParentNodeTransformInBone_AxisY;
        /* 0x110 */ public Vector3f ParentNodeTransformInBone_AxisZ;
        /* 0x120 */ public Vector3f JointPosition;
        /* 0x130 */ public AxisSpecification LimitingTwistAxis;
        /* 0x150 */ public AxisSpecification LimitingPlaneAxis;
        /* 0x170 */ public AxisSpecification LimitedTwistAxis;
        /* 0x190 */ public AxisSpecification LimitedPlaneAxis;
        /* 0x1B0 */ public float TwistLimitDeg;
        /* 0x1B4 */ public float ConeLimitDeg;
        /* 0x1B8 */ public float PlaneMaxAngleDeg;
        /* 0x1BC */ public float PlaneMinAngleDeg;
        /* 0x1C0 */ public Vector3f AabbMin;
        /* 0x1D0 */ public Vector3f AabbMax;
        /* 0x1E0 */ public Vector3f CollisionRotationDeg;
        /* 0x1F0 */ public Vector3f CollisionTranslation;
        /* 0x200 */ public Vector3f CollisionScale;
        // size: 0x3
        public enum CollisionShapeEnum : uint {
            Box,
            Capsule,
            Sphere,
        }
        /* 0x210 */ public CollisionShapeEnum CollisionShape;
        /* 0x214 */ public int CapsuleLongAxisIndex;
        // size: 0x7
        public enum LimbTypeEnum : uint {
            LeftUpperArm,
            RightUpperArm,
            LeftUpperLeg,
            RightUpperLeg,
            LeftFoot,
            RightFoot,
            Other,
        }
        /* 0x218 */ public LimbTypeEnum LimbType;
        /* 0x220 */ public Vector3f CentreOfMass;
        /* 0x230 */ public List<GcChildNode> ChildNodes;
    }
}
