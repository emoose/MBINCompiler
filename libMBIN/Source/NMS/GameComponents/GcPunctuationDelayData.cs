using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA4A2E012A4EF721, NameHash = 0x550D77569C679867)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        /* 0x00 */ public List<GcPunctuationDelay> PunctuationList;
        /* 0x10 */ public float DefaultDelay;
    }
}
