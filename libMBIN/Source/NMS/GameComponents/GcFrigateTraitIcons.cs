namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69FFF37CCA5995E5, NameHash = 0xE4A4F7A4BE98467D)]
    public class GcFrigateTraitIcons : NMSTemplate
    {
        // size: 0xB
        public enum IconsEnum {
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
        [NMS(Size = 0xB, EnumType = typeof(IconsEnum))]
        /* 0x0 */ public NMSString0x80[] Icons;
    }
}
