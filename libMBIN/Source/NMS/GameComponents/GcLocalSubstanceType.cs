namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C0C34C6B3A8ED3A, NameHash = 0x77AD0597)]
    public class GcLocalSubstanceType : NMSTemplate
    {
        // size: 0x5
        public enum LocalSubstanceTypeEnum : uint {
            AnyDeposit,
            Common,
            Uncommon,
            Rare,
            Plant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LocalSubstanceTypeEnum LocalSubstanceType;
    }
}
