using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27EC480E87BC3618, NameHash = 0xDEB32057FC4A2AC1)]
    public class GcSettlementPerkUsefulData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseID;
        /* 0x10 */ public ulong SeedValue;
        /* 0x18 */ public float ChangeStrength;
        /* 0x1C */ public GcSettlementStatType Stat;
        /* 0x20 */ public bool IsNegative;
        /* 0x21 */ public bool IsProc;
    }
}
