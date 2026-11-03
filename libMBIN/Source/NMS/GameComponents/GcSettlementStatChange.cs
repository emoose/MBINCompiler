using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9A60BF2B57B9443, NameHash = 0xDB7A6AA2)]
    public class GcSettlementStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatType Stat;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSettlementStatStrength Strength;
        [NMS(Index = 2)]
        /* 0x8 */ public bool DirectlyChangePopulation;
    }
}
