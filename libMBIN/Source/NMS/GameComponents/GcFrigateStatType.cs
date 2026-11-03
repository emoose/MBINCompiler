namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6D52B76B238245E, NameHash = 0x73B19E8A)]
    public class GcFrigateStatType : NMSTemplate
    {
        // size: 0xB
        public enum FrigateStatTypeEnum : uint {
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
            Stealth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateStatTypeEnum FrigateStatType;
    }
}
