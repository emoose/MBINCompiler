using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93C0B35F1A185BE, NameHash = 0xD0AEA222)]
    public class GcMissionConditionVehicleWeaponMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcVehicleWeaponMode VehicleWeaponMode;
    }
}
