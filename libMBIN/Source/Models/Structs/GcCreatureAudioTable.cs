using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7D0676974C8E6A21)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        public List<GcCreatureVocalSoundData> Table;
    }
}
