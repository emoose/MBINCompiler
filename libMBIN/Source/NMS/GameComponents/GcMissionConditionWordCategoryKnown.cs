using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F14C30C8994E845, NameHash = 0xC1BA5468EA0625B9)]
    public class GcMissionConditionWordCategoryKnown : NMSTemplate
    {
        /* 0x0 */ public GcWordCategoryTableEnum Category;
        /* 0x4 */ public GcAlienRace Race;
    }
}
