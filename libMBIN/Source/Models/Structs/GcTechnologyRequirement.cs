namespace MBINCompiler.Models.Structs
{
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
