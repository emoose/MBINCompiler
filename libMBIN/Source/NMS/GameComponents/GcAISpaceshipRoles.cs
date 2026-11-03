namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8FA58A5DA817752, NameHash = 0xA200B6EB)]
    public class GcAISpaceshipRoles : NMSTemplate
    {
        // size: 0x9
        public enum AIShipRoleEnum : uint {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate,
            Biggs,
            SwarmDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIShipRoleEnum AIShipRole;
    }
}
