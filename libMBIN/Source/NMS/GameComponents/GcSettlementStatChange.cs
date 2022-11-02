using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16C7011BE7BBEC5F, NameHash = 0xD0ED6D53DE05ABE7)]
    public class GcSettlementStatChange : NMSTemplate
    {
        /* 0x0 */ public GcSettlementStatType Stat;
        /* 0x4 */ public GcSettlementStatStrength Strength;
    }
}
