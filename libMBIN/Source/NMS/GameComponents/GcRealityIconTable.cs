using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x234060E7E36B9F1C, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        // size: 0x6
        public enum HazardIconsEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        [NMS(Size = 0x6, EnumType = typeof(HazardIconsEnum))]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;
        // size: 0x6
        public enum HazardIconsHUDEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        [NMS(Size = 0x6, EnumType = typeof(HazardIconsHUDEnum))]
        /* 0x0318 */ public TkTextureResource[] HazardIconsHUD;
        // size: 0x9
        public enum SubstanceCategoryIconsEnum {
            Fuel,
            Metal,
            Catalyst,
            Stellar,
            Flora,
            Earth,
            Exotic,
            Special,
            BuildingPart
        }
        [NMS(Size = 0x9, EnumType = typeof(SubstanceCategoryIconsEnum))]
        /* 0x0630 */ public TkTextureResource[] SubstanceCategoryIcons;
        // size: 0x9
        public enum ProductCategoryIconsEnum {
            Component,
            Consumable,
            Tradeable,
            Curiosity,
            BuildingPart,
            Procedural,
            Emote,
            CustomisationPart,
            CreatureEgg
        }
        [NMS(Size = 0x9, EnumType = typeof(ProductCategoryIconsEnum))]
        /* 0x0AD4 */ public TkTextureResource[] ProductCategoryIcons;
        // size: 0x9
        public enum MissionFactionIconsEnum {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            None
        }
        [NMS(Size = 0x9, EnumType = typeof(MissionFactionIconsEnum))]
        /* 0x0F78 */ public TkTextureResource[] MissionFactionIcons;
        // size: 0x11
        public enum BinocularDiscoveryIconsEnum {
            Unknown,
            SolarSystem,
            Planet,
            Animal,
            Flora,
            Mineral,
            Sector,
            Building,
            Interactable,
            Sentinel,
            Starship,
            Artifact,
            Mystery,
            Treasure,
            Control,
            HarvestPlant,
            FriendlyDrone
        }
        [NMS(Size = 0x11, EnumType = typeof(BinocularDiscoveryIconsEnum))]
        /* 0x141C */ public TkTextureResource[] BinocularDiscoveryIcons;
        // size: 0x7
        public enum DiscoveryPageTradingIconsEnum {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration
        }
        [NMS(Size = 0x7, EnumType = typeof(DiscoveryPageTradingIconsEnum))]
        /* 0x1CE0 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        // size: 0x4
        public enum DiscoveryPageConflictIconsEnum {
            Low,
            Default,
            High,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(DiscoveryPageConflictIconsEnum))]
        /* 0x207C */ public TkTextureResource[] DiscoveryPageConflictIcons;
        // size: 0x8
        public enum DiscoveryPageRaceIconsEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(DiscoveryPageRaceIconsEnum))]
        /* 0x228C */ public TkTextureResource[] DiscoveryPageRaceIcons;
        /* 0x26AC */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2730 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x27B4 */ public TkTextureResource DiscoveryPageRaceUnknown;
        /* 0x2838 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2848 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2858 */ public List<TkTextureResource> RepairTechIcons;
        // size: 0x56
        public enum GameIconsEnum {
            Stamina,
            NoStamina,
            EnergyCharge,
            Scanner,
            NoScanner,
            Grave,
            Resources,
            Inventory,
            InventoryFull,
            RareItems,
            Pirates,
            PirateScan,
            Drone,
            Quad,
            Mech,
            Walker,
            DroneOff,
            Police,
            AtlasStation,
            BlackHole,
            SaveGame,
            SaveInventory,
            Jetpack,
            JetpackEmpty,
            VehicleBoost,
            VehicleBoostRecharge,
            Fuel,
            GekStanding,
            VykeenStanding,
            KorvaxStanding,
            GekDiamondStanding,
            VykeenDiamondStanding,
            KorvaxDiamondStanding,
            TradeGuildStanding,
            WarGuildStanding,
            ExplorationGuildStanding,
            TradeGuildDiamondStanding,
            WarGuildDiamondStanding,
            ExplorationGuildDiamondStanding,
            GMPathToCentre,
            GMAtlas,
            GMBlackHole,
            GMUserWaypoint,
            GMUserMission,
            GMSeasonal,
            TransferPersonal,
            TransferPersonalCargo,
            TransferShip,
            TransferBike,
            TransferBuggy,
            TransferTruck,
            TransferWheeledBike,
            TransferHovercraft,
            TransferSubmarine,
            TransferMech,
            TransferFreighter,
            TransferBase,
            HazardIndicatorHot,
            HazardIndicatorCold,
            HazardIndicatorRadiation,
            HazardIndicatorToxic,
            TerrainAdd,
            TerrainRemove,
            TerrainFlatten,
            TerrainUndo,
            SpacePhone,
            GarageMarkerBuggy,
            GarageMarkerBike,
            GarageMarkerTruck,
            GarageMarkerWheeledBike,
            GarageMarkerHovercraft,
            CorruptedDrone,
            HandHold,
            ShipThumbnailBG,
            CClass,
            BClass,
            AClass,
            SClass,
            NoSaveWarning,
            ExploreMissionPlanetIcon,
            ExploreMissionSystemIcon,
            PetThumbnailBG,
            SettlementOSD,
            Stealth,
            StealthEmpty,
            DefenceForce
        }
        [NMS(Size = 0x56, EnumType = typeof(GameIconsEnum))]
        /* 0x2868 */ public TkTextureResource[] GameIcons;
        /* 0x54C0 */ public List<GcRealityIcon> MissionDetailIcons;
        // size: 0x7
        public enum DifficultyPresetIconsEnum {
            Invalid,
            Custom,
            Normal,
            Creative,
            Relaxed,
            Survival,
            Permadeath
        }
        [NMS(Size = 0x7, EnumType = typeof(DifficultyPresetIconsEnum))]
        /* 0x54D0 */ public TkTextureResource[] DifficultyPresetIcons;
        // size: 0x4
        public enum DifficultyUIOptionIconsEnum {
            Survival,
            Crafting,
            Combat,
            Ease
        }
        [NMS(Size = 0x4, EnumType = typeof(DifficultyUIOptionIconsEnum))]
        /* 0x586C */ public TkTextureResource[] DifficultyUIOptionIcons;
        // size: 0x5
        public enum InventoryFilterIconsEnum {
            All,
            Substance,
            HighValue,
            Consumable,
            Deployable
        }
        [NMS(Size = 0x5, EnumType = typeof(InventoryFilterIconsEnum))]
        /* 0x5A7C */ public TkTextureResource[] InventoryFilterIcons;
    }
}
