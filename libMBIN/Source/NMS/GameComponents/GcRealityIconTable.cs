using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B8D24A676A7B12D, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0318 */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0630 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0AD4 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0F78 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x14A0 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1D64 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x2100 */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x2310 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        /* 0x27B4 */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2838 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x28BC */ public TkTextureResource DiscoveryPageRaceUnknown;
        /* 0x2940 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2950 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2960 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Size = 0x58, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x2970 */ public TkTextureResource[] GameIcons;
        /* 0x56D0 */ public List<GcRealityIcon> MissionDetailIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x56E0 */ public TkTextureResource[] DifficultyPresetIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x5A7C */ public TkTextureResource[] DifficultyUIOptionIcons;
        [NMS(Size = 0x5, EnumType = typeof(GcOptionsUIHeaderIcons.OptionsUIHeaderIconTypeEnum))]
        /* 0x5C8C */ public TkTextureResource[] OptionsUIHeaderIcons;
        [NMS(Size = 0x5, EnumType = typeof(GcInventoryFilterOptions.InventoryFilterEnum))]
        /* 0x5F20 */ public TkTextureResource[] InventoryFilterIcons;
    }
}
