namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1A6FF072DB629119)]
    public class TkCurveType : NMSTemplate
    {

		public enum CurveEnum { Linear, SmoothInOut, FastInSlowOut, BellSquared, Squared, Cubed, Logarithmic, SlowIn, SlowOut, ReallySlowOut, SmootherStep, SmoothFastInSlowOut, SmoothSlowInFastOut, EaseInSine, EaseOutSine, EaseInOutSine, EaseInQuad, EaseOutQuad, EaseInOutQuad, EaseInQuart, EaseOutQuart, EaseInOutQuart, EaseInQuint, EaseOutQuint, EaseInOutQuint, EaseInExpo, EaseOutExpo, EaseInOutExpo, EaseInCirc, EaseOutCirc, EaseInOutCirc, EaseInBack, EaseOutBack, EaseInOutBack, EaseInElastic, EaseOutElastic, EaseInOutElastic, EaseInBounce, EaseOutBounce, EaseInOutBounce }
		public CurveEnum Curve;
    }
}
