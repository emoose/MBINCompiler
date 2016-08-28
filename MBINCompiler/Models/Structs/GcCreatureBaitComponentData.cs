using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        public List<NMSString0x10> AttractList;
        public float BaitStrength;
        public float BaitRadius;

        public bool Debug;
        public bool InducesRage;
    }
}
