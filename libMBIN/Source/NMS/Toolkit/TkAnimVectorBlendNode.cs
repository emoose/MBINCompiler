using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB4535ED711FA64FF, NameHash = 0xCEE7FEFDA2096939)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        // size: 0x2
        public enum BlendOperationEnum : uint {
            Blend,
            Add,
        }
        /* 0x0 */ public BlendOperationEnum BlendOperation;
        /* 0x8 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
    }
}
