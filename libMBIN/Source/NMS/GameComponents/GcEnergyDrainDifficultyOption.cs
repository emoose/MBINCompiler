namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DA5B6A91ADD8F5A, NameHash = 0xCB8A748BB740CFAE)]
    public class GcEnergyDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum EnergyDrainDifficultyEnum {
            Slow,
            Normal,
            Fast
        }
        /* 0x0 */ public EnergyDrainDifficultyEnum EnergyDrainDifficulty;
    }
}
