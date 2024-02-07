using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x35972C85C1BDA232, NameHash = 0x5FE8CF76972566C2)]
    public class GcEffectsGlobals : NMSTemplate
    {
        /* 0x00 */ public float ClickToPlayScale;
        /* 0x04 */ public float ClickToPlayCameraOffset;
        /* 0x10 */ public TkModelRendererData ResourceRendererData;
    }
}
