namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB7B9956D87F7562, NameHash = 0x5B21B72DF30D668C)]
    public class GcFrigateStatType : NMSTemplate
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
            Stealth,
        }
        /* 0x0 */ public FrigateStatTypeEnum FrigateStatType;
    }
}
