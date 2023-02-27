using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B6550330B94F440, NameHash = 0xB9FD998A06AA6DE0)]
    public class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
    {
        /* 0x00 */ public int SubstanceStackLimit;
        /* 0x04 */ public int ProductStackLimit;
        [NMS(Size = 0xC, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x08 */ public int[] MaxSubstanceStackSizes;
        [NMS(Size = 0xC, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x38 */ public int[] MaxProductStackSizes;
    }
}
