using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4792483DC39B95E6, NameHash = 0x7F0D775900CDB2FD)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        /* 0x000 */ public float RegionHotspotsPoleSpacing;
        /* 0x004 */ public float RegionHotspotsPerPoleMin;
        /* 0x008 */ public float RegionHotspotsPerPoleMax;
        /* 0x00C */ public float RegionHotspotsMinSameCategorySpacing;
        /* 0x010 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        // size: 0x6
        public enum RegionHotspotsEnum {
            Power,
            Mineral1,
            Mineral2,
            Mineral3,
            Gas1,
            Gas2
        }
        [NMS(Size = 0x6, EnumType = typeof(RegionHotspotsEnum))]
        /* 0x014 */ public GcRegionHotspotData[] RegionHotspots;
        // size: 0x10
        public enum RegionHotspotBiomeGasesEnum {
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
        [NMS(Size = 0x10, EnumType = typeof(RegionHotspotBiomeGasesEnum))]
        /* 0x138 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        /* 0x338 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;
    }
}
