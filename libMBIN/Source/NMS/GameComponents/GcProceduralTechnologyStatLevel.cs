using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0xB7215C9D4BD1BDC9, Broken = true)]
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
