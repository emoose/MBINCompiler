using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
	public class TkGeometryData : NMSTemplate
	{
		public int VertexCount;
		public int IndexCount;
		public int Indices16Bit;

        public List<TkJointBindingData> JointBindings;
		public List<TkJointExtentData> JointExtents;
		
		public List<FakeInt32> JointMirrorPairs; // This is a List<int> but we use FakeInt32 because this feature is not implemented yet
        public List<TkJointMirrorAxis> JointMirrorAxes;
		
		public List<FakeInt32> SkinMatrixLayout;
		public List<FakeInt32> MeshVertRStart;
		public List<FakeInt32> MeshVertREnd;
		public List<FakeInt32> MeshBaseSkinMat;
		public List<Vector4f> MeshAABBMin;
		public List<Vector4f> MeshAABBMax;
		
		public TkVertexLayout VertexLayout;
		public TkVertexLayout SmallVertexLayout;
		
		/*public List<FakeInt16> IndexBuffer;
		public List<FakeInt32> VertexStream;
		public List<FakeInt32> SmallVertexStream;*/
    }

    public class FakeInt16 : NMSTemplate
    {
        public short value;
    }

    public class FakeInt32 : NMSTemplate
    {
        public int value;
    }
}