using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D144150D4184D5E, NameHash = 0x98680091)]
    public class GcTexturePrefetchData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> Textures;
    }
}
