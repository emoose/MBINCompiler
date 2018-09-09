namespace libMBIN.Models.Structs
{
    public class GcCreatureSpawnEnum : NMSTemplate
    {
        // 0x1A entries
		public enum IncrementorEnum { None, Resource, ResourceAway, HeavyAir, Drone, Deer, DeerScan, DeerWords, DeerWordsAway, Diplo, DiploScan, DiploWords, DiploWordsAway, Flyby, Beast, Wingmen, Scouts, Fleet, Attackers, AttackersFromBehind, Flee, RemoveFleet, Fighters, PostFighters, Escape, Warp }
		public IncrementorEnum Incrementor;
    }
}
