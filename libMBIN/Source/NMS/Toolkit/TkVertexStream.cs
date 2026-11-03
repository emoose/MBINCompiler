using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1150956F83DEE56B, NameHash = 0xDE6297D6)]
    public class TkVertexStream : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<byte> VertexStream;
    }
}
