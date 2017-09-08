namespace libMBIN.Models.Structs
{
    public class GcPhysicsCollisionGroups : NMSTemplate
    {
        public int CollisionGroup;
        public string[] CollisionGroupValues()
        {
            return new[] { "Normal", "Water", "Terrain", "Substance", "Asteroid", "TerrainInstance", "TerrainActivated", "Player",
                           "Creature", "Spaceship", "Debris", "Shield", "Waypoint", "NetworkPlayer"};
        }
    }
}
