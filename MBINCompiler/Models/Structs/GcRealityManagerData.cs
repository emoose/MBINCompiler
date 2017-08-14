using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRealityManagerData : NMSTemplate     // size: 0x7440
    {
        /* 0x0000 */ public uint RealityIteration;

        [NMS(Size = 0xA)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x011C */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12C */ public byte[] Padding12C;


        [NMS(Size = 0x80)]
        /* 0x011C */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0110 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0190 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0210 */ public string AlienWordsTable;
        [NMS(Size = 0x80)]
        /* 0x0290 */ public string AlienPuzzlesTable;
        [NMS(Size = 0x80)]
        /* 0x0310 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0390 */ public string RewardDestructTable;
        [NMS(Size = 0x80)]
        /* 0x0410 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0490 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0510 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0590 */ public string CostTable;

        /* 0x0610 */ public GcRealityIconTable Icons;

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        /* 0x1E50 */ public Colour[] HazardColours;

        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        /* 0x1EB0 */ public Colour[] RarityColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        /* 0x1EE0 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        /* 0x1F40 */ public TkTextureResource[] SubstanceChargeIcons;

        [NMS(Size = 84, EnumValue = new string[84]
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
                "Weapon_Shotgun", "Weapon_Burst", "Weapon_Rail",
                "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength", "Suit_Protection",
                "Suit_Protection_Cold", "Suit_Protection_Heat", "Suit_Protection_Toxic", "Suit_Protection_Radiation",
                "Suit_Protection_Energy", "Suit_Stamina_Strength", "Suit_Stamina_Speed", "Suit_Underwater",
                "Suit_Jetpack", "Suit_Jetpack_Tank", "Suit_Energy", "Ship_Weapons_Guns", "Ship_Weapons_Guns_Damage",
                "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime", "Ship_Weapons_Guns_Scale",
                "Ship_Weapons_Guns_BulletsPerShot", "Ship_Weapons_Guns_Dispersion", "Ship_Weapons_Guns_Range", "Ship_Weapons_Lasers",
                "Ship_Weapons_Lasers_Damage", "Ship_Weapons_Lasers_HeatTime", "Ship_Weapons_Missiles",
                "Ship_Weapons_Missiles_NumPerShot", "Ship_Weapons_Missiles_Speed", "Ship_Weapons_Missiles_Damage",
                "Ship_Weapons_Missiles_Size", "Ship_Weapons_Shotgun", "Ship_Weapons_MiniGun", "Ship_Weapons_Plasma",
                "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health",
                "Ship_Scan", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance", "Ship_Launcher", "Ship_Launcher_TakeOffCost",
                "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost", "Ship_Maneuverability"
            })]
        /* 0x2258 */ public TkTextureResource[] StatCategoryIcons;

        [NMS(Size = 3, EnumValue = new string[3] { "Suit", "Weapon", "Ship" })]
        /* 0x48A8 */ public GcStats[] Stats;

        /* 0x5588 */ public GcTradeSettings TradeSettings;

        /* 0x5628 */ public List<int> SuitUpgradePrices;

        /* 0x5638 */ public List<NMSString0x10> NeverSellableItems;

        /* 0x5648 */ public List<NMSString0x10> NeverOfferedForSale;

        [NMS(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special"})]         // not sure about these values....
        /* 0x5658 */ public float[] NormalizedPriceLimits;
    }
}
