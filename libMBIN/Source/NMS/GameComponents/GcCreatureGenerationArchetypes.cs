using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B55D7152697FB96, NameHash = 0xCFE07CC2C3280EC)]
    public class GcCreatureGenerationArchetypes : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureGenerationDomainTable> GroundArchetypes;
        /* 0x10 */ public List<GcCreatureGenerationDomainTable> AirArchetypes;
        /* 0x20 */ public List<GcCreatureGenerationDomainTable> WaterArchetypes;
        /* 0x30 */ public List<GcCreatureGenerationDomainTable> CaveArchetypes;
    }
}
