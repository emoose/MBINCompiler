using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xD850, GUID = 0x1354A313C334C66C, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x03E8 */ public NMSString0x80 TechnologyTable;
        /* 0x0468 */ public NMSString0x80 SubstanceTable;
        /* 0x04E8 */ public NMSString0x80 ProductTable;
        /* 0x0568 */ public NMSString0x80 ProceduralProductTable;
        /* 0x05E8 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x0668 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x06E8 */ public List<TkRawID> LegacyRepairTable;
        /* 0x06F8 */ public NMSString0x80 ConsumableItemTable;
        /* 0x0778 */ public NMSString0x80 RecipeTable;
        /* 0x07F8 */ public NMSString0x80 AlienWordsTable;
        /* 0x0878 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x7A, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x7A, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0904 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AEC */ public TkCurveType[] WeightingCurves;
        /* 0x0B08 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0B18 */ public NMSString0x80 RewardTable;
        /* 0x0B98 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0C18 */ public NMSString0x80 InventoryTable;
        /* 0x0C98 */ public NMSString0x80 DamageTable;
        /* 0x0D18 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0D98 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0E18 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0E98 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x0F18 */ public NMSString0x80 CostTable;
        /* 0x0F98 */ public NMSString0x80 TradingCostTable;
        /* 0x1018 */ public NMSString0x80 TradingClassDataTable;
        /* 0x1098 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x1118 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x1198 */ public NMSString0x80 SettlementPerksTable;
        /* 0x1218 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1228 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xF, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x13E8 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x14D8 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1548 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x15C8 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x16C8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x17E8 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1974 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1B00 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1C8C */ public float[] WeightedTextWeights;
        /* 0x1C98 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6DD0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6E30 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6E60 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6EF0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA4, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7394 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xC828 */ public GcStats[] Stats;
        /* 0xC878 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC888 */ public GcTechList[] PlanetTechShops;
        /* 0xC988 */ public GcTradeSettings TradeSettings;
        /* 0xD730 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xD750 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xD770 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xD790 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xD7B0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xD7D0 */ public List<int> SuitUpgradePrices;
        /* 0xD7E0 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xD7F0 */ public List<int> SuitCargoUpgradePrices;
        /* 0xD800 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xD810 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xD820 */ public float[] NormalisedPriceLimits;
        /* 0xD838 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
