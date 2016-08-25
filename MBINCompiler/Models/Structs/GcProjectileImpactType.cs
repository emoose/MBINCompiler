namespace MBINCompiler.Models.Structs
{
    public class GcProjectileImpactType : NMSTemplate
    {
        public int Impact;
        public string[] ImpactValues()
        {
            return new[] { "Default", "Terrain", "Substance", "Rock", "Asteroid", "Shield", "Creature", "Robot", "Freighter", "Cargo", "Ship", "Plant" };
        }
    }
}
