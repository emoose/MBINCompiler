using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x148, GUID = 0xD28B961C29B6B991, NameHash = 0x7596FBA2C232AC37)]
    public class GcClothPiece : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x20 DebugName;
        /* 0x021 */ public NMSString0x20 RenderMeshNodeName;
        /* 0x044 */ public int NumPointsInRenderMeshI;
        /* 0x048 */ public int NumPointsInRenderMeshJ;
        /* 0x04C */ public int VertexRemappingPermutation;
        /* 0x050 */ public int NumSimPointsI;
        /* 0x054 */ public int NumSimPointsJ;
        /* 0x058 */ public float ClothHeight;
        /* 0x05C */ public float ParticleRadius;
        /* 0x060 */ public float StaticFriction;
        /* 0x064 */ public float ParticleDamping;
        /* 0x068 */ public float GlobalDamping;
        /* 0x06C */ public float StandardGravityScale;
        /* 0x070 */ public bool ApplyMoreGravityAtBottom;
        /* 0x074 */ public float GravityScaleAtBottom;
        /* 0x078 */ public NMSString0x20 InitialShapeReferenceBone;
        /* 0x098 */ public bool InitialShapeIsCapeLike;
        /* 0x09C */ public GcCapeLikeInitialShape CapeLikeInitialShape;
        /* 0x0D0 */ public GcRectangularInitialShape RectangularInitialShape;
        /* 0x100 */ public int NumFixedTopRowsInInitialShape;
        /* 0x104 */ public int NumExtraFixedBoundaryRowsInInitialShape;
        /* 0x108 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x118 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x128 */ public List<GcClothCollisionBone> CollisionBones;
        /* 0x138 */ public List<NMSString0x20> NodesToRemove;
    }
}
