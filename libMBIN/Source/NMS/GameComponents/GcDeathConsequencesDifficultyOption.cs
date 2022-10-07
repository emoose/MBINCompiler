namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7ECE5F9C7F4F277E, NameHash = 0x369AA9FC9BDA7A5E)]
    public class GcDeathConsequencesDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum DeathConsequencesDifficultyEnum {
            None,
            ItemGrave,
            DestroyItems,
            DestroySave
        }
        /* 0x0 */ public DeathConsequencesDifficultyEnum DeathConsequencesDifficulty;
    }
}
