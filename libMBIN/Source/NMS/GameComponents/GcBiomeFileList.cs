using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7B20F162CA4FB38, NameHash = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        // size: 0x10
        public enum BiomeFilesEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(BiomeFilesEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        /* 0x100 */ public List<GcBiomeType> ValidStartPlanetBiome;
        /* 0x110 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0x120 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
