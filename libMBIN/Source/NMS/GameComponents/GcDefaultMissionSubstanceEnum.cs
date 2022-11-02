namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC6CA42366C4A52D, NameHash = 0x1BAC8ECF2C7CC8FC)]
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultSubstanceTypeEnum {
            None,
            PrimarySubstance,
            SecondarySubstance
        }
        /* 0x0 */ public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
