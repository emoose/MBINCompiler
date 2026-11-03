namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5111AB21727AAE2A, NameHash = 0x6708AA89)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // size: 0x15
        public enum WeaponModeEnum : uint {
            Bolt,
            Shotgun,
            Burst,
            Rail,
            Cannon,
            Laser,
            Grenade,
            MineGrenade,
            Scope,
            FrontShield,
            Melee,
            TerrainEdit,
            SunLaser,
            Spawner,
            SpawnerAlt,
            SoulLaser,
            Flamethrower,
            StunGrenade,
            Stealth,
            FishLaser,
            Gravity,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponModeEnum WeaponMode;
    }
}
