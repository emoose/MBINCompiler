using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3AEEE086DF2B311C, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x123, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
