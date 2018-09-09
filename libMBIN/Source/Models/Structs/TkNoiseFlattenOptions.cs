namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E695E1E233A01B36)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
		public enum FlatteningEnum { None, Natural, Artificial, AddResource }
		public FlatteningEnum Flattening;

		public enum WaterPlacementEnum { None, Underwater }
		public WaterPlacementEnum WaterPlacement;
    }
}
