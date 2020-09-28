using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xCE80, GUID = 0xF0699DFCC35F7F7F, NameHash = 0x5930542B7B565329)]
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
        [NMS(Size = 0x70, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x70, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x08F8 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AB8 */ public TkCurveType[] WeightingCurves;
        /* 0x0AD8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0AE8 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B68 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0BE8 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0C68 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0CE8 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0D68 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0DE8 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0E68 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0EE8 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0F68 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0FE8 */ public string UnlockableItemTrees;
        /* 0x1068 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1078 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1238 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1308 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1378 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x13F8 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x14F8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1618 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x17A4 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1930 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1ABC */ public float[] WeightedTextWeights;
        /* 0x1AC8 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x66D8 */ public byte[] Padding66D8;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x66E0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6740 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6770 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6800 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6CA4 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xBFA8 */ public GcStats[] Stats;
        /* 0xBFF8 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC008 */ public GcTechList[] PlanetTechShops;
        /* 0xC108 */ public GcTradeSettings TradeSettings;
        /* 0xCD68 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xCD88 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xCDA8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xCDC8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xCDE8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xCE08 */ public List<int> SuitUpgradePrices;
        /* 0xCE18 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xCE28 */ public List<int> SuitCargoUpgradePrices;
        /* 0xCE38 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xCE48 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xCE58 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xCE6C */ public byte[] PaddingCE6C;
        /* 0xCE70 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
