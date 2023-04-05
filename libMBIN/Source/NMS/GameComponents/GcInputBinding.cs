using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72E8442E84AA8CE6, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        /* 0x0 */ public GcInputActions Action;
        /* 0x4 */ public TkInputEnum Button;
        /* 0x8 */ public TkInputAxisEnum Axis;
    }
}
