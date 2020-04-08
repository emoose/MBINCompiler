using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC460, GUID = 0xD26F1D7BB5EB87D1, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4)]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01D4 */ public byte[] Padding1D4;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Size = 0x80)]
        /* 0x0388 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0408 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0488 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0508 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x0588 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0608 */ public string LegacyItemConversionTable;
        /* 0x0688 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Size = 0x80)]
        /* 0x0698 */ public string ConsumableItemTable;
        [NMS(Size = 0x80)]
        /* 0x0718 */ public string RecipeTable;
        [NMS(Size = 0x80)]
        /* 0x0798 */ public string AlienWordsTable;
        /* 0x0818 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0828 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0890 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0A24 */ public TkCurveType[] WeightingCurves;
        /* 0x0A40 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0A50 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0AD0 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B50 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0BD0 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0C50 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0CD0 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0D50 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0DD0 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0E50 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0ED0 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0F50 */ public string UnlockableItemTrees;
        /* 0x0FD0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x0FE0 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xC, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x11A0 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1260 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x12D0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1350 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1450 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1570 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x16FC */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1888 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1A14 */ public float[] WeightedTextWeights;
        /* 0x1A20 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x64A0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6500 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6530 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x65C0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0x96, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6A64 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xB7BC */ public byte[] PaddingB7BC;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xB7C0 */ public GcStats[] Stats;
        /* 0xB810 */ public GcTechList StationTechShops;
        [NMS(Size = 0xD)]
        /* 0xB820 */ public GcTechList[] PlanetTechShops;
        /* 0xB8F0 */ public GcTradeSettings TradeSettings;
        /* 0xC340 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xC360 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xC380 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xC3A0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xC3C0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xC3E0 */ public List<int> SuitUpgradePrices;
        /* 0xC3F0 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xC400 */ public List<int> SuitCargoUpgradePrices;
        /* 0xC410 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xC420 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xC430 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xC444 */ public byte[] PaddingC444;
        /* 0xC448 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
