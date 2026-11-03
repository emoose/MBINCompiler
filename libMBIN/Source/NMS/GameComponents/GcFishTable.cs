using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF3AD9A915EACFDE, NameHash = 0x8C266C57)]
    public class GcFishTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFishData> Fish;
    }
}
