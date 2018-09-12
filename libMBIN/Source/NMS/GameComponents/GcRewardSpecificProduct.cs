namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, GUID = 0x901BBD280C22EEE4)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
    }
}
