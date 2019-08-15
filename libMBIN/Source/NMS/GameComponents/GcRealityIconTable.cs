using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4768, GUID = 0x2AD346B04A54A12F, SubGUID = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 6, EnumValue = new[] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;

        [NMS(Size = 9, EnumValue = new[] { "Fuel", "Metal", "Catalyst", "Stellar", "Flora", "Earth", "Exotic", "Special", "BuildingPart" })]
        /* 0x0318 */ public TkTextureResource[] SubstanceCategoryIcons;

        [NMS(Size = 8, EnumValue = new[] { "Component", "Consumable", "Tradeable", "Curiousity", "BuildingPart", "Procedural", "Emote", "CustomisationPart" })]
        /* 0x07BC */ public TkTextureResource[] ProductCategoryIcons;

        [NMS(Size = 0x8, EnumValue = new[] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x0BDC */ public TkTextureResource[] MissionFactionIcons;

        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0FFC */ public TkTextureResource[] BinocularDiscoveryIcons;

        [NMS(Size = 0x7, EnumValue = new[] { "Mining", "HighTech", "Trading", "Manufacturing", "Fusion", "Scientific", "PowerGeneration" })]
        /* 0x183C */ public TkTextureResource[] DiscoveryPageTradingIcons;

        [NMS(Size = 0x3, EnumValue = new[] { "Low", "Default", "High" })]
        /* 0x1BD8 */ public TkTextureResource[] DiscoveryPageConflictIcons;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1D64 */ public TkTextureResource[] DiscoveryPageRaceIcons;

        /* 0x2184 */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2208 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x228C */ public TkTextureResource DiscoveryPageRaceUnknown;

        /* 0x2310 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2320 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2330 */ public List<TkTextureResource> RepairTechIcons;

        // enum struct: GcRealityGameIcons
        [NMS(Size = 0x46, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x2340 */ public TkTextureResource[] GameIcons;

        /* 0x4758 */ public List<GcRealityIcon> MissionDetailIcons;
    }
}
