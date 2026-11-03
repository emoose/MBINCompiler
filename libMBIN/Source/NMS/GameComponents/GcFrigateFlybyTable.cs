using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA096CB64B4E56795, NameHash = 0x9CF047FE)]
    public class GcFrigateFlybyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateFlybyLayout> Entries;
    }
}
