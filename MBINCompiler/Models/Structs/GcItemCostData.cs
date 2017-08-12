namespace MBINCompiler.Models.Structs
{
    public class GcItemCostData : NMSTemplate        // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Cost;
        public float MinCost;
        public float MaxCost;
        public float ChangePerSale;
    }
}
