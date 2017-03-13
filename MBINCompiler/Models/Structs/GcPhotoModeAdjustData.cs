using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPhotoModeAdjustData : NMSTemplate
    {
        public float AdjustMin;
        public TkCurveType AdjustMinCurve;
        public float AdjustMax;
        public float AdjustMaxRange;
        public TkCurveType AdjustMaxCurve;
        public bool Inverted;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;       // just a guess...
    }
}
