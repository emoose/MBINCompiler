using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF523A25A489C40BB, NameHash = 0xAD23D3A0)]
    public class GcSettlementStatValueRange : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int MaxValue;
        [NMS(Index = 1)]
        /* 0x4 */ public int MinValue;
        [NMS(Index = 0)]
        /* 0x8 */ public GcSettlementStatType Type;
    }
}
