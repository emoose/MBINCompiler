namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB88294579CDD06A8, NameHash = 0x9A901BB6)]
    public class GcHostileShipEncounterPhase : NMSTemplate
    {
        // size: 0x7
        public enum HostileShipEncounterPhaseEnum : byte {
            Invalid,
            PendingSpawn,
            SpawnedPassive,
            Engaged,
            Retreating,
            Resolved,
            Complete,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HostileShipEncounterPhaseEnum HostileShipEncounterPhase;
    }
}
