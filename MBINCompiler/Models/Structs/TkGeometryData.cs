using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MBINCompiler.Models.Structs
{
	public class TkGeometryData : NMSTemplate
	{
		public int VertexCount;
		public int IndexCount;
		public int Indices16Bit;

        public List<TkJointBindingData> JointBindings;
		public List<TkJointExtentData> JointExtents;
		
		public List<int> JointMirrorPairs;
        public List<TkJointMirrorAxis> JointMirrorAxes;
		
		public List<int> SkinMatrixLayout;
		public List<int> MeshVertRStart;
		public List<int> MeshVertREnd;
		public List<int> MeshBaseSkinMat;
		public List<Vector4f> MeshAABBMin;
		public List<Vector4f> MeshAABBMax;
		
		public TkVertexLayout VertexLayout;
		public TkVertexLayout SmallVertexLayout;
		
		public List<int> IndexBuffer;
		/*public List<int> VertexStream;
		public List<int> SmallVertexStream;*/

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;
            switch(fieldName)
            {
                case "IndexBuffer":
                    if (Indices16Bit == 1)
                    {
                        
                    } else
                    {

                    }
                    return null;
                case "VertexStream":
                    return null;
                case "SmallVertexStream":
                    return null;
                default:
                    return null;
            }
        }
    }
}