using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0xA2066617C00AA47, SubGUID = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        public float[] BiomeProbability;
    }
}
