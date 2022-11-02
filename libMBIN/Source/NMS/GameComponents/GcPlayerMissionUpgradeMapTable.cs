using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0BB693EF1246643, NameHash = 0xDA977EF5139B54E5)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerMissionUpgradeMapEntry> MissionProgressTable;
    }
}
