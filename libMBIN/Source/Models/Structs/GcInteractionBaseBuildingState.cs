using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public int Time;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
