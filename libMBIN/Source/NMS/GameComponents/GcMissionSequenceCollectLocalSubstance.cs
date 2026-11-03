using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF7B0EA5C79C0E1B, NameHash = 0x4027C788)]
    public class GcMissionSequenceCollectLocalSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        [NMS(Index = 13)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 5)]
        /* 0x40 */ public int Amount;
        [NMS(Index = 7)]
        /* 0x44 */ public float DefaultValueMultiplier;
        [NMS(Index = 4)]
        /* 0x48 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 2)]
        /* 0x4C */ public int UseSpecificPlanetIndex;
        [NMS(Index = 9)]
        /* 0x50 */ public bool CanFormatObjectives;
        [NMS(Index = 11)]
        /* 0x51 */ public bool CanSetIcon;
        [NMS(Index = 10)]
        /* 0x52 */ public bool FromNow;
        [NMS(Index = 12)]
        /* 0x53 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 6)]
        /* 0x54 */ public bool UseDefaultValue;
        [NMS(Index = 3)]
        /* 0x55 */ public bool UseRandomPlanetIndex;
        [NMS(Index = 8)]
        /* 0x56 */ public bool WaitForSelected;
    }
}
