using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C7C854D5556F541, NameHash = 0x112D6026)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMultiSpecificItemEntry> Items;
        [NMS(Index = 0)]
        /* 0x10 */ public bool Silent;
    }
}
