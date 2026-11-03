using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x255D50B7689A1346, NameHash = 0xD9E54037)]
    public class GcCostSubstance : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocalSubstance;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x34 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 5)]
        /* 0x38 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 3)]
        /* 0x3C */ public int UseSpecificPlanetIndexForLocalSubstance;
        [NMS(Index = 8)]
        /* 0x40 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 7)]
        /* 0x41 */ public bool UseDefaultAmount;
        [NMS(Index = 4)]
        /* 0x42 */ public bool UseRandomPlanetIndex;
    }
}
