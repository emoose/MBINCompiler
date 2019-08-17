using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x5C119C6B02E613B, SubGUID = 0x38BD9FF11F2B46AB)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" })]
        /* 0x00 */ public GcFrigateStatRange[] Stats;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string InitialTrait;
    }
}
