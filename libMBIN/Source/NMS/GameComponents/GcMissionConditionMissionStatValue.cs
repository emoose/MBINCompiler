using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9772D161D760817, NameHash = 0x3CBC1A48)]
    public class GcMissionConditionMissionStatValue : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong MissionStatValue;
        [NMS(Index = 1)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
