using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7296F750E0DEB3E1, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        /* 0x0 */ public GcActionUseType Status;
        /* 0x4 */ public GcInputActions Action;
    }
}
