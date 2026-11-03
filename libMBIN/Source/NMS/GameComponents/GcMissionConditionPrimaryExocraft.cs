using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23F7EA5EF9113F7F, NameHash = 0xD42CEC4C)]
    public class GcMissionConditionPrimaryExocraft : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcVehicleType ExocraftType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MustBeSummonedNearby;
    }
}
