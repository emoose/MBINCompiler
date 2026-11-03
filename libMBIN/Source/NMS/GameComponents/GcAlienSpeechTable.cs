using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29A23A2F80FBE6D8, NameHash = 0x27475417)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienSpeechEntry> Table;
    }
}
