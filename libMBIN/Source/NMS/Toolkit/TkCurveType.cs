namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8A54DC72AD04103F, NameHash = 0x25A8DEF1)]
    public class TkCurveType : NMSTemplate
    {
        // size: 0x28
        public enum CurveEnum : byte {
            Linear,
            SmoothInOut,
            FastInSlowOut,
            BellSquared,
            Squared,
            Cubed,
            Logarithmic,
            SlowIn,
            SlowOut,
            ReallySlowOut,
            SmootherStep,
            SmoothFastInSlowOut,
            SmoothSlowInFastOut,
            EaseInSine,
            EaseOutSine,
            EaseInOutSine,
            EaseInQuad,
            EaseOutQuad,
            EaseInOutQuad,
            EaseInQuart,
            EaseOutQuart,
            EaseInOutQuart,
            EaseInQuint,
            EaseOutQuint,
            EaseInOutQuint,
            EaseInExpo,
            EaseOutExpo,
            EaseInOutExpo,
            EaseInCirc,
            EaseOutCirc,
            EaseInOutCirc,
            EaseInBack,
            EaseOutBack,
            EaseInOutBack,
            EaseInElastic,
            EaseOutElastic,
            EaseInOutElastic,
            EaseInBounce,
            EaseOutBounce,
            EaseInOutBounce,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CurveEnum Curve;
    }
}
