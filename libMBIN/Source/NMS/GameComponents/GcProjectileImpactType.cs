namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x89F8948FA2B8AD2A)]
    public class GcProjectileImpactType : NMSTemplate
    {
		public enum ImpactEnum { Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot, Freighter, Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer }
		public ImpactEnum Impact;
    }
}
