namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB00C4F33BF93C17F, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // size: 0x13
        public enum WeaponModeEnum {
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
        }
        /* 0x0 */ public WeaponModeEnum WeaponMode;
    }
}
