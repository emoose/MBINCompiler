using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
	public class TkGeometryData : NMSTemplate
	{
		public int VertexCount;
		public int IndexCount;
		public int Indices16Bit;

		// I have an invalid list read Exception here maybe it is linked to the primitive arrays not being supported ?
        public List<TkJointBindingData> JointBindings;
		/*public List<TkJointExtentData> JointExtents;
		
		public byte[] JointMirrorPairs;
		
		public List<TkJointMirrorAxis> JointMirrorAxes;
		
		public byte[] SkinMatrixLayout;
		public byte[] MeshVertRStart;
		public byte[] MeshVertREnd;
		public byte[] MeshBaseSkinMat;
		public byte[] MeshAABBMin;
		public byte[] MeshAABBMax;
		
		public TkVertexLayout VertexLayout;
		public TkVertexLayout SmallVertexLayout;
		
		public byte[] IndexBuffer;
		public byte[] VertexStream;
		public byte[] SmallVertexStream;*/
    }
}