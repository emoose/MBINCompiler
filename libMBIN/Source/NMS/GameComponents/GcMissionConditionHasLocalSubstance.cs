using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13E84518CA663F19, NameHash = 0xE42DA1D15CDA0F31)]
    public class GcMissionConditionHasLocalSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        /* 0x20 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x24 */ public int Amount;
        /* 0x28 */ public bool UseDefaultValue;
        /* 0x2C */ public float DefaultValueMultiplier;
        /* 0x30 */ public bool TakeAmountFromSeasonData;
    }
}
