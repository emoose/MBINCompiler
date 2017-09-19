namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18, Alignment = 0x8)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
