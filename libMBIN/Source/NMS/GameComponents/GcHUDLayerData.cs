using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF92AB791894ACA5, NameHash = 0xA73B9709)]
    public class GcHUDLayerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x28 */ public List<NMSTemplate> Children;
    }
}
