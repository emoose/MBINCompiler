using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5F87D79D6A96A8A, NameHash = 0xC1BA5468EA0625B9)]
    public class GcMissionConditionWordCategoryKnown : NMSTemplate
    {
        /* 0x0 */ public GcWordCategoryTableEnum Category;
        /* 0x4 */ public GcAlienRace Race;
    }
}
