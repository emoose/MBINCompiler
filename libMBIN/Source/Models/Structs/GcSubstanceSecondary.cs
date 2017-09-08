namespace libMBIN.Models.Structs
{
    public class GcSubstanceSecondary : NMSTemplate     // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Chance;
        public float AmountMin;
        public float AmountMax;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
