using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x25C9483BA5237DCE)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public int[] Cost;
    }
}
