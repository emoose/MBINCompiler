namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFFF639482153F5D, NameHash = 0x6B6B42D850BF9519)]
    public class GcFrigateTraitStrength : NMSTemplate
    {
        // size: 0xA
        public enum FrigateTraitStrengthEnum {
            NegativeLarge,
            NegativeMedium,
            NegativeSmall,
            TertiarySmall,
            TertiaryMedium,
            TertiaryLarge,
            SecondarySmall,
            SecondaryMedium,
            SecondaryLarge,
            Primary
        }
        /* 0x0 */ public FrigateTraitStrengthEnum FrigateTraitStrength;
    }
}
