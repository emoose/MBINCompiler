using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkVertexLayout : NMSTemplate
    {
        public int ElementCount;
        public int Stride;

        [NMS(Size = 8)]
        public string PlatformData;

        public List<TkVertexElement> VertexElements;
    }
}
