namespace MBINCompiler.Models.Structs
{
    public class GcInteractionBufferType : NMSTemplate
    {
        public int InterationBufferType;
        public string[] InterationBufferTypeValues()
        {
            return new[] { "DistressSignal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature"};
        }
    }
}
