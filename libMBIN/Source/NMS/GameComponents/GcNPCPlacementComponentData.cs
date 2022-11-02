using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA277EF06126AD500, NameHash = 0x8047BE4D11BB54C8)]
    public class GcNPCPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public bool SearchPlacementFromMaster;
        /* 0x01 */ public bool PlaceInAbandonedSystems;
        /* 0x08 */ public List<NMSString0x10> PlacementInfosToApply;
        /* 0x18 */ public bool WaitToPlace;
    }
}
