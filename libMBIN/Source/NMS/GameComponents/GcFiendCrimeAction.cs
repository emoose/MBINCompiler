using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x186F29453A9CCF5)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        public GcFiendCrime FiendCrimeType;
        public float FiendCrimeModifier;
    }
}
