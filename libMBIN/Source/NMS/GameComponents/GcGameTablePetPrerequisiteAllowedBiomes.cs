using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D02EF93F5A02209, NameHash = 0xEBE6C001)]
    public class GcGameTablePetPrerequisiteAllowedBiomes : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBiomeType> Biomes;
    }
}
