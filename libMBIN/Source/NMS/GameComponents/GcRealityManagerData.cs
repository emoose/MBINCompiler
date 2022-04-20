using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xECE0, GUID = 0x32AC24F938FB5B75, NameHash = 0x5930542B7B565329)]
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
        /* 0x0810 */ public NMSString0x80 DialogClearanceTable;
        /* 0x0890 */ public NMSString0x80 AlienWordsTable;
        /* 0x0910 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x7F, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0920 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x7F, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x09A0 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0B9C */ public TkCurveType[] WeightingCurves;
        /* 0x0BB8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0BC8 */ public NMSString0x80 RewardTable;
        /* 0x0C48 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0CC8 */ public NMSString0x80 InventoryTable;
        /* 0x0D48 */ public NMSString0x80 DamageTable;
        /* 0x0DC8 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0E48 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0EC8 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0F48 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x0FC8 */ public NMSString0x80 CostTable;
        /* 0x1048 */ public NMSString0x80 TradingCostTable;
        /* 0x10C8 */ public NMSString0x80 TradingClassDataTable;
        /* 0x1148 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x11C8 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x1248 */ public NMSString0x80 SettlementPerksTable;
        /* 0x12C8 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x1348 */ public NMSString0x80 CombatEffectsTable;
        /* 0x13C8 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x13D8 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1598 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x16C8 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1738 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x17C8 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x18E8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1A2C */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1BB8 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1D44 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1ED0 */ public float[] WeightedTextWeights;
        /* 0x1EE0 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7330 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x7390 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x73C0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x7450 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xB9, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x78F4 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xD858 */ public GcStats[] Stats;
        /* 0xD8A8 */ public List<NMSString0x10> AvailableTech;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xD8B8 */ public GcTechList[] PlanetTechShops;
        /* 0xD9B8 */ public GcTradeSettings TradeSettings;
        /* 0xEB98 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0xEBA8 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xEBC8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xEBE8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xEC08 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xEC28 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xEC48 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0xEC68 */ public List<int> SuitUpgradePrices;
        /* 0xEC78 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xEC88 */ public List<int> SuitCargoUpgradePrices;
        /* 0xEC98 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xECA8 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xECB8 */ public float[] NormalisedPriceLimits;
        /* 0xECD0 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
