using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF1FC2726437DA43, NameHash = 0x84CAAF45)]
    public class GcMissionConditionHasLocalSubstance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        [NMS(Index = 4)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 6)]
        /* 0x24 */ public float DefaultValueMultiplier;
        [NMS(Index = 3)]
        /* 0x28 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 1)]
        /* 0x2C */ public int UseSpecificPlanetIndex;
        [NMS(Index = 7)]
        /* 0x30 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 5)]
        /* 0x31 */ public bool UseDefaultValue;
        [NMS(Index = 2)]
        /* 0x32 */ public bool UseRandomPlanetIndex;
    }
}
