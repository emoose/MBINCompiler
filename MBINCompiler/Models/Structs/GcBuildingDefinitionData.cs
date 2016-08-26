namespace MBINCompiler.Models.Structs
{
    public class GcBuildingDefinitionData : NMSTemplate // 0x48 bytes
    {
        public TkNoiseFlattenOptions FlattenType;
        public GcBuildingClusterPlacement BuildingClusterPlacement;
        public bool AddWaypoint;
        public bool AddLandingPad;

        public float Density1; // todo: change this to float[]
        public float Density2;
        public float Density3;
        public float Density4;
        public float Density5;
        public float Density6;

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
