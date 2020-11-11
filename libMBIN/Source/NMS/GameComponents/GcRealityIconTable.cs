using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4F28, GUID = 0x40E0E1DF28EFE1D, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0318 */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0630 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Size = 0x8, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0AD4 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Size = 0x8, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0EF4 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x1314 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1B54 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Size = 0x3, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1EF0 */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x207C */ public TkTextureResource[] DiscoveryPageRaceIcons;
        /* 0x249C */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2520 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x25A4 */ public TkTextureResource DiscoveryPageRaceUnknown;
        /* 0x2628 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2638 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2648 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Size = 0x4F, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x2658 */ public TkTextureResource[] GameIcons;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4F14 */ public byte[] Padding4F14;
        /* 0x4F18 */ public List<GcRealityIcon> MissionDetailIcons;
    }
}
