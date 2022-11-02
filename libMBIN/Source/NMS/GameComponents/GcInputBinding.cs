using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1256B06BA976968, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        /* 0x0 */ public GcInputActions Action;
        /* 0x4 */ public TkInputEnum Button;
        /* 0x8 */ public TkInputAxisEnum Axis;
    }
}
