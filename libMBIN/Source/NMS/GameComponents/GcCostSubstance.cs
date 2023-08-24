using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEDE1897D6DCE6DE, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public NMSString0x20A UseScanEventToDetermineLocalSubstance;
        /* 0x38 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x3C */ public int Amount;
        /* 0x40 */ public bool UseDefaultAmount;
    }
}
