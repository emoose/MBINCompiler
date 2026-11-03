using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31E8A52548BB40A7, NameHash = 0xFBEFB321)]
    public class GcGameTablePetPrerequisiteDisallowedBiomes : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBiomeType> Biomes;
    }
}
