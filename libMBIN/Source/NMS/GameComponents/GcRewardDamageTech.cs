using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EA2A14416C866B8, NameHash = 0xCDFC45FB)]
    public class GcRewardDamageTech : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 TechToDamage_optional;
        [NMS(Index = 0)]
        /* 0x10 */ public GcTechnologyCategory Category;
        [NMS(Index = 2)]
        /* 0x14 */ public bool ShowDamageMessage;
    }
}
