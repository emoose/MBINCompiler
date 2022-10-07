namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF89C0A71FC8D7360, NameHash = 0x9065C0FF676A75B3)]
    public class GcDamageReceivedDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum DamageReceivedDifficultyEnum {
            None,
            Low,
            Normal,
            High
        }
        /* 0x0 */ public DamageReceivedDifficultyEnum DamageReceivedDifficulty;
    }
}
