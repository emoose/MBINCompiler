namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58F5C32E89575C8A, NameHash = 0xA077128E)]
    public class GcWaterEmissionBehaviourType : NMSTemplate
    {
        // size: 0x4
        public enum WaterEmissionBehaviourTypeEnum : uint {
            None,
            Constant,
            Pulse,
            NightOnly,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterEmissionBehaviourTypeEnum WaterEmissionBehaviourType;
    }
}
