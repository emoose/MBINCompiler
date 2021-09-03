using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x6A2DA02262345DA, NameHash = 0xA93B3968B18A5750)]
    public class GcSettlementJudgementPerkOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Perk;
        /* 0x10 */ public float PerkChance;
    }
}
