namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5BDFFE8C388B843, NameHash = 0xB05E7D6A559B1AC0)]
    public class GcBaseStatCondition : NMSTemplate
    {
        // size: 0x2
        public enum BaseStatEnum : uint {
            HasTeleporter,
            HasMainframe,
        }
        /* 0x0 */ public BaseStatEnum BaseStat;
        /* 0x4 */ public bool StatValue;
    }
}
