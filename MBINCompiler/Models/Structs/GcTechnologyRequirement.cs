namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
