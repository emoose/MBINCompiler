namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDC79F40DC21B1A3, NameHash = 0xE46A9A4173DECF1C)]
    public class GcSentinelQuadWeaponMode : NMSTemplate
    {
        // size: 0x4
        public enum SentinelQuadWeaponModeEnum : uint {
            Laser,
            MiniCannon,
            Grenades,
            Flamethrower,
        }
        /* 0x0 */ public SentinelQuadWeaponModeEnum SentinelQuadWeaponMode;
    }
}
