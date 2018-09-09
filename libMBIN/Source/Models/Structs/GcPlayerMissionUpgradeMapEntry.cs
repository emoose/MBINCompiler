using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4A9DE083678EC5C2)]
    public class GcPlayerMissionUpgradeMapEntry : NMSTemplate       // size: 0x38
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Mission;
        /* 0x10 */ public int MinProgress;
        /* 0x14 */ public int CompletePoint;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string NewMission;

        /* 0x28 */ public List<NMSString0x10> CompleteMissions;
    }
}
