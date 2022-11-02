namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x201790B6229316D3, NameHash = 0xCB8A748BB740CFAE)]
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
