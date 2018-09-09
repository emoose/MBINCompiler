namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6BD9AA6BD053E5CF)]
    public class GcMissionConditionGlobalMission : NMSTemplate
    {
        // I *think* this should be embedded in another struct, but this should have the same effect...
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
    }
}
