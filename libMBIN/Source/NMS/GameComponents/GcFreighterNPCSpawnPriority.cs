using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x767A742BD74A8EA6, NameHash = 0x18A9A925)]
    public class GcFreighterNPCSpawnPriority : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<float> PriorityScale;
    }
}
