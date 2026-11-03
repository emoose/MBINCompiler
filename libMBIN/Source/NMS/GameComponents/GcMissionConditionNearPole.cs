namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB42BD911A67D2FFA, NameHash = 0x2BF3C644)]
    public class GcMissionConditionNearPole : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Distance;
        // size: 0x2
        public enum PoleConditionEnum : uint {
            North,
            South,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public PoleConditionEnum PoleCondition;
    }
}
