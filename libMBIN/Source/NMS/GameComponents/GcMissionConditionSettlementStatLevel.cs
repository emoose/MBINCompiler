using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3EF0242C0A4AD31, NameHash = 0x1DD776B0B61E916)]
    public class GcMissionConditionSettlementStatLevel : NMSTemplate
    {
        /* 0x0 */ public float NormalisedLevel;
        /* 0x4 */ public GcSettlementStatType Stat;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
