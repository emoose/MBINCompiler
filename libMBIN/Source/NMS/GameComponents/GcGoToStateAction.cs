using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B1E0E8AFA4A55904)]
    public class GcGoToStateAction : NMSTemplate        // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string State;

        public bool Broadcast;
		public enum BroadcastLevelEnum { Scene, LocalModel, Local }
		public BroadcastLevelEnum BroadcastLevel;
    }
}
