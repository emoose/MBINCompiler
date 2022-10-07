using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EE2B8B24EB493DD, NameHash = 0x5B824AD343C4561E)]
    public class GcDeathStateData : NMSTemplate
    {
        /* 0x00 */ public List<GcDeathQuote> Quotes;
        /* 0x10 */ public GcTextPreset ReasonFont;
        /* 0x80 */ public GcTextPreset QuoteFont;
        /* 0xF0 */ public GcTextPreset AuthorFont;
    }
}
