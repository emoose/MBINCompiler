namespace MBINCompiler.Models.Structs
{
	public class TkVertexElement : NMSTemplate
	{
		public int SemanticID;
		public int Size;
		public int Type;
		public int Offset;
		public int Normalise;
		public string[] Instancing()
        {
            return new[] { "PerVertex", "PerModel" };
		}
		public string PlatformData;
	}
}