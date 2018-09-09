using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x0A055E241AA30DB8)]
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;
    }
}
