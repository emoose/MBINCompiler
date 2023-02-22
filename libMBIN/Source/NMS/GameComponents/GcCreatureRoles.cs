namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAA141147D899B8, NameHash = 0xA8AB3ECD5F81E80C)]
    public class GcCreatureRoles : NMSTemplate
    {
        // size: 0xB
        public enum CreatureRoleEnum {
            None,
            Predator,
            PlayerPredator,
            Prey,
            Passive,
            Bird,
            FishPrey,
            FishPredator,
            Butterfly,
            Robot,
            Pet,
        }
        /* 0x0 */ public CreatureRoleEnum CreatureRole;
    }
}
