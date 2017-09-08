namespace MBINCompiler.Models.Structs
{
    public class GcStatsTypes : NMSTemplate
    {
        public int StatsType;
        public string[] StatsTypeValues()
        {
            return new[]
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
            };
        }
    }
}
