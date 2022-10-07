using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD7FAE746628BE28, NameHash = 0xE9A41D09A14F59E1)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        /* 0x00 */ public GcMissionConditionIsScanEventLocal Local;
        /* 0x28 */ public float MaxDistance;
    }
}
