using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xB5C2DB523A6C55DD, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        public GcInputActions Action;
        public TkInputEnum Button;
        public TkInputAxisEnum Axis;
    }
}
