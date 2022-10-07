namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A55F7D75764533A, NameHash = 0xB05E7D6A559B1AC0)]
    public class GcBaseStatCondition : NMSTemplate
    {
        // size: 0x2
        public enum BaseStatEnum {
            HasTeleporter,
            HasMainframe
        }
        /* 0x0 */ public BaseStatEnum BaseStat;
        /* 0x4 */ public bool StatValue;
    }
}
