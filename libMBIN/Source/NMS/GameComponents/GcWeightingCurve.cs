namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0C3B3509D53536EAB)]
    public class GcWeightingCurve : NMSTemplate
    {

		public enum WeightingCurveEnum { NoWeighting, MaxIsUncommon, MaxIsRare, MaxIsSuperRare, MinIsUncommon, MinIsRare, MinIsSuperRare }
		public WeightingCurveEnum WeightingCurve;
    }
}
