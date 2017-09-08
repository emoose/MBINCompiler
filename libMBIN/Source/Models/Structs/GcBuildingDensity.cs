namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDensity : NMSTemplate // 0x14 bytes
    {
        public float BuildingSpacing;
        [NMS(Size = 0x4, EnumValue = new[] { "Cluster", "Large", "Small", "None" })]
        public float[] BuildingClusterChance;
    }
}
