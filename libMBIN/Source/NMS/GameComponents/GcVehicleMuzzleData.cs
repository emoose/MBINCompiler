using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0D1796B696C86F8, NameHash = 0x2BA616233E287BB2)]
    public class GcVehicleMuzzleData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x0 */ public NMSString0x10[] MuzzleFlashDataID;
    }
}
