using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B807E0A43E0D5F25)]
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
