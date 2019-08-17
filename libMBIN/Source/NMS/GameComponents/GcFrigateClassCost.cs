using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x25C9483BA5237DCE, SubGUID = 0x8505F02597BABF0)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public int[] Cost;
    }
}
