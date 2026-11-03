using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF91AD9956F9EA08E, NameHash = 0xF53349F1)]
    public class GcDeathStateData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcTextPreset AuthorFont;
        [NMS(Index = 2)]
        /* 0x30 */ public GcTextPreset QuoteFont;
        [NMS(Index = 1)]
        /* 0x60 */ public GcTextPreset ReasonFont;
        [NMS(Index = 0)]
        /* 0x90 */ public List<GcDeathQuote> Quotes;
    }
}
