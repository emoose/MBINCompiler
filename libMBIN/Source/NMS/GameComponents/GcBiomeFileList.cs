using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF545F6DE48D0C615, NameHash = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        /* 0x100 */ public List<GcBiomeType> ValidStartPlanetBiome;
        /* 0x110 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0x120 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
