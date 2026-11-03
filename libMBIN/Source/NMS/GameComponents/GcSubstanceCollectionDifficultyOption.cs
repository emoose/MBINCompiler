namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA691CAE43069B8A8, NameHash = 0x7A68E227)]
    public class GcSubstanceCollectionDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum SubstanceCollectionDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SubstanceCollectionDifficultyEnum SubstanceCollectionDifficulty;
    }
}
