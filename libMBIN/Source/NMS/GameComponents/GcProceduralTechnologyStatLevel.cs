using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0xD559DE06D8CA8C8A, NameHash = 0xF41CD566C844982A)]
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
