using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DA83E2A2F37C5B5, NameHash = 0xCCEFDDFB7EC30619)]
    public class GcStatRewardGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A LocIDSingle;
        /* 0x30 */ public NMSString0x20A LocIDMultiple;
        /* 0x50 */ public TkTextureResource Icon;
        /* 0xD4 */ public GcCurrency Currency;
        /* 0xD8 */ public float BaseMultiplier;
        /* 0xE0 */ public List<GcStatRewardGroupStatData> Stats;
    }
}
