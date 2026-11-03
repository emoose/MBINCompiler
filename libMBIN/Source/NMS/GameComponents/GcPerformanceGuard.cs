using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x579DF935625B4261, NameHash = 0xA4B8CB6A)]
    public class GcPerformanceGuard : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcEncounterComponentData Encounter;
        [NMS(Index = 0)]
        /* 0x18 */ public float Radius;
    }
}
