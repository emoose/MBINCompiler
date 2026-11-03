using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC9ACA9E2A50F9E1, NameHash = 0xDED2F68A)]
    public class GcNPCPlacementComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x10> PlacementInfosToApply;
        [NMS(Index = 1)]
        /* 0x10 */ public bool PlaceInAbandonedSystems;
        [NMS(Index = 0)]
        /* 0x11 */ public bool SearchPlacementFromMaster;
        [NMS(Index = 3)]
        /* 0x12 */ public bool WaitToPlace;
    }
}
