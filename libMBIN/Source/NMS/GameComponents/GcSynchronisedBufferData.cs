using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13B04519C4B6DDFF, NameHash = 0xBBC409)]
    public class GcSynchronisedBufferData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<ulong> Data;
    }
}
