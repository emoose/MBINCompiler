using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD8FF2FBCC8B3A25, NameHash = 0x5547CD97D9D4DE4)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCInteractionData> NPCInteractions;
    }
}
