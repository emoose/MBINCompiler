using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD017F23D70CEAB3A, NameHash = 0x5930542B7B565329)]
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
        [NMS(Size = 0x85, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x009A0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x85, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00A28 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x00C3C */ public TkCurveType[] WeightingCurves;
        /* 0x00C48 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00C58 */ public NMSString0x80 RewardTable;
        /* 0x00CD8 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00D58 */ public NMSString0x80 InventoryTable;
        /* 0x00DD8 */ public NMSString0x80 DamageTable;
        /* 0x00E58 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x00ED8 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x00F58 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x00FD8 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x01058 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x010D8 */ public NMSString0x80 CostTable;
        /* 0x01158 */ public NMSString0x80 TradingCostTable;
        /* 0x011D8 */ public NMSString0x80 TradingClassDataTable;
        /* 0x01258 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x012D8 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x01358 */ public NMSString0x80 SettlementPerksTable;
        /* 0x013D8 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x01458 */ public NMSString0x80 CombatEffectsTable;
        /* 0x014D8 */ public NMSString0x80 TechBoxTable;
        /* 0x01558 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01568 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x01728 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x01858 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x018C8 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01958 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01A78 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01BBC */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01D48 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01ED4 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x02060 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x02110 */ public float[] WeightedTextWeights;
        /* 0x02120 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x081D0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x08230 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x08260 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x082F0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08794 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0E908 */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x14A80 */ public GcStats[] Stats;
        /* 0x14AD0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x14AE0 */ public GcTechList[] PlanetTechShops;
        /* 0x14BE0 */ public GcTradeSettings TradeSettings;
        /* 0x15DC0 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x15DD0 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x15DF0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x15E10 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x15E30 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x15E50 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x15E70 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x15E90 */ public List<int> SuitUpgradePrices;
        /* 0x15EA0 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x15EB0 */ public List<int> SuitCargoUpgradePrices;
        /* 0x15EC0 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x15ED0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x15EE0 */ public float[] NormalisedPriceLimits;
        /* 0x15EF8 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x15F08 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x15F18 */ public NMSString0x80[] Catalogues;
    }
}
