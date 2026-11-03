using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA240BE3EA7B1153F, NameHash = 0x5EBD01FD)]
    public class GcFreighterRoomNPCSpawnCapacities : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterRoomNPCSpawnCapacityEntry> RoomSpawnCapacities;
    }
}
