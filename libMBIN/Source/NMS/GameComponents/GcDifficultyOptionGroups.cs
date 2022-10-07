namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B558D8842708343, NameHash = 0x48BADFDDC969F879)]
    public class GcDifficultyOptionGroups : NMSTemplate
    {
        // size: 0x4
        public enum DifficultyOptionGroupEnum {
            Survival,
            Crafting,
            Combat,
            Ease
        }
        /* 0x0 */ public DifficultyOptionGroupEnum DifficultyOptionGroup;
    }
}
