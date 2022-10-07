using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C932E4E8ECD9EE0, NameHash = 0xF12C873B2656248)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        // size: 0xB
        public enum FrigateStatTypeEnum {
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
        [NMS(Size = 0xB, EnumType = typeof(FrigateStatTypeEnum))]
        /* 0x0 */ public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
