namespace libMBIN.Models.Structs
{
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
        public int InventoryTest;
        public string[] InventoryTestValues()
        {
            return new[] { "Current", "personal", "Ship", "Vehicle" };
        }
        public int SlotsFree;
        public TkEqualityEnum Test;
    }
}
