namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x4, GUID = 0x6B55DA1A2BA483CF)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
		public enum FreighterInCurrentSystemEnum { DontCare, Yes, No }
		public FreighterInCurrentSystemEnum FreighterInCurrentSystem;
    }
}
