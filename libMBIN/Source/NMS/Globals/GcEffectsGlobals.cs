using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x2F0D470E47B05A37, NameHash = 0x5FE8CF76972566C2)]
    public class GcEffectsGlobals : NMSTemplate
    {
        /* 0x00 */ public float ClickToPlayScale;
        /* 0x04 */ public float ClickToPlayCameraOffset;
        /* 0x10 */ public TkModelRendererData ResourceRendererData;
    }
}
