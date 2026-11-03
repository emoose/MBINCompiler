using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2654A1B2D0B2F0C9, NameHash = 0xE281E250)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 NodeId;
        // size: 0x2
        public enum BlendOperationEnum : uint {
            Blend,
            Add,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public BlendOperationEnum BlendOperation;
    }
}
