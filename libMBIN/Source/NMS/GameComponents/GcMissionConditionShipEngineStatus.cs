namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF85D6D62E4A641FC, NameHash = 0x559603D5)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        // size: 0xB
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
            PulsingToPlanet,
            TakingOff,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EngineStatusEnum EngineStatus;
    }
}
