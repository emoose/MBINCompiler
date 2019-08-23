using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0xC0D8F1D4BC6A18A0, SubGUID = 0xA14126BE226C6660)]
    public class GcActionSet : NMSTemplate
    {
        public GcActionSetType Type;
        public GcActionUseType Status;
        [NMS(Size = 0x20)]
        public string ExternalId;
        [NMS(Size = 0x20)]
        public string ExternalLoc;
        [NMS(Size = 0x20)]
        public string LocTag;
        public List<GcActionSetAction> Actions;
    }
}
