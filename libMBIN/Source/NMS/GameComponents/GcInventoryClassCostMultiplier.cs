using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE1051161F584B52, NameHash = 0x1FA80ABD4B6B665)]
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public float[] Multiplier;
    }
}
