using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x534F6147817DB9F9, Broken = true)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate      // size: 0x10
    {
        public GcAudioWwiseEvents EventEnter;
        public GcAudioWwiseEvents EventExit;
        public float EnterDistance;
        public float ExitDistance;
    }
}
