using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x7560)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public int RealityIteration;

        [NMS(Size = 0xB)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x0138 */ public float[] CreatureDiscoverySizeMultiplier;

        /* 0x0148 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;

        [NMS(Size = 0x80)]
        /* 0x0158 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x01D8 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0258 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x02D8 */ public string AlienWordsTable;

        /* 0x0358 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x80)]
        /* 0x0368 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x03E8 */ public string RewardDestructTable;
        [NMS(Size = 0x80)]
        /* 0x0468 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x04E8 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0568 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x05E8 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0668 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x06E8 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0768 */ public string MaintenanceGroupsTable;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Laser", "Projectile", "Shotgun", "Minigun", "Plasma", "Missile", "Rocket"})]
        /* 0x07E8 */ public GcShipWeapons[] ShipWeapons;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x09A8 */ public NMSString0x10[] FactionStandingIDs;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x0A18 */ public NMSString0x20[] FactionNames;

        [NMS(Size = 0x7, EnumValue = new string[7] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" })]
        /* 0x0AF8 */ public GcNumberedTextList[] FactionClients;

        [NMS(Size = 0x7, EnumValue = new string[7] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy" })]
        /* 0x0BF4 */ public GcNumberedTextList[] MissionNameFormats;

        [NMS(Size = 0x7, EnumValue = new string[7] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy" })]
        /* 0x0CF0 */ public GcNumberedTextList[] MissionNameAdjectives;

        [NMS(Size = 0x7, EnumValue = new string[7] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy" })]
        /* 0x0DEC */ public GcNumberedTextList[] MissionNameNouns;

        [NMS(Size = 0x3)]
        /* 0x0EE8 */ public float[] WeightedTextWeights;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0EF4 */ public byte[] PaddingEF4;

        /* 0x0EF8 */ public GcRealityIconTable Icons;

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x3F00 */ public Colour[] HazardColours;

        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        /* 0x3F60 */ public Colour[] RarityColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        /* 0x3F90 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        /* 0x3FF0 */ public TkTextureResource[] SubstanceChargeIcons;

        [NMS(Size = 0x5D, EnumValue = new string[0x5D]
            {
                "Unspecified", "Weapon_Laser", "Weapon_Laser_Damage", "Weapon_Laser_Mining_Damage", "Weapon_Laser_Mining_Speed",
                "Weapon_Laser_HeatTime", "Weapon_Laser_Bounce", "Weapon_Laser_ReloadTime", "Weapon_Laser_Recoil",
                "Weapon_Projectile", "Weapon_Projectile_Damage", "Weapon_Projectile_Mining_Damage", "Weapon_Projectile_Range",
                "Weapon_Projectile_Rate", "Weapon_Projectile_ClipSize", "Weapon_Projectile_ReloadTime",
                "Weapon_Projectile_Recoil", "Weapon_Projectile_Bounce", "Weapon_Projectile_Homing", "Weapon_Projectile_Dispersion",
                "Weapon_Projectile_BulletsPerShot", "Weapon_Projectile_MaximunCharge", "Weapon_Grenade",
                "Weapon_Grenade_Damage", "Weapon_Grenade_Radius", "Weapon_Grenade_Speed", "Weapon_Grenade_Bounce",
                "Weapon_Grenade_Homing", "Weapon_Grenade_Clusterbomb", "Weapon_Grenade_Mining_Damage", "Weapon_Scan",
                "Weapon_Scan_Radius", "Weapon_Scan_Recharge_Time", "Weapon_Scan_Types", "Weapon_Scan_Binoculars",
                "Weapon_Scan_Discovery_Creature", "Weapon_Scan_Discovery_Flora", "Weapon_Shotgun", "Weapon_Burst", "Weapon_Rail",
                "Weapon_TerrainEdit", "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength", "Suit_Protection",
                "Suit_Protection_Cold", "Suit_Protection_Heat", "Suit_Protection_Toxic", "Suit_Protection_Radiation",
                "Suit_Protection_Energy", "Suit_Stamina_Strength", "Suit_Stamina_Speed", "Suit_Underwater",
                "Suit_Jetpack", "Suit_Jetpack_Tank", "Suit_Energy", "Ship_Weapons_Guns", "Ship_Weapons_Guns_Damage",
                "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime", "Ship_Weapons_Guns_Scale",
                "Ship_Weapons_Guns_BulletsPerShot", "Ship_Weapons_Guns_Dispersion", "Ship_Weapons_Guns_Range", "Ship_Weapons_Lasers",
                "Ship_Weapons_Lasers_Damage", "Ship_Weapons_Lasers_HeatTime", "Ship_Weapons_Missiles",
                "Ship_Weapons_Missiles_NumPerShot", "Ship_Weapons_Missiles_Speed", "Ship_Weapons_Missiles_Damage",
                "Ship_Weapons_Missiles_Size", "Ship_Weapons_Shotgun", "Ship_Weapons_MiniGun", "Ship_Weapons_Plasma",
                "Ship_Weapons_Rockets", "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health",
                "Ship_Scan", "Ship_Scan_EconomyFilter", "Ship_Scan_ConflictFilter", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance",
                "Ship_Launcher", "Ship_Launcher_TakeOffCost", "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost",
                "Ship_Maneuverability", "Ship_BoostManeuverability", "Freighter_Hyperdrive",
                "Freighter_Hyperdrive_JumpDistance"
            })]
        /* 0x4308 */ public TkTextureResource[] StatCategoryIcons;

        [NMS(Size = 4, EnumValue = new string[4] { "Suit", "Weapon", "Ship", "Freighter" })]
        /* 0x7300 */ public GcStats[] Stats;

        /* 0x7340 */ public GcTradeSettings TradeSettings;
        /* 0x7450 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x7470 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x7490 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x74B0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x74D0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x74F0 */ public List<int> SuitUpgradePrices;
        /* 0x7500 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x7510 */ public List<int> SuitCargoUpgradePrices;
        /* 0x7520 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x7530 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special"})]         // not sure about these values....
        /* 0x7540 */ public float[] NormalizedPriceLimits;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}
