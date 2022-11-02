using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x363230146FE793AA, NameHash = 0xE8C35E70B4AA8A05)]
    public class GcBlackboardIntCompareDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public TkBlackboardDefaultValueInteger CompareTo;
        /* 0x30 */ public TkBlackboardComparisonTypeEnum Comparison;
        /* 0x38 */ public NMSTemplate OnTrue;
        /* 0x88 */ public NMSTemplate OnFalse;
    }
}
