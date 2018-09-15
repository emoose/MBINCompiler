using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEA5859C2FF238F28)]
    public class GcMissionType : NMSTemplate
    {
		public enum MissionTypeEnum { SpaceCombat, GroundCombat, Research, MissingPerson, Repair, Cargo, Piracy, Photo, Feeding }
		public MissionTypeEnum MissionType;
    }
}
