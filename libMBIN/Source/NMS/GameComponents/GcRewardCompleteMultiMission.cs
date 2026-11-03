using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6164D91253B9812D, NameHash = 0x9DF9DEE9)]
    public class GcRewardCompleteMultiMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> Missions;
    }
}
