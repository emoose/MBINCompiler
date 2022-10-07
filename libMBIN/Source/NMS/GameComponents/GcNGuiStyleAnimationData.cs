using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCF210A46376F40B, NameHash = 0x7CC4297B73C8CB65)]
    public class GcNGuiStyleAnimationData : NMSTemplate
    {
        /* 0x0 */ public float Length;
        /* 0x4 */ public bool Loop;
        /* 0x5 */ public bool AnimateByDefault;
        /* 0x8 */ public List<GcNGuiStyleAnimationKeyframeData> KeyFrames;
    }
}
