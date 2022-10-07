using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79FD808F9DDD453C, NameHash = 0xE51761B21603792C)]
    public class GcCreatureGenerationWeightedList : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureGenerationWeightedListDomainEntry> Ground;
        /* 0x10 */ public List<GcCreatureGenerationWeightedListDomainEntry> Air;
        /* 0x20 */ public List<GcCreatureGenerationWeightedListDomainEntry> Cave;
        /* 0x30 */ public List<GcCreatureGenerationWeightedListDomainEntry> Water;
    }
}
