using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82F070BB6E4F190F, NameHash = 0xEC25B86A)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureStupidName> Table;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 StupidUserName;
    }
}
