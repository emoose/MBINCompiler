using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRealityIconTable : NMSTemplate       // size: 0x3008
    {
        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special" , "BuildingPart"})]
        /* 0x0318 */ public TkTextureResource[] SubstanceCategoryIcons;

        [NMS(Size = 5, EnumValue = new string[5] { "Component", "Device", "Consumable", "Curiosity" , "BuildingPart"})]
        /* 0x0630 */ public TkTextureResource[] ProductCategoryIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x08C4 */ public TkTextureResource[] MissionFactionIcons;

        [NMS(Size = 0xB, EnumValue = new string[0xB] {"Unknown", "SolarSystem", "Planet", "Animal",
                                                      "Flora", "Mineral", "Sector", "Building", "Interactable",
                                                      "Sentinel", "StarShip" })]
        /* 0x0C60 */ public TkTextureResource[] BinocularDiscoveryIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Mining", "HighTech", "Trading", "Manufacturing", "Fusion", "Scientific", "PowerGeneration" })]
        /* 0x120C */ public TkTextureResource[] DiscoveryPageTradingIcons;

        [NMS(Size = 0x3, EnumValue = new string[3] { "Low", "Default", "High" })]
        /* 0x15A8 */ public TkTextureResource[] DiscoveryPageConflictIcons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x1734 */ public TkTextureResource[] DiscoveryPageRaceIcons;

        /* 0x1AD0 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;

        [NMS(Size = 0x29, EnumValue = new string[0x29] { "Stamina", "NoStamina", "EnergyCharge", "Scanner", "NoScanner", "Grave", "Resources","Inventory",
            "InventoryFull", "RareItems", "Pirates", "PirateScan", "Drone", "Quad", "Walker", "DroneOff", "Police", "AtlasStation", "BlackHole", "SaveGame",
            "Jetpack", "VehicleBoost", "VehicleBoostRecharge", "Fuel", "GekStanding", "VykeenStanding", "KorvaxStanding", "GekDiamondStanding", "VykeenDiamondStanding", "KorvaxDiamondStanding",
            "TradeGuildStanding", "WarGuildStanding", "ExplorerGuildStanding", "TradeGuildDiamondStanding", "WarGuildDiamondStanding",
            "ExplorationGuildDiamondStanding", "GMPathToCentre", "GMAtlas", "GMBlackHole", "GMUserWaypoint", "GMUserMission"})]
        /* 0x1AE0 */ public TkTextureResource[] GameIcons;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
