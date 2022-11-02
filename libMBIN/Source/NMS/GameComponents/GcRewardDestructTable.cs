using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4B553E78A1DFEB8, NameHash = 0x5ED90B1D007B2123)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0 */ public GcRewardDestructRarities[] Categories;
    }
}
