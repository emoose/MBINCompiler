namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDefinitionData : NMSTemplate // 0x48 bytes
    {
        public TkNoiseFlattenOptions FlattenType;
        public GcBuildingClusterPlacement BuildingClusterPlacement;
        public bool AddWaypoint;
        public bool AddShelter;
        public bool AddLandingPad;

        [NMS(Size = 6, EnumValue = new[] { "Dead", "Low", "Mid", "Full", "RelicOnly", "IndustrialOnly"})]
        public float[] Density;

        public int NumModelsToGenerate;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding2C;

        [NMS(Size = 0x10)]
        public string TextureNameHint;
        public float OverrideRadius;
        public bool GivesShelter;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding45;
    }
}
