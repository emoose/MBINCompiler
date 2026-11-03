namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD42A252A60BD950, NameHash = 0x993C133D)]
    public class GcSettlementStatStrength : NMSTemplate
    {
        // size: 0x7
        public enum SettlementStatStrengthEnum : uint {
            PositiveWide,
            PositiveLarge,
            PositiveMedium,
            PositiveSmall,
            NegativeSmall,
            NegativeMedium,
            NegativeLarge,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementStatStrengthEnum SettlementStatStrength;
    }
}
