using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x399D6157457D1765, NameHash = 0x39F4E912A931EB8F)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        /* 0x000 */ public bool IsEnabled;
        /* 0x008 */ public NMSString0x20A TitleLocId;
        /* 0x028 */ public NMSString0x20A SubtitleLocId;
        /* 0x048 */ public NMSString0x20A SubtitleApplyingLocId;
        /* 0x068 */ public NMSString0x20A SubtitleSlotsFullLocId;
        /* 0x088 */ public NMSString0x20A SubtitleSlotsBlockedLocId;
        /* 0x0A8 */ public GcExactResource BaseResource;
        /* 0x140 */ public TkModelRendererData ModelRenderData;
        /* 0x200 */ public TkModelRendererData InteractionCameraData;
        /* 0x2C0 */ public GcCustomisationCameraData CameraData;
        /* 0x2F4 */ public float HologramOffset;
        /* 0x2F8 */ public List<GcModularCustomisationSlotConfig> Slots;
        /* 0x308 */ public List<GcModularCustomisationColourGroup> ColourData;
        /* 0x318 */ public List<GcModularCustomisationTextureGroup> TextureData;
    }
}
