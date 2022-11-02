using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC62A7F5293F76A6, NameHash = 0xE9A41D09A14F59E1)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        /* 0x00 */ public GcMissionConditionIsScanEventLocal Local;
        /* 0x28 */ public float MaxDistance;
    }
}
