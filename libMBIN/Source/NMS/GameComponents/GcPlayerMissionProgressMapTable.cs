using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x97711ED5616C8AA0)]
    public class GcPlayerMissionProgressMapTable : NMSTemplate
    {
        public List<GcPlayerMissionProgressMapEntry> MissionProgressTable;
    }
}
