using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6E845CFA1D694B9, NameHash = 0x39F4E912A931EB8F)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A TitleLocId;
        /* 0x020 */ public GcExactResource BaseResource;
        /* 0x0B0 */ public TkModelRendererData ModelRenderData;
        /* 0x160 */ public TkModelRendererData InteractionCameraData;
        /* 0x210 */ public List<GcModularCustomisationSlotConfig> Slots;
    }
}
