using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8D75BABAE18E232, NameHash = 0xDD31F212063601F7)]
    public class TkVertexLayout : NMSTemplate
    {
        /* 0x00 */ public int ElementCount;
        /* 0x04 */ public int Stride;
        /* 0x08 */ public long PlatformData;
        /* 0x10 */ public List<TkVertexElement> VertexElements;
    }
}
