namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9064A655757AF603)]
    public class GcCreatureRoles : NMSTemplate
    {
		public enum CreatureRoleEnum { None, Predator, PlayerPredator, Prey, Passive, Bird, FishPrey, FishPredator, Butterfly, Robot }
		public CreatureRoleEnum CreatureRole;
    }
}
