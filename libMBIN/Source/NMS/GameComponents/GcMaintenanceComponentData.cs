using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x508485AA3B7F83E0, NameHash = 0x479CFCB871ABBE0)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        /* 0x000 */ public List<GcMaintenanceElement> PreInstalledTech;
        /* 0x010 */ public int VisibleMaintenanceSlots;
        /* 0x014 */ public bool AllowRepair;
        /* 0x015 */ public bool AllowCharge;
        /* 0x016 */ public bool AllowDismantle;
        /* 0x017 */ public bool AllowInstallTech;
        /* 0x018 */ public bool AllowCraftProduct;
        /* 0x019 */ public bool AllowTransfer;
        /* 0x01A */ public bool AllowMoveAndStack;
        /* 0x01B */ public bool AllowTransferIn;
        /* 0x01C */ public bool AutoCompleteOnStart;
        /* 0x01D */ public bool UseModelResourceRenderer;
        /* 0x01E */ public bool UseBoundsForIconCentre;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        /* 0x020 */ public InteractableEnum Interactable;
        /* 0x024 */ public bool ForceNoninteraction;
        /* 0x028 */ public float CompletedTransitionDelay;
        /* 0x02C */ public bool ShareInteractionModelRender;
        /* 0x030 */ public TkModelRendererData ModelRenderData;
        /* 0x0E0 */ public TkModelRendererData ModelRenderDataAlt;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        /* 0x190 */ public ModelRendererResourceEnum ModelRendererResource;
        /* 0x194 */ public GcBroadcastLevel BroadcastLevel;
        /* 0x198 */ public NMSString0x20A Title;
        /* 0x1B8 */ public NMSString0x20A Description;
        /* 0x1D8 */ public NMSString0x20A ActionButtonOverride;
        /* 0x1F8 */ public NMSString0x20A ActionDescriptionOverride;
        /* 0x218 */ public NMSString0x20A TransferButtonOverride;
        /* 0x238 */ public NMSString0x20A TransferDescriptionOverride;
        /* 0x258 */ public NMSString0x20A DiscardButtonOverride;
        /* 0x278 */ public NMSString0x20A DiscardDescriptionOverride;
        /* 0x298 */ public NMSString0x20A ActionWarningOverride;
        /* 0x2B8 */ public float InWorldUIScaler;
        /* 0x2BC */ public float InWorldUIMinDistOverride;
        /* 0x2C0 */ public float InWorldUIMinDistOverrideV2;
        /* 0x2C4 */ public float InWorldUIForcedOffset;
        /* 0x2C8 */ public float InWorldUIForcedOffsetV2;
        /* 0x2CC */ public bool InWorldUIUseCameraUp;
        /* 0x2CD */ public bool InteractionRequiresPower;
        /* 0x2D0 */ public NMSString0x10 StartMissionOnUse;
    }
}
