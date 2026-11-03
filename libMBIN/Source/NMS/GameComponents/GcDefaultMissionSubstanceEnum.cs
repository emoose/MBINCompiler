namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0B1EA630C55ABA3, NameHash = 0xEF4406D)]
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultSubstanceTypeEnum : uint {
            None,
            PrimarySubstance,
            SecondarySubstance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
