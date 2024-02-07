using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89FEAF8B4EB3F765, NameHash = 0x39F4E912A931EB8F)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A TitleLocId;
        /* 0x020 */ public GcExactResource BaseResource;
        /* 0x0B0 */ public TkModelRendererData ModelRenderData;
        /* 0x170 */ public TkModelRendererData InteractionCameraData;
        /* 0x230 */ public List<GcModularCustomisationSlotConfig> Slots;
    }
}
