using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76DE931DEDBBFF79, NameHash = 0xE50541DA)]
    public class GcNPCInteractionsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCInteractionData> NPCInteractions;
    }
}
