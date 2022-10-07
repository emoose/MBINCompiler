using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49E57CE5EED9EBCC, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        /* 0x0 */ public GcActionUseType Status;
        /* 0x4 */ public GcInputActions Action;
    }
}
