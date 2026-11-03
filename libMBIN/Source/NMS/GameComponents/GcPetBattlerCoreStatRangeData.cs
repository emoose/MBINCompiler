using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2176279C1B41761D, NameHash = 0x37733D08)]
    public class GcPetBattlerCoreStatRangeData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public Vector2f[] Range;
    }
}
