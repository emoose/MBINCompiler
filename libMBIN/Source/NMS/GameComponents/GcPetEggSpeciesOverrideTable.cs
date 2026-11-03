using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CAD61B7456A6803, NameHash = 0x9FB1DE29)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}
