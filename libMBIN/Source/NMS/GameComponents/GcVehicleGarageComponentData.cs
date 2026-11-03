using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6007415E6A4F5CF4, NameHash = 0x84E4FBDA)]
    public class GcVehicleGarageComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcVehicleType Vehicle;
    }
}
