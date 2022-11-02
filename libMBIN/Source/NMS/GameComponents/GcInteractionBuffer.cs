using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AE56DB145D0EBA, NameHash = 0x7355BB5E5AC6EB4A)]
    public class GcInteractionBuffer : NMSTemplate
    {
        /* 0x00 */ public List<GcInteractionData> Interactions;
        /* 0x10 */ public int CurrentPos;
    }
}
