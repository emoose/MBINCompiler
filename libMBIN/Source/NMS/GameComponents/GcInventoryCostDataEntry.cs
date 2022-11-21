using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x888CCA32A010F1E7, NameHash = 0xD9472E9B798FC3B5)]
    public class GcInventoryCostDataEntry : NMSTemplate
    {
        /* 0x00 */ public int MinSlots;
        /* 0x04 */ public float MinValueInMillions;
        /* 0x08 */ public int MaxSlots;
        /* 0x0C */ public float MaxValueInMillions;
        /* 0x10 */ public float CoolMultiplier;
        /* 0x14 */ public float TradeInMultiplier;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x18 */ public float[] ClassMultiplier;
    }
}
