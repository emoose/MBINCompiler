using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;

        public float CurrentPos;
    }
}
