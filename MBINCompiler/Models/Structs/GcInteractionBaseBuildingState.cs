using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public int Time;
    }
}
