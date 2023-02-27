using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC048D8A45E3409, NameHash = 0xFE5851C36CE8242F)]
    public class GcRewardTeachWord : NMSTemplate
    {
        /* 0x00 */ public GcAlienRace Race;
        /* 0x04 */ public bool UseCategory;
        /* 0x08 */ public GcWordCategoryTableEnum Category;
        /* 0x0C */ public int AmountMin;
        /* 0x10 */ public int AmountMax;
    }
}
