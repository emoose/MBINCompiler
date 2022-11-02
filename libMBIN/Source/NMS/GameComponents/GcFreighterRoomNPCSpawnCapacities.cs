using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD588BB028C9BE935, NameHash = 0xF9AE5C7D267CB35F)]
    public class GcFreighterRoomNPCSpawnCapacities : NMSTemplate
    {
        /* 0x0 */ public List<GcFreighterRoomNPCSpawnCapacityEntry> RoomSpawnCapacities;
    }
}
