using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8DA9004CF5DFDDC, NameHash = 0x6F7F3335)]
    public class GcSettlementStatStrengthData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcSettlementStatStrength.SettlementStatStrengthEnum))]
        /* 0x0 */ public GcSettlementStatStrengthRanges[] PerkStatStrengthValues;
    }
}
