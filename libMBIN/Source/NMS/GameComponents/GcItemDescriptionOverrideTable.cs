using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14D804F3E6606BA4, NameHash = 0x7574ADE1)]
    public class GcItemDescriptionOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcItemDescriptionOverride> Table;
    }
}
