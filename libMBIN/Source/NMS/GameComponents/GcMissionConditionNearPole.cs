namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99569AD8ED653AB9, NameHash = 0x5D8EF27FCF8A3E08)]
    public class GcMissionConditionNearPole : NMSTemplate
    {
        // size: 0x2
        public enum PoleConditionEnum {
            North,
            South,
        }
        /* 0x0 */ public PoleConditionEnum PoleCondition;
        /* 0x4 */ public float Distance;
    }
}
