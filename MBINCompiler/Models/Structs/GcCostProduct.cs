namespace MBINCompiler.Models.Structs
{
    public class GcCostProduct : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
