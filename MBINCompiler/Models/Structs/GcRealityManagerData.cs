using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRealityManagerData : NMSTemplate
    {
        public float RealityIteration;

        // TODO: Probably keep these values in a static class.
        [NMSAttribute(Size = 7, EnumValue = new string[7] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector" })]
        public GcDiscoveryWorth[] DiscoveryWorth;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string TechnologyTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string SubstanceTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string ProductTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string AlienWordsTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string AlienPuzzlesTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string RewardTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string RewardDestructTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string InventoryTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string DamageTable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string CostTable;

        public GcRealityIconTable Icons;

        [NMSAttribute(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        public Colour[] HazardColours;

        [NMSAttribute(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        public Colour[] RarityColours;

        [NMSAttribute(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special" })]
        public Colour[] SubstanceCategoryColours;

        [NMSAttribute(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special" })]
        public TkTextureResource[] SubstanceChargeIcons;

        [NMSAttribute(Ignore = true)]
        public int EmptyNode1;

        [NMSAttribute(Size = 70, EnumValue = new string[70]
            {
                "Weapon_Laser", "Weapon_Laser_Damage", "Weapon_Laser_Mining_Damage", "Weapon_Laser_Mining_Speed", "Weapon_Laser_HeatTime", "Weapon_Laser_Bounce", "Weapon_Laser_ReloadTime", "Weapon_Laser_Recoil",
                "Weapon_Projectile", "Weapon_Projectile_Damage", "Weapon_Projectile_Mining_Damage", "Weapon_Projectile_Range", "Weapon_Projectile_Rate", "Weapon_Projectile_ClipSize", "Weapon_Projectile_ReloadTime", "Weapon_Projectile_Recoil",
                "Weapon_Projectile_Bounce", "Weapon_Projectile_Homing", "Weapon_Projectile_Dispersion", "Weapon_Projectile_BulletsPerShot", "Weapon_Projectile_MaximunCharge", "Weapon_Grenade", "Weapon_Grenade_Damage", "Weapon_Grenade_Radius",
                "Weapon_Grenade_Speed", "Weapon_Grenade_Bounce", "Weapon_Grenade_Homing", "Weapon_Grenade_Clusterbomb", "Weapon_Grenade_Mining_Damage", "Weapon_Scan", "Weapon_Scan_Radius", "Weapon_Scan_Recharge_Time",
                "Weapon_Scan_Types", "Weapon_Scan_Binoculars", "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength", "Suit_Protection", "Suit_Protection_Cold", "Suit_Protection_Heat",
                "Suit_Protection_Toxic", "Suit_Protection_Radiation", "Suit_Protection_Energy", "Suit_Stamina_Strength", "Suit_Stamina_Speed", "Suit_Underwater", "Suit_Jetpack", "Suit_Jetpack_Tank",
                "Suit_Energy", "Ship_Weapons_Guns", "Ship_Weapons_Guns_Damage", "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime", "Ship_Weapons_Guns_ClipSize", "Ship_Weapons_Lasers", "Ship_Weapons_Lasers_Damage",
                "Ship_Weapons_Lasers_HeatTime", "Ship_Weapons_Missiles", "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health", "Ship_Scan", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance",
                "Ship_Launcher", "Ship_Launcher_TakeOffCost", "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost", "Ship_Maneuverability"
            })]
        public TkTextureResource[] StatCategoryIcons;

        [NMSAttribute(Ignore = true)]
        public int EmptyNode2;

        [NMSAttribute(Size = 3, EnumValue = new string[3] { "Suit", "Weapon", "Ship" })]
        public GcStats[] Stats;

        public GcTradeSettings TradeSettings;

        public List<NMSInt> SuitUpgradePrices;

        public List<NMSString0x10> NeverSellableItems;

        [NMSAttribute(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special" })]
        public NMSFloat[] NormalizedPriceLimits;
    }
}
