using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD2A0, GUID = 0x94C33B54CAD88436, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01D4 */ public byte[] Padding1D4;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Size = 0x80)]
        /* 0x03E8 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0468 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x04E8 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0568 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x05E8 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0668 */ public string LegacyItemConversionTable;
        /* 0x06E8 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Size = 0x80)]
        /* 0x06F8 */ public string ConsumableItemTable;
        [NMS(Size = 0x80)]
        /* 0x0778 */ public string RecipeTable;
        [NMS(Size = 0x80)]
        /* 0x07F8 */ public string AlienWordsTable;
        /* 0x0878 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x08FC */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AC4 */ public TkCurveType[] WeightingCurves;
        /* 0x0AE0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0AF0 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B70 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0BF0 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0C70 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0CF0 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0D70 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0DF0 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0E670 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0EF0 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0F70 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0FF0 */ public string UnlockableItemTrees;
        /* 0x1070 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1080 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1240 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1310 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1380 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1400 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1500 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1620 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x17BC */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1938 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1AC4 */ public float[] WeightedTextWeights;
        /* 0x1AD0 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6B00 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6B60 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6B90 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6C20 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x70C4 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xC3C8 */ public GcStats[] Stats;
        /* 0xC418 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC428 */ public GcTechList[] PlanetTechShops;
        /* 0xC528 */ public GcTradeSettings TradeSettings;
        /* 0xD188 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xD1A8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xD1C8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xD1E8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xD208 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xD228 */ public List<int> SuitUpgradePrices;
        /* 0xD238 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xD248 */ public List<int> SuitCargoUpgradePrices;
        /* 0xD258 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xD268 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xD278 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD28C */ public byte[] PaddingD28C;
        /* 0xD290 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
