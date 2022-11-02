using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B4D66DED627BC7F, NameHash = 0x7596FBA2C232AC37)]
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
        /* 0x0AC */ public float StandardGravityScale;
        /* 0x0B0 */ public NMSString0x40 InitialShapeReferenceBone;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum {
            Multiply,
            Divide,
            Ignore
        }
        /* 0x0F0 */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum {
            Multiply,
            Divide,
            Ignore
        }
        /* 0x0F4 */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum {
            Multiply,
            Divide,
            Ignore
        }
        /* 0x0F8 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x4
        public enum InitialShapeSourceEnum {
            CapeLike,
            Rectangular,
            TakenFromSource,
            Saved
        }
        /* 0x0FC */ public InitialShapeSourceEnum InitialShapeSource;
        /* 0x100 */ public GcCapeLikeInitialShape CapeLikeInitialShape;
        /* 0x190 */ public GcRectangularInitialShape RectangularInitialShape;
        /* 0x1D0 */ public List<Vector3f> InitialShapePoints;
        /* 0x1E0 */ public List<GcClothCollisionBone> CollisionBones;
        /* 0x1F0 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x200 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x210 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        /* 0x220 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        /* 0x270 */ public GcClothAttractor Attractor;
        /* 0x310 */ public List<NMSString0x40> NodesThatMustBePresent;
        /* 0x320 */ public List<NMSString0x40> NodesToHide;
        /* 0x330 */ public GcAdvancedTweaks Advanced;
        /* 0x348 */ public bool VertexBasedClothRenderingEnabled;
        /* 0x349 */ public bool AttachedNodesEnabled;
        /* 0x350 */ public List<GcAttachedNode> AttachedNodes;
        /* 0x360 */ public float AttachedNodesOverallBlendStrength;
        /* 0x368 */ public List<int> DeletedSimPoints;
        /* 0x378 */ public List<int> DeletedConstraintsI;
        /* 0x388 */ public List<int> DeletedConstraintsJ;
        /* 0x398 */ public bool LeaveRenderedTrianglesUnaffected;
    }
}
