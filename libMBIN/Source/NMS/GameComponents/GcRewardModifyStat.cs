namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x97C0EB4710F2C5C5)]
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        public int Amount;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
