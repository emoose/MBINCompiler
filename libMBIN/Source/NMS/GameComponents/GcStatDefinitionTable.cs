using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x400CB6B30153EC0, NameHash = 0x2BFE1835E7B1EFEC)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        /* 0x0 */ public List<GcStatDefinition> StatDefinitionTable;
    }
}
