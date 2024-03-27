using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC9B3C032431346, NameHash = 0x5930542B7B565329)]
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
        /* 0x00910 */ public NMSString0x80 ProductDescriptionOverrideTable;
        /* 0x00990 */ public NMSString0x80 AlienWordsTable;
        /* 0x00A10 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00A20 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00AAC */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x00CDC */ public TkCurveType[] WeightingCurves;
        /* 0x00CE8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00CF8 */ public NMSString0x80 HistoricalSeasonDataTable;
        /* 0x00D78 */ public NMSString0x80 RewardTable;
        /* 0x00DF8 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00E78 */ public NMSString0x80 StatRewardsTable;
        /* 0x00EF8 */ public NMSString0x80 InventoryTable;
        /* 0x00F78 */ public NMSString0x80 DamageTable;
        /* 0x00FF8 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x01078 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x010F8 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x01178 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x011F8 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x01278 */ public NMSString0x80 CostTable;
        /* 0x012F8 */ public NMSString0x80 TradingCostTable;
        /* 0x01378 */ public NMSString0x80 TradingClassDataTable;
        /* 0x013F8 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x01478 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x014F8 */ public NMSString0x80 SettlementPerksTable;
        /* 0x01578 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x015F8 */ public NMSString0x80 CombatEffectsTable;
        /* 0x01678 */ public NMSString0x80 TechBoxTable;
        /* 0x016F8 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01708 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x018C8 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x019F8 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01A68 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01B08 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01C48 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01DB0 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x020C8 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x023E0 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB)]
        /* 0x026F8 */ public TkIdArray[] MissionBoardRewardOptions;
        /* 0x027A8 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x027B8 */ public float[] WeightedTextWeights;
        /* 0x027C8 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x08A10 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x08A70 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x08AA0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x08B30 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08FD4 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0F250 */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x154D0 */ public GcStats[] Stats;
        /* 0x15520 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x15530 */ public GcTechList[] PlanetTechShops;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x15630 */ public GcRepShopData[] RepShops;
        /* 0x15770 */ public GcTradeSettings TradeSettings;
        /* 0x16A20 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x16A30 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x16A50 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x16A70 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x16A90 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x16AB0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x16AD0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x16AF0 */ public List<int> SuitUpgradePrices;
        /* 0x16B00 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x16B10 */ public List<int> SuitCargoUpgradePrices;
        /* 0x16B20 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x16B30 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x16B40 */ public float[] NormalisedPriceLimits;
        /* 0x16B58 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x16B68 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x16B78 */ public NMSString0x80[] Catalogues;
    }
}
