using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x463F7A72CDB2EBD2, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x121, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
