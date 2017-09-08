namespace libMBIN.Models.Structs
{
    public class GcBuildingDistribution : NMSTemplate // size: 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public int MinDistance;
        public int MaxDistance;
    }
}
