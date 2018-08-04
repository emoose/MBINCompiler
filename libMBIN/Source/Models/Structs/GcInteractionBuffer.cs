using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;
    }
}
