using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x662544D8FEF1E355)]
    public class GcPlayerMissionParticipantType : NMSTemplate
    {
		public enum ParticipantTypeEnum { None, MissionGiver, Primary, Secondary1, Secondary2, Secondary3, Secondary4, Secondary5, Secondary6, Secondary7, Secondary8, Secondary9 }
		public ParticipantTypeEnum ParticipantType;
    }
}
