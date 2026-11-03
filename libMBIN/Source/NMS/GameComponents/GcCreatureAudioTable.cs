using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46081FD3AB9057A3, NameHash = 0xDE30A63F)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureVocalSoundData> Table;
    }
}
