using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
	public class TkVertexLayout : NMSTemplate
	{
		public int ElementCount;
		public int Stride;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string PlatformData;

		public List<TkVertexElement> VertexElements;
	}
}