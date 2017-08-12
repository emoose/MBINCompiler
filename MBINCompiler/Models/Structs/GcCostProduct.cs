namespace MBINCompiler.Models.Structs
{
    public class GcCostProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
