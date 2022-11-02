namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDFACA66786AB325, NameHash = 0x83ECCC918AB076A1)]
    public class GcPlayerWeaponClass : NMSTemplate
    {
        // size: 0x9
        public enum WeaponClassEnum {
            None,
            Projectile,
            ChargedProjectile,
            Laser,
            Grenade,
            Utility,
            TerrainEditor,
            Spawner,
            SpawnerAlt
        }
        /* 0x0 */ public WeaponClassEnum WeaponClass;
    }
}
