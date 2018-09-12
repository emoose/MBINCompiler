using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x54511EBAE64FC462)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        public List<GcPlayerMissionUpgradeMapEntry> MissionUpgradeTable;
    }
}
