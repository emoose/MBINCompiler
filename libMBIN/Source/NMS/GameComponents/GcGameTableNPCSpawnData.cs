using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60D6088A94A8CB06, NameHash = 0x716706C8)]
    public class GcGameTableNPCSpawnData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x20A> AvailableTitles;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 NPCPlacementId;
    }
}
