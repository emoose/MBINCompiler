using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1C14B0D6CD418514, SubGUID = 0x7C883BFCF9D557D5)]
    public class GcMissionCategory : NMSTemplate
    {
		public enum MissionCategoryEnum { Info, Mission, Danger, Urgent }
		public MissionCategoryEnum MissionCategory;
    }
}
