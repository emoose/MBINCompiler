namespace libMBIN.Models.Structs
{
    public class GcMissionCategory : NMSTemplate
    {
        public int MissionCategory;
        public string[] MissionCategoryValues()
        {
            return new[] { "Info", "Mission", "Danger", "Urgent" };
        }
    }
}
