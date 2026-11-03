using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75F999D5ABCAFA94, NameHash = 0x8372609C)]
    public class GcCreatureStupidName : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public List<NMSString0x80> Names;
        [NMS(Index = 1)]
        /* 0x20 */ public int Count;
    }
}
