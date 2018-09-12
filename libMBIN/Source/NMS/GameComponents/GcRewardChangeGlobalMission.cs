namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5114BC010AE35BF2)]
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
    }
}
