using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B53BBA0714A089B6)]
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding0x1;
        public List<NMSString0x10> PlacementInfosToApply;
    }
}
