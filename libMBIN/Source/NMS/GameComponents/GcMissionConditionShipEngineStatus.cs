namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53E888018E30D82B, NameHash = 0x9A43A9B870251F8C)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        // size: 0x9
        public enum EngineStatusEnum : uint {
            Thrusting,
            Braking,
            Landing,
            Landed,
            Boosting,
            Pulsing,
            LowFlight,
            Inverted,
            EnginesRepaired,
        }
        /* 0x0 */ public EngineStatusEnum EngineStatus;
    }
}
