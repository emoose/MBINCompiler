using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57C302EFC4A39A9A, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        /* 0x0 */ public GcActionUseType Status;
        /* 0x4 */ public GcInputActions Action;
    }
}
