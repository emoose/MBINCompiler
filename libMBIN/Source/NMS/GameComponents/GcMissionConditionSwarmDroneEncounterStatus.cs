namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF0813FD1B0AA239, NameHash = 0x18D23EC8)]
    public class GcMissionConditionSwarmDroneEncounterStatus : NMSTemplate
    {
        // size: 0x3
        public enum SwarmDroneEncounterStatusTestEnum : uint {
            IsActive,
            HasEngaged,
            IsInactive,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SwarmDroneEncounterStatusTestEnum SwarmDroneEncounterStatusTest;
    }
}
