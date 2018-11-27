using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1E0, GUID = 0x7CD92589ED95F1A0)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]

        public GcFrigateStats[] FrigateClass;
    }
}
