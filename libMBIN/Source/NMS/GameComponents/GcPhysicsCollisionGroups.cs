namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A6DA836AA3B7B1D2)]
    public class GcPhysicsCollisionGroups : NMSTemplate
    {
		public enum CollisionGroupEnum { Normal, Water, Terrain, Substance, Asteroid, TerrainInstance, TerrainActivated, Player, Creature, Spaceship, Debris, Shield, Waypoint, NetworkPlayer }
		public CollisionGroupEnum CollisionGroup;
    }
}
