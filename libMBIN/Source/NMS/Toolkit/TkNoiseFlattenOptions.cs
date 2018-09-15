using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE695E1E233A01B36)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
		public enum FlatteningEnum { None, Natural, Artificial, AddResource }
		public FlatteningEnum Flattening;

		public enum WaterPlacementEnum { None, Underwater }
		public WaterPlacementEnum WaterPlacement;
    }
}
