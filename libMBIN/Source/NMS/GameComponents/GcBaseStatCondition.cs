namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32C63B04BA29396F, NameHash = 0xE20ED6F8)]
    public class GcBaseStatCondition : NMSTemplate
    {
        // size: 0x2
        public enum BaseStatEnum : uint {
            HasTeleporter,
            HasMainframe,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseStatEnum BaseStat;
        [NMS(Index = 1)]
        /* 0x4 */ public bool StatValue;
    }
}
