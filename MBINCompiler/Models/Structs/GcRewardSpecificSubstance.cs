namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
		public float HardModeMultiplier;
    }
}
