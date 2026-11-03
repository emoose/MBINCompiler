using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52C052BC5201F80C, NameHash = 0x539FCC01)]
    public class InfluencesOnMappedPoint : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<MappingInfluence> Influences;
    }
}
