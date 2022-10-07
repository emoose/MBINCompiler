namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEF459B5382A1849, NameHash = 0x1C73992CC7DA5C9A)]
    public class GcAIShipWeapons : NMSTemplate
    {
        // size: 0x3
        public enum AIShipWeaponEnum {
            Projectile,
            Laser,
            MiningLaser
        }
        /* 0x0 */ public AIShipWeaponEnum AIShipWeapon;
    }
}
