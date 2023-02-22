using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABA3C17DBE6EBD46, NameHash = 0x7596FBA2C232AC37)]
    public class GcClothPiece : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 DebugName;
        /* 0x041 */ public NMSString0x40 RenderMeshNodeName;
        /* 0x084 */ public int NumPointsInRenderMeshI;
        /* 0x088 */ public int NumPointsInRenderMeshJ;
        /* 0x08C */ public int VertexRemappingPermutation;
        /* 0x090 */ public int NumSimPointsI;
        /* 0x094 */ public int NumSimPointsJ;
        /* 0x098 */ public float ClothHeight;
        /* 0x09C */ public float ParticleRadius;
        /* 0x0A0 */ public float StaticFriction;
        /* 0x0A4 */ public float DampingWrtFixed;
        /* 0x0A8 */ public float AbsoluteDamping;
        /* 0x0AC */ public float ApplyGameWind;
        /* 0x0B0 */ public float AirSpeedFromMovementSpeedScale;
        /* 0x0B4 */ public float AirSpeedOverallEffect;
        /* 0x0B8 */ public float StandardGravityScale;
        /* 0x0BC */ public NMSString0x40 InitialShapeReferenceBone;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x0FC */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x100 */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x104 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x3
        public enum InitialShapeSourceEnum {
            Rectangular,
            TakenFromRenderMesh,
            Saved,
        }
        /* 0x108 */ public InitialShapeSourceEnum InitialShapeSource;
        /* 0x110 */ public GcRectangularInitialShape RectangularInitialShape;
        /* 0x150 */ public List<Vector3f> InitialShapePoints;
        /* 0x160 */ public List<GcClothCollisionBone> CollisionBones;
        /* 0x170 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x180 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x190 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        /* 0x1A0 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        /* 0x1F0 */ public List<NMSString0x40> NodesThatMustBePresent;
        /* 0x200 */ public List<NMSString0x40> NodesToHide;
        /* 0x210 */ public GcAdvancedTweaks Advanced;
        /* 0x228 */ public bool VertexBasedClothRenderingEnabled;
        /* 0x229 */ public bool AttachedNodesEnabled;
        /* 0x230 */ public List<GcAttachedNode> AttachedNodes;
        /* 0x240 */ public float AttachedNodesOverallBlendStrength;
        /* 0x248 */ public List<int> DeletedSimPoints;
        /* 0x258 */ public List<int> DeletedConstraintsI;
        /* 0x268 */ public List<int> DeletedConstraintsJ;
        /* 0x278 */ public bool LeaveRenderedTrianglesUnaffected;
    }
}
