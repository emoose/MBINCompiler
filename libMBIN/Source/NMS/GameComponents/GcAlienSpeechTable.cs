using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFD87A2A91D8B5A1, NameHash = 0xCC5FB6577E4B6B47)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienSpeechEntry> Table;
    }
}
