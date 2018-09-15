using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC3B3509D53536EAB)]
    public class GcWeightingCurve : NMSTemplate
    {

		public enum WeightingCurveEnum { NoWeighting, MaxIsUncommon, MaxIsRare, MaxIsSuperRare, MinIsUncommon, MinIsRare, MinIsSuperRare }
		public WeightingCurveEnum WeightingCurve;
    }
}
