using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A31E46440F4A5A5, NameHash = 0xC88FD2BBB93553F9)]
    public class GcPerformanceGuard : NMSTemplate
    {
        /* 0x0 */ public float Radius;
        /* 0x8 */ public GcEncounterComponentData Encounter;
    }
}
