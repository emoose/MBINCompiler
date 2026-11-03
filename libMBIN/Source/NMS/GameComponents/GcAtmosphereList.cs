using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C05891EAEA9D373, NameHash = 0x36058B7C)]
    public class GcAtmosphereList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> Atmospheres;
    }
}
