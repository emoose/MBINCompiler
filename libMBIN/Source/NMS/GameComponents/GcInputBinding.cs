using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5FD2B94943C50EA, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        /* 0x00 */ public GcInputActions Action;
        /* 0x04 */ public TkInputEnum Button;
        /* 0x08 */ public TkInputAxisEnum Axis;
        /* 0x10 */ public TkVirtualBinding VirtualBinding;
    }
}
