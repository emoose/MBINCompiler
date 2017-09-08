namespace libMBIN.Models.Structs
{
    [NMS(Alignment =0x8)]
    public class GcRewardSpecificSubstance : NMSTemplate        // size: 0x28
    {
        public GcDefaultMissionProduct Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
		public float HardModeMultiplier;
        public bool DisableMultiplier;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
