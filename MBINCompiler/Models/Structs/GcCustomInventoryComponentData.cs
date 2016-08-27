using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Size;
        public List<GcInventoryTechProbability> DesiredTechs;

        public bool Cool;
    }
}
