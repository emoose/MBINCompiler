using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E53BEC21A5D6E38, NameHash = 0x3548FD5B88130DA1)]
    public class GcSettlementStatStrengthData : NMSTemplate
    {
        // size: 0x7
        public enum PerkStatStrengthValuesEnum {
            PositiveWide,
            PositiveLarge,
            PositiveMedium,
            PositiveSmall,
            NegativeSmall,
            NegativeMedium,
            NegativeLarge
        }
        [NMS(Size = 0x7, EnumType = typeof(PerkStatStrengthValuesEnum))]
        /* 0x0 */ public GcSettlementStatStrengthRanges[] PerkStatStrengthValues;
    }
}
