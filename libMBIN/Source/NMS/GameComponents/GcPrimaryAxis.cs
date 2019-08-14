using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1003ACDA0DB7C653)]
    public class GcPrimaryAxis : NMSTemplate
    {
		public enum PrimaryAxisEnum { Z, ZNeg, X, Xneg, Y, YNeg }
		public PrimaryAxisEnum PrimaryAxis;
    }
}
