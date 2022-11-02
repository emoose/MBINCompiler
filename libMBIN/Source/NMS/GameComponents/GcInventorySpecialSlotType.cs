namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB50200AB5E7E0C, NameHash = 0xA9800C505F52A54E)]
    public class GcInventorySpecialSlotType : NMSTemplate
    {
        // size: 0x5
        public enum InventorySpecialSlotTypeEnum {
            Broken,
            TechOnly,
            Cargo,
            BlockedByBrokenTech,
            TechBonus
        }
        /* 0x0 */ public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}
