using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4080311E0BFA9BB, NameHash = 0x7F0D775900CDB2FD)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        /* 0x000 */ public float RegionHotspotsPoleSpacing;
        /* 0x004 */ public float RegionHotspotsPerPoleMin;
        /* 0x008 */ public float RegionHotspotsPerPoleMax;
        /* 0x00C */ public float RegionHotspotsMinSameCategorySpacing;
        /* 0x010 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        [NMS(Size = 0x6, EnumType = typeof(GcRegionHotspotTypes.HotspotTypeEnum))]
        /* 0x014 */ public GcRegionHotspotData[] RegionHotspots;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x138 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        /* 0x338 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;
    }
}
