namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x500F4BB9C244CE94, NameHash = 0x5983704)]
    public class GcHostileShipEncounterResolution : NMSTemplate
    {
        // size: 0x6
        public enum HostileShipEncounterResolutionEnum : byte {
            None,
            HostilesDefeated,
            HostilesEscaped,
            HostilesDespawned,
            HostilesSurrendered,
            Aborted,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HostileShipEncounterResolutionEnum HostileShipEncounterResolution;
    }
}
