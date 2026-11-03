using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66CD8564EA9B4E57, NameHash = 0x52C43072)]
    public class GcMissionConditionWordCategoryKnown : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcWordCategoryTableEnum Category;
        [NMS(Index = 1)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
