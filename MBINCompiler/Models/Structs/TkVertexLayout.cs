using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
	public class TkVertexLayout : NMSTemplate
	{
		public int ElementCount;
		public int Stride;
		public string PlatformData;
		public List<TkVertexElement> VertexElements;
	}
}