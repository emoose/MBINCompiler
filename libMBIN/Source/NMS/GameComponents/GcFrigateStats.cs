using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C119C6B02E613B, NameHash = 0x38BD9FF11F2B46AB)]
    public class GcFrigateStats : NMSTemplate
    {
        // size: 0xB
        public enum StatsEnum {
            Combat,
            Exploration,
            Mining,
            Diplomatic,
            FuelBurnRate,
            FuelCapacity,
            Speed,
            ExtraLoot,
            Repair,
            Invulnerable,
            Stealth
        }
        [NMS(Size = 0xB, EnumType = typeof(StatsEnum))]
        /* 0x00 */ public GcFrigateStatRange[] Stats;
        /* 0x58 */ public NMSString0x10 InitialTrait;
    }
}
