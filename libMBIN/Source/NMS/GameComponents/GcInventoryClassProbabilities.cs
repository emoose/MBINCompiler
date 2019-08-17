using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4D86CADD1E49AD2, SubGUID = 0x8179391B845D50D7)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] ClassProbabilities;
    }
}
