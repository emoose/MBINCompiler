using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24A93C42678E35F7, NameHash = 0x3548FD5B88130DA1)]
    public class GcSettlementStatStrengthData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatStrength.SettlementStatStrengthEnum))]
        /* 0x0 */ public GcSettlementStatStrengthRanges[] PerkStatStrengthValues;
    }
}
