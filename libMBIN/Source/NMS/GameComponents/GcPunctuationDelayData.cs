using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C9ABF2C23D96E50, NameHash = 0x550D77569C679867)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        /* 0x00 */ public List<GcPunctuationDelay> PunctuationList;
        /* 0x10 */ public float DefaultDelay;
    }
}
