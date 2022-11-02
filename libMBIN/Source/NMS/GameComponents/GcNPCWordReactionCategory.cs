using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15C948E9EEAE1A30, NameHash = 0x68CB2B62199F1EFA)]
    public class GcNPCWordReactionCategory : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcWordCategoryTableEnum.wordcategorytableEnumEnum))]
        /* 0x00 */ public GcNPCWordReactionList[] Categories;
        /* 0x70 */ public GcNPCWordReactionList Fallback;
    }
}
