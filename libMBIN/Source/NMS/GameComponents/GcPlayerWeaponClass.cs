namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE64ACE13CEDD3FCC, NameHash = 0x9B13C1A9)]
    public class GcPlayerWeaponClass : NMSTemplate
    {
        // size: 0xB
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
            Fishing,
            Gravity,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponClassEnum WeaponClass;
    }
}
