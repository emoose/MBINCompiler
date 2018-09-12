using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x0A055E241AA30DB8)]
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;
    }
}
