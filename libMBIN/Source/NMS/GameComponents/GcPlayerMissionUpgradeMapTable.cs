using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD98300F78D00DE90, NameHash = 0xC7B3E458)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerMissionUpgradeMapEntry> MissionProgressTable;
    }
}
