namespace libMBIN.Models.Structs
{
    public class GcPlayerMissionProgressMapEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        public int MinProgress;
        public int MaxProgress;
        public int NewProgress;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
