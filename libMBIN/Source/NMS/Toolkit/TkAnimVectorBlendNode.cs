using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1300B3988CAEE69E, NameHash = 0xCEE7FEFDA2096939)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        // size: 0x2
        public enum BlendOperationEnum {
            Blend,
            Add
        }
        /* 0x0 */ public BlendOperationEnum BlendOperation;
        /* 0x8 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
    }
}
