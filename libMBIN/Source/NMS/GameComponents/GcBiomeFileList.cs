using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC0B15C60C80D895, NameHash = 0xD7B3E587)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        [NMS(Index = 4)]
        /* 0x110 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        [NMS(Index = 5)]
        /* 0x120 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
        [NMS(Index = 3)]
        /* 0x130 */ public List<GcBiomeType> ValidGiantPlanetBiome;
        [NMS(Index = 2)]
        /* 0x140 */ public List<GcBiomeType> ValidPurpleMoonBiome;
        [NMS(Index = 1)]
        /* 0x150 */ public List<GcBiomeType> ValidStartPlanetBiome;
    }
}
