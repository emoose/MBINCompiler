using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4FA4D00222E87DF, NameHash = 0x2BFE1835E7B1EFEC)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        /* 0x0 */ public List<GcStatDefinition> StatDefinitionTable;
    }
}
