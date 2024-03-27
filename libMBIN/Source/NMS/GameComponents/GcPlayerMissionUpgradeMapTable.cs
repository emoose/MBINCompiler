using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x902317021F0DC1C, NameHash = 0xDA977EF5139B54E5)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerMissionUpgradeMapEntry> MissionProgressTable;
    }
}
