using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x52ECDFFDB4B7B1CD)]
    public class GcNGuiSpecialTextStyleData : NMSTemplate       // size: 0x38
    {
        [NMS(Size = 0x10)]
        public string Name;

        public List<NMSTemplate> StyleProperties;
        public GcNGuiStyleAnimationData Animation;
    }
}
