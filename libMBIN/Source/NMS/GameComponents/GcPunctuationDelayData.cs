using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CFF5CA5D0A735B7, NameHash = 0x550D77569C679867)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        /* 0x00 */ public List<GcPunctuationDelay> PunctuationList;
        /* 0x10 */ public float DefaultDelay;
    }
}
