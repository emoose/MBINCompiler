namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x924902421A250CF9, NameHash = 0x685F577065EC8459)]
    public class GcSubstanceCollectionDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum SubstanceCollectionDifficultyEnum {
            High,
            Normal,
            Low
        }
        /* 0x0 */ public SubstanceCollectionDifficultyEnum SubstanceCollectionDifficulty;
    }
}
