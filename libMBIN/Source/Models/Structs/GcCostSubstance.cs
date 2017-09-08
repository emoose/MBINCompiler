namespace MBINCompiler.Models.Structs
{
    public class GcCostSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default; // maybe?
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
