using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x71E36E603CED2E6E, NameHash = 0xA74EA06001E7577E)]
    public class TkGeometryData : NMSTemplate
    {
        /* 0x000 */ public int VertexCount;
        /* 0x004 */ public int IndexCount;
        /* 0x008 */ public int Indices16Bit;
        /* 0x00C */ public int CollisionIndexCount;
        /* 0x010 */ public List<TkJointBindingData> JointBindings;
        /* 0x020 */ public List<TkJointExtentData> JointExtents;
        /* 0x030 */ public List<int> JointMirrorPairs;
        /* 0x040 */ public List<TkJointMirrorAxis> JointMirrorAxes;
        /* 0x050 */ public List<int> SkinMatrixLayout;
        /* 0x060 */ public List<int> MeshVertRStart;
        /* 0x070 */ public List<int> MeshVertREnd;
        /* 0x080 */ public List<int> BoundHullVertSt;
        /* 0x090 */ public List<int> BoundHullVertEd;
        /* 0x0A0 */ public List<int> MeshBaseSkinMat;
        /* 0x0B0 */ public List<Vector4f> MeshAABBMin;
        /* 0x0C0 */ public List<Vector4f> MeshAABBMax;
        /* 0x0D0 */ public List<Vector4f> BoundHullVerts;
        /* 0x0E0 */ public TkVertexLayout VertexLayout;
        /* 0x100 */ public TkVertexLayout SmallVertexLayout;
        /* 0x120 */ public List<int> IndexBuffer;
        /* 0x130 */ public List<TkMeshMetaData> StreamMetaDataArray;
    }
}
