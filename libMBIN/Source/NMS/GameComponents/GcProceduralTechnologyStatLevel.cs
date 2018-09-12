namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x14, GUID = 0x0D99FB49A81830E3)]
    public class GcProceduralTechnologyStatLevel : NMSTemplate
    {
        public GcStatsTypes Stat;
        public float ValueMin;
        public float ValueMax;
        public GcWeightingCurve WeightingCurve;
        public bool AlwaysChoose;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
