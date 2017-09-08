using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceComponentData : NMSTemplate       // size: 0xF0
    {
        /* 0x000 */ public List<GcMaintenanceElement> PreInstalledTech;     // elements are 0x38
        /* 0x010 */ public int VisibleMaintenanceSlots;
        /* 0x014 */ public bool AllowRepair;
        /* 0x015 */ public bool AllowCharge;
        /* 0x016 */ public bool AllowDismantle;
        /* 0x017 */ public bool AllowInstallTech;
        /* 0x018 */ public bool AllowCraftProduct;
        /* 0x019 */ public bool AllowTransfer;
        /* 0x01A */ public bool AllowMoveAndStack;
        /* 0x01B */ public bool AutoCompleteOnStart;

        /* 0x01C */ public int Interactable;
        public string[] InteractableValues()
        {
            return new[] { "OnlyWhenComplete", "OnlyWhenNotComplete", "Always", "Never" };
        }

        /* 0x020 */ public float CompletedTransitionDelay;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;

        /* 0x030 */ public TkModelRendererData ModelRendererData;

        /* 0x0A0 */ public int ModelRendererResource;
        public string[] ModelRendererResourceValues()
        {
            return new[] { "ModelNode", "MasterModelNode"};
        }

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0A4 */ public byte[] PaddingA4;

        [NMS(Size = 0x20)]
        /* 0x0A8 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x0C8 */ public string Description;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x0E8 */ public byte[] EndPadding;
    }
}
