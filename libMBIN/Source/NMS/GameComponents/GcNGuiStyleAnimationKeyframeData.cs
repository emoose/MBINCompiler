using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9108CA5BEA846FD8)]
    public class GcNGuiStyleAnimationKeyframeData : NMSTemplate
    {
        public float Position;
        public List<NMSTemplate> StyleProperties;
    }
}
