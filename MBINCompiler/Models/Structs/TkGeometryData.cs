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
        public List<float> VertexStream;
        public List<float> SmallVertexStream;

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(IndexBuffer):
                    reader.Align(8, 0);
                    long listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32() * ((Indices16Bit == 1) ? 2 : 1); // Adjust size
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

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

                case nameof(VertexStream):
                case nameof(SmallVertexStream):
                    reader.Align(8, 0);
                    listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    listStartOffset = reader.ReadInt64();
                    numEntries = reader.ReadInt32();
                    listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

                    listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    List<float> vertices = new List<float>();
                    while (reader.BaseStream.Position < (listPosition + listStartOffset + numEntries))
                    {
                        vertices.Add(reader.ReadHalfLittle());
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8, 0);

                    return vertices;
            }

            return null;
        }
    }
}