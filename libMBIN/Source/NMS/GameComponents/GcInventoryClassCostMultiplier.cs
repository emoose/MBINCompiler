using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x50538964135E2380, SubGUID = 0x1FA80ABD4B6B665)]
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] Multiplier;
    }
}
