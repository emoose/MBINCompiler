namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47AABCD48527D767, NameHash = 0xA9800C505F52A54E)]
    public class GcInventorySpecialSlotType : NMSTemplate
    {
        // size: 0x4
        public enum InventorySpecialSlotTypeEnum {
            Broken,
            TechOnly,
            Cargo,
            BlockedByBrokenTech
        }
        /* 0x0 */ public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}
