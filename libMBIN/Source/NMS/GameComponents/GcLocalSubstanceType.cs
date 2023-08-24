namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7A9039BF7A8F27, NameHash = 0xE639CB6E87DF64B)]
    public class GcLocalSubstanceType : NMSTemplate
    {
        // size: 0x4
        public enum LocalSubstanceTypeEnum : uint {
            Any,
            Common,
            Uncommon,
            Rare,
        }
        /* 0x0 */ public LocalSubstanceTypeEnum LocalSubstanceType;
    }
}
