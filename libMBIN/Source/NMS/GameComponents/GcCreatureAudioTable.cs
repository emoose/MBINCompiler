using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9ECC7DB7777A6923, NameHash = 0x5CA0AF3D94711819)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureVocalSoundData> Table;
    }
}
