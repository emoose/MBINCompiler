namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFF99D684E9C68AD, NameHash = 0x81EBB5E64823914E)]
    public class GcMissionDifficulty : NMSTemplate
    {
        // size: 0x3
        public enum MissionDifficultyEnum {
            Easy,
            Normal,
            Hard
        }
        /* 0x0 */ public MissionDifficultyEnum MissionDifficulty;
    }
}
