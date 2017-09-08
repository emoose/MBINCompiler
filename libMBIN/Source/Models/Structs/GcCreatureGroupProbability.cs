namespace libMBIN.Models.Structs
{
    public class GcCreatureGroupProbability : NMSTemplate       // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string Group;
        public float Probability;         // 3F800000h
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
