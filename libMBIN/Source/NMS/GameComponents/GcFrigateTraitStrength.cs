using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x32C9FE7B499C2301)]
    public class GcFrigateTraitStrength : NMSTemplate
    {
		public enum FrigateTraitStrengthEnum { NegativeLarge, NegativeMedium, NegativeSmall, TertiarySmall, TertiaryMedium, TertiaryLarge, SecondarySmall, SecondaryMedium, SecondaryLarge, Primary }
		public FrigateTraitStrengthEnum FrigateTraitStrength;
    }
}
