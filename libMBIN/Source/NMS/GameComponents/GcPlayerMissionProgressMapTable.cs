using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x97711ED5616C8AA0)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}
