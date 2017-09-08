namespace libMBIN.Models.Structs
{
    public class TkVertexElement : NMSTemplate      // size: 0x20
    {
        public int SemanticID;
        public int Size;
        public int Type;
        public int Offset;
        public int Normalise;

        public int Instancing;
        public string[] InstancingValues()
        {
            return new[] { "PerVertex", "PerModel" };
        }
        
        [NMS(Size = 8)]
        public string PlatformData;
    }
}
