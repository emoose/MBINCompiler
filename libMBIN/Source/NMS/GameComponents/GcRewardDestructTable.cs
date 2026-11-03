using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54BDDD66FF94878A, NameHash = 0xA65E9C64)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0 */ public GcRewardDestructRarities[] Categories;
    }
}
