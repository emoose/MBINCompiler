using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD20E7CA825404084, NameHash = 0x6110D9A6BE68E9B8)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}
