using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EEE323E292679F3, NameHash = 0xCC7E718A)]
    public class GcMissionConditionPlanetResourceHint : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocalResource;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ResourceHint;
        [NMS(Index = 4)]
        /* 0x30 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 2)]
        /* 0x34 */ public int UseSpecificPlanetIndexForLocalResource;
        [NMS(Index = 5)]
        /* 0x38 */ public bool AllowInShip;
        [NMS(Index = 6)]
        /* 0x39 */ public bool AllowNexus;
        [NMS(Index = 7)]
        /* 0x3A */ public bool TestAllPlanetsInSystem;
        [NMS(Index = 3)]
        /* 0x3B */ public bool UseRandomPlanetIndexForLocalResource;
    }
}
