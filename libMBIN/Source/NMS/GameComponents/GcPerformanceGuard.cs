using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33774AD7F1EBEB91, NameHash = 0xC88FD2BBB93553F9)]
    public class GcPerformanceGuard : NMSTemplate
    {
        /* 0x0 */ public float Radius;
        /* 0x8 */ public GcEncounterComponentData Encounter;
    }
}
