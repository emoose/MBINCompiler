using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1397D03F597B56A3, NameHash = 0x9D5EE4FB6274CF9E)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x08 */ public NMSString0x10 Substance;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public bool TakeAmountFromSeasonData;
        /* 0x20 */ public GcItemNeedPurpose Purpose;
    }
}
