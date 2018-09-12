using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x91253F947A706088)]
    public class GcNGuiStyleAnimationData : NMSTemplate
    {
        public float Length;
        public List<GcNGuiStyleAnimationKeyframeData> KeyFrames;
    }
}
