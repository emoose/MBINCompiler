using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6765566FE389BC8, NameHash = 0x6B3FBC2C)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        [NMS(Index = 7)]
        /* 0x220 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;
        [NMS(Index = 5, Size = 0x6, EnumType = typeof(GcRegionHotspotTypes.HotspotTypeEnum))]
        /* 0x230 */ public GcRegionHotspotData[] RegionHotspots;
        [NMS(Index = 4)]
        /* 0x350 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        [NMS(Index = 3)]
        /* 0x354 */ public float RegionHotspotsMinSameCategorySpacing;
        [NMS(Index = 2)]
        /* 0x358 */ public float RegionHotspotsPerPoleMax;
        [NMS(Index = 1)]
        /* 0x35C */ public float RegionHotspotsPerPoleMin;
        [NMS(Index = 0)]
        /* 0x360 */ public float RegionHotspotsPoleSpacing;
    }
}
