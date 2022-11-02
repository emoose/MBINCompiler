namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9EEF44E81C424BE, NameHash = 0xE3BDE57931D2177D)]
    public class GcVehicleWeaponMode : NMSTemplate
    {
        // size: 0x4
        public enum VehicleWeaponModeEnum {
            Laser,
            Gun,
            TerrainEdit,
            StunGun
        }
        /* 0x0 */ public VehicleWeaponModeEnum VehicleWeaponMode;
    }
}
