using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    long listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"DeserializeList start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32() * ((Indices16Bit == 1) ? 2 : 1); // Adjust size
                    uint listMagic = reader.ReadUInt32();
                    if (listMagic != 0xAAAAAA01 && listMagic != 1)
                        throw new Exception($"Invalid list read, magic 0x{listMagic:X} expected 0xAAAAAA01 / 0x1");

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    var indices = new List<int>();
                    for (int i = 0; i < numEntries; i++)
                    {
                        if (Indices16Bit == 1)
                        {
                            indices.Add((int)reader.ReadUInt16());
                        }
                        else
                        {
                            indices.Add((int)reader.ReadUInt32());
                        }
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8, 0);

                    return indices;
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