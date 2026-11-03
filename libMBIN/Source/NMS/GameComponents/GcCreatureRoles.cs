namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B4ACE8781DC4095, NameHash = 0x6C8463A8)]
    public class GcCreatureRoles : NMSTemplate
    {
        // size: 0xB
        public enum CreatureRoleEnum : uint {
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
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureRoleEnum CreatureRole;
    }
}
