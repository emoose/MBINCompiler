using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50FA9F8F22C819A3, NameHash = 0xD90787619164B12C)]
    public class GcPlayerWeaponPropertiesTable : NMSTemplate
    {
        /* 0x00 */ public GcCamouflageData CamouflageData;
        // size: 0x13
        public enum PropertiesDataEnum {
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
            Stealth
        }
        [NMS(Size = 0x13, EnumType = typeof(PropertiesDataEnum))]
        /* 0xA0 */ public GcPlayerWeaponPropertiesData[] PropertiesData;
    }
}
