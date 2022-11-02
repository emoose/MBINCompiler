namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7614C0E89F3BC418, NameHash = 0x81EBB5E64823914E)]
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
