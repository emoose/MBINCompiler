using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB881B5621F4BE2DB, NameHash = 0xA61BE62F)]
    public class GcPetBattlerCoreStatRollData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public int[] Roll;
    }
}
