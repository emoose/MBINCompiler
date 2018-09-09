namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0x25CDC540F8CBEBCF)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
