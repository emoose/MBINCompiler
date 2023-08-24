using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF2FA1139D998310, NameHash = 0x5930542B7B565329)]
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
        [NMS(Size = 0x8A, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00A20 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x8A, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00AAC */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x00CD4 */ public TkCurveType[] WeightingCurves;
        /* 0x00CE0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00CF0 */ public NMSString0x80 RewardTable;
        /* 0x00D70 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00DF0 */ public NMSString0x80 InventoryTable;
        /* 0x00E70 */ public NMSString0x80 DamageTable;
        /* 0x00EF0 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x00F70 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x00FF0 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x01070 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x010F0 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x01170 */ public NMSString0x80 CostTable;
        /* 0x011F0 */ public NMSString0x80 TradingCostTable;
        /* 0x01270 */ public NMSString0x80 TradingClassDataTable;
        /* 0x012F0 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x01370 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x013F0 */ public NMSString0x80 SettlementPerksTable;
        /* 0x01470 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x014F0 */ public NMSString0x80 CombatEffectsTable;
        /* 0x01570 */ public NMSString0x80 TechBoxTable;
        /* 0x015F0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01600 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x017C0 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x018F0 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01960 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01A00 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01B40 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xE, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01CA8 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xE, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01EA0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xE, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x02098 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB)]
        /* 0x02290 */ public TkIdArray[] MissionBoardRewardOptions;
        /* 0x02340 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x02350 */ public float[] WeightedTextWeights;
        /* 0x02360 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x08520 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x08580 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x085B0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x08640 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08AE4 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0ECDC */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x14ED8 */ public GcStats[] Stats;
        /* 0x14F28 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x14F38 */ public GcTechList[] PlanetTechShops;
        /* 0x15038 */ public GcTradeSettings TradeSettings;
        /* 0x162E8 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x162F8 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x16318 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x16338 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x16358 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x16378 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x16398 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x163B8 */ public List<int> SuitUpgradePrices;
        /* 0x163C8 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x163D8 */ public List<int> SuitCargoUpgradePrices;
        /* 0x163E8 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x163F8 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x16408 */ public float[] NormalisedPriceLimits;
        /* 0x16420 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x16430 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x16440 */ public NMSString0x80[] Catalogues;
    }
}
