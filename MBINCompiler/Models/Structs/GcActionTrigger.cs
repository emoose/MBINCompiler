using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }
}
