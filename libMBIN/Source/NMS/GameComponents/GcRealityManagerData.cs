using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA11F6F3322F9D76, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x00000 */ public ushort HomeRealityIteration;
        /* 0x00002 */ public ushort RealityIteration;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x00004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x001E0 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x001F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x00200 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x00400 */ public NMSString0x80 TechnologyTable;
        /* 0x00480 */ public NMSString0x80 SubstanceTable;
        /* 0x00500 */ public NMSString0x80 ProductTable;
        /* 0x00580 */ public NMSString0x80 ProceduralProductTable;
        /* 0x00600 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x00680 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x00700 */ public List<TkRawID> LegacyRepairTable;
        /* 0x00710 */ public NMSString0x80 ConsumableItemTable;
        /* 0x00790 */ public NMSString0x80 RecipeTable;
        /* 0x00810 */ public NMSString0x80 StoriesTable;
        /* 0x00890 */ public NMSString0x80 DialogClearanceTable;
        /* 0x00910 */ public NMSString0x80 AlienWordsTable;
        /* 0x00990 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x009A0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00A24 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x00C30 */ public TkCurveType[] WeightingCurves;
        /* 0x00C50 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00C60 */ public NMSString0x80 RewardTable;
        /* 0x00CE0 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00D60 */ public NMSString0x80 InventoryTable;
        /* 0x00DE0 */ public NMSString0x80 DamageTable;
        /* 0x00E60 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x00EE0 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x00F60 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x00FE0 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x01060 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x010E0 */ public NMSString0x80 CostTable;
        /* 0x01160 */ public NMSString0x80 TradingCostTable;
        /* 0x011E0 */ public NMSString0x80 TradingClassDataTable;
        /* 0x01260 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x012E0 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x01360 */ public NMSString0x80 SettlementPerksTable;
        /* 0x013E0 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x01460 */ public NMSString0x80 CombatEffectsTable;
        /* 0x014E0 */ public NMSString0x80 TechBoxTable;
        /* 0x01560 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01570 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x01730 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x01860 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x018D0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01960 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01A80 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01BC4 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01D50 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01EDC */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x02068 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x02118 */ public float[] WeightedTextWeights;
        /* 0x02128 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x07E40 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x07EA0 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x07ED0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x07F60 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08404 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0E578 */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x146F0 */ public GcStats[] Stats;
        /* 0x14740 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x14750 */ public GcTechList[] PlanetTechShops;
        /* 0x14850 */ public GcTradeSettings TradeSettings;
        /* 0x15A30 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x15A40 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x15A60 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x15A80 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x15AA0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x15AC0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x15AE0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x15B00 */ public List<int> SuitUpgradePrices;
        /* 0x15B10 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x15B20 */ public List<int> SuitCargoUpgradePrices;
        /* 0x15B30 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x15B40 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x15B50 */ public float[] NormalisedPriceLimits;
        /* 0x15B68 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x15B78 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x15B88 */ public NMSString0x80[] Catalogues;
    }
}
