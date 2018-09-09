using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x74D72ACAAE69D013)]
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public int Time;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
