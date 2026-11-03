using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE69C868C257A93B4, NameHash = 0xDA33326)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename Model;
        [NMS(Index = 2)]
        /* 0x10 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 Name;
    }
}
