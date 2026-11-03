using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43FFC91884BA4720, NameHash = 0xF4BE36A8)]
    public class GcNPCWordReactionCategory : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcWordCategoryTableEnum.wordcategorytableEnumEnum))]
        /* 0x00 */ public GcNPCWordReactionList[] Categories;
        [NMS(Index = 1)]
        /* 0x70 */ public GcNPCWordReactionList Fallback;
    }
}
