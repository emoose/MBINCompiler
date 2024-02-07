using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FE5960472FA8854, NameHash = 0xB9FD998A06AA6DE0)]
    public class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
    {
        /* 0x00 */ public int SubstanceStackLimit;
        /* 0x04 */ public int ProductStackLimit;
        [NMS(Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x08 */ public int[] MaxSubstanceStackSizes;
        [NMS(Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x3C */ public int[] MaxProductStackSizes;
    }
}
