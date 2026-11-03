using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE0EECDC3C8F562CB, NameHash = 0x52984C1F)]
    public class TkLSystemLocatorEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Model;
        [NMS(Index = 2)]
        /* 0x10 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 1)]
        /* 0x20 */ public float Probability;
    }
}
