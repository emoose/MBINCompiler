using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7588135A1767742C, NameHash = 0x9E72B6D)]
    public class GcUAProtectedLocations : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcProtectedLocation> ProtectedLocations;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong UA;
    }
}
