using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiSpecialTextStyleData : NMSTemplate       // size: 0x38
    {
        [NMS(Size = 0x10)]
        public string Name;

        public List<NMSTemplate> StyleProperties;
        public GcNGuiStyleAnimationData Animation;
    }
}
