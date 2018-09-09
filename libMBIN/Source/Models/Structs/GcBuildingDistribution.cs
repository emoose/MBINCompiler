namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x401D8256EF89A26A)]
    public class GcBuildingDistribution : NMSTemplate // size: 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public int MinDistance;
        public int MaxDistance;
    }
}
