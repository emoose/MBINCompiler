namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD1A776AAE54FF28, NameHash = 0x4533D19670B0A519)]
    public class GcAISpaceshipRoles : NMSTemplate
    {
        // size: 0x7
        public enum AIShipRoleEnum {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate
        }
        /* 0x0 */ public AIShipRoleEnum AIShipRole;
    }
}
