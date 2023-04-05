using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x814FF7E6BB9D94E5, NameHash = 0x7DA0241C104EEDF)]
    public class GcRewardDamageTech : NMSTemplate
    {
        /* 0x00 */ public GcTechnologyCategory Category;
        /* 0x08 */ public NMSString0x10 TechToDamage_optional;
        /* 0x18 */ public bool ShowDamageMessage;
    }
}
