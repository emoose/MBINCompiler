using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF393ECED0B0A81, NameHash = 0x783F7F56522EAFC6)]
    public class GcPlayerMissionUpgradeMapEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int MinProgress;
        /* 0x14 */ public int CompletePoint;
        /* 0x18 */ public NMSString0x10 NewMission;
        /* 0x28 */ public List<NMSString0x10> CompletedMissions;
    }
}
