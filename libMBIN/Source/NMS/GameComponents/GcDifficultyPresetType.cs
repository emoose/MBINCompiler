namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EFADB6935A48DD6, NameHash = 0x5401230062A6D869)]
    public class GcDifficultyPresetType : NMSTemplate
    {
        // size: 0x7
        public enum DifficultyPresetTypeEnum {
            Invalid,
            Custom,
            Normal,
            Creative,
            Relaxed,
            Survival,
            Permadeath,
        }
        /* 0x0 */ public DifficultyPresetTypeEnum DifficultyPresetType;
    }
}
