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
            switch(fieldName)
            {
                case "IndexBuffer":
                    reader.Align(8, 0);
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
                case "SmallVertexStream":
                    reader.Align(8, 0);
                    listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"DeserializeList start 0x{listPosition:X}");

                    listStartOffset = reader.ReadInt64();
                    numEntries = reader.ReadInt32();
                    listMagic = reader.ReadUInt32();
                    if (listMagic != 0xAAAAAA01 && listMagic != 1)
                        throw new Exception($"Invalid list read, magic 0x{listMagic:X} expected 0xAAAAAA01 / 0x1");

                    listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    List<float> vertices = new List<float>();
                    while (reader.BaseStream.Position < (listPosition + listStartOffset + numEntries))
                    {
                        vertices.Add((float)Extensions.ReadHalfLittle(reader));
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8, 0);

                    return vertices;
                default:
                    return null;
            }
        }
    }

    // Thank you to HugoPeters for this class :
    // https://github.com/HugoPeters/NMS-Tools/blob/master/NMS-View/Source/NMSView/NMSView.Windows/HalfHelper.cs
    public static class Extensions
    {
        public static float ReadHalfLittle(this BinaryReader binaryReader)
        {
            UInt16 u = binaryReader.ReadUInt16();
            int sign = (u >> 15) & 0x00000001;
            int exp = (u >> 10) & 0x0000001F;
            int mant = u & 0x000003FF;

            exp = exp + (127 - 15);

            int i = (sign << 31) | (exp << 23) | (mant << 13);
            byte[] buff = BitConverter.GetBytes(i);

            return BitConverter.ToSingle(buff, 0);
        }

        public static float ToFloat(UInt16 u)
        {
            // UInt16 u = binaryReader.ReadUInt16();
            int sign = (u >> 15) & 0x00000001;
            int exp = (u >> 10) & 0x0000001F;
            int mant = u & 0x000003FF;

            exp = exp + (127 - 15);

            int i = (sign << 31) | (exp << 23) | (mant << 13);
            byte[] buff = BitConverter.GetBytes(i);

            return BitConverter.ToSingle(buff, 0);
        }

        public static UInt16 ToHalf(this float f)
        {
            byte[] bytes = BitConverter.GetBytes((double)f);
            ulong bits = BitConverter.ToUInt64(bytes, 0);
            ulong exponent = bits & 0x7ff0000000000000L;
            ulong mantissa = bits & 0x000fffffffffffffL;
            ulong sign = bits & 0x8000000000000000L;
            int placement = (int)((exponent >> 52) - 1023);
            if (placement > 15 || placement < -14)
                return ToHalf(-1.0f);

            UInt16 exponentBits = (UInt16)((15 + placement) << 10);
            UInt16 mantissaBits = (UInt16)(mantissa >> 42);
            UInt16 signBits = (UInt16)(sign >> 48);
            return (UInt16)(exponentBits | mantissaBits | signBits);
        }
    }
}