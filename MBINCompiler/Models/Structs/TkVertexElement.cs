using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
	public class TkVertexElement : NMSTemplate
	{
		public int SemanticID;
		public int Size;
		public int Type; // 0x140b(Vec4) or 0x1401(Vec2)
        public int Offset;
		public int Normalise;

        public int Instancing;
		public string[] InstancingValues()
        {
            return new[] { "PerVertex", "PerModel" };
		}

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string PlatformData;
	}
}