namespace libMBIN.Models.Structs
{
    public class GcInventorySpecialSlotType : NMSTemplate
    {
        public int InventorySpecialSlotType;
        public string[] InventorySpecialSlotTypeValues()
        {
            return new[] { "Broken", "TechOnly", "Cargo"};
        }
    }
}
