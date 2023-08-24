using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FA3ABFFC1FE9695, NameHash = 0x683A723031B5DB0F)]
    public class GcMissionConditionPlanetResourceHint : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ResourceHint;
        /* 0x10 */ public NMSString0x20A UseScanEventToDetermineLocalResource;
        /* 0x30 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x34 */ public bool AllowInShip;
        /* 0x35 */ public bool TestAllPlanetsInSystem;
    }
}
