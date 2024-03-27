namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61187D71A7849AFA, NameHash = 0x83ECCC918AB076A1)]
    public class GcPlayerWeaponClass : NMSTemplate
    {
        // size: 0x9
        public enum WeaponClassEnum : uint {
            None,
            Projectile,
            ChargedProjectile,
            Laser,
            Grenade,
            Utility,
            TerrainEditor,
            Spawner,
            SpawnerAlt,
        }
        /* 0x0 */ public WeaponClassEnum WeaponClass;
    }
}
