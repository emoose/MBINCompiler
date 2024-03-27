namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8110581C7BD94717, NameHash = 0xCB8A748BB740CFAE)]
    public class GcEnergyDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum EnergyDrainDifficultyEnum : uint {
            Slow,
            Normal,
            Fast,
        }
        /* 0x0 */ public EnergyDrainDifficultyEnum EnergyDrainDifficulty;
    }
}
