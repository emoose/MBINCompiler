using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xE590, GUID = 0x2A66422A71E6A45A, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01E0 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x01F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Size = 0x10)]
        /* 0x0200 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
        /* 0x0400 */ public NMSString0x80 TechnologyTable;
        /* 0x0480 */ public NMSString0x80 SubstanceTable;
        /* 0x0500 */ public NMSString0x80 ProductTable;
        /* 0x0580 */ public NMSString0x80 ProceduralProductTable;
        /* 0x0600 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x0680 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x0700 */ public List<TkRawID> LegacyRepairTable;
        /* 0x0710 */ public NMSString0x80 ConsumableItemTable;
        /* 0x0790 */ public NMSString0x80 RecipeTable;
        /* 0x0810 */ public NMSString0x80 AlienWordsTable;
        /* 0x0890 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x7D, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x08A0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x7D, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0920 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0B14 */ public TkCurveType[] WeightingCurves;
        /* 0x0B30 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0B40 */ public NMSString0x80 RewardTable;
        /* 0x0BC0 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0C40 */ public NMSString0x80 InventoryTable;
        /* 0x0CC0 */ public NMSString0x80 DamageTable;
        /* 0x0D40 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0DC0 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0E40 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0EC0 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x0F40 */ public NMSString0x80 CostTable;
        /* 0x0FC0 */ public NMSString0x80 TradingCostTable;
        /* 0x1040 */ public NMSString0x80 TradingClassDataTable;
        /* 0x10C0 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x1140 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x11C0 */ public NMSString0x80 SettlementPerksTable;
        /* 0x1240 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x12C0 */ public NMSString0x80 CombatEffectsTable;
        /* 0x1340 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1350 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1510 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1640 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x16B0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1730 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1830 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1950 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1ADC */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1C68 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1DF4 */ public float[] WeightedTextWeights;
        /* 0x1E00 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7150 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x71B0 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x71E0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x7270 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xB7, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7714 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xD570 */ public GcStats[] Stats;
        /* 0xD5C0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xD5D0 */ public GcTechList[] PlanetTechShops;
        /* 0xD6D0 */ public GcTradeSettings TradeSettings;
        /* 0xE478 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xE498 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xE4B8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xE4D8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xE4F8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xE518 */ public List<int> SuitUpgradePrices;
        /* 0xE528 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xE538 */ public List<int> SuitCargoUpgradePrices;
        /* 0xE548 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xE558 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xE568 */ public float[] NormalisedPriceLimits;
        /* 0xE580 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
