namespace libMBIN.Models.Structs
{
    public class GcPlayerStat : NMSTemplate // 0x20 bytes
    {
        [NMS(Size = 0x10)]
        public string Id;

        public GcStatValueData Value;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
