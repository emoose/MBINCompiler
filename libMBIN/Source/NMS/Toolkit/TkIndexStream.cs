using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD02A124DF9DC0B37, NameHash = 0x1A553772)]
    public class TkIndexStream : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<int> IndexStream;
    }
}
