using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DE13CFB6BC263E0, NameHash = 0x5F4A54D2)]
    public class GcInteractionBuffer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcInteractionData> Interactions;
        [NMS(Index = 1)]
        /* 0x10 */ public int CurrentPos;
    }
}
