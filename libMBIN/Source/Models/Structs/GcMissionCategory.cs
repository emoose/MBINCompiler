namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1C14B0D6CD418514)]
    public class GcMissionCategory : NMSTemplate
    {
		public enum MissionCategoryEnum { Info, Mission, Danger, Urgent }
		public MissionCategoryEnum MissionCategory;
    }
}
