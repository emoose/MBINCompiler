using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8CB3BE00363FBA01, NameHash = 0x39D1580ABEEE58C3)]
    public class GcTradingCategoryData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public float ProductMultiplierChangePer100;
        /* 0xC8 */ public float SubstanceMultiplierChangePer100;
    }
}
