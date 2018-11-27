using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x500, GUID = 0x69FFF37CCA5995E5)]
    public class GcFrigateTraitIcons : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" })]

        public NMSString0x80[] Icons;
    }
}
