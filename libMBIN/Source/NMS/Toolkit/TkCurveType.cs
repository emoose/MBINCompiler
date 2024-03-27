namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA0AA35E82CAB5940, NameHash = 0x48849654049904EA)]
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
        /* 0x0 */ public CurveEnum Curve;
    }
}
