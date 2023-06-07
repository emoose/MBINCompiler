using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD28DF6CB38B451D0, NameHash = 0x479CFCB871ABBE0)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        /* 0x000 */ public List<GcMaintenanceElement> PreInstalledTech;
        /* 0x010 */ public int VisibleMaintenanceSlots;
        /* 0x014 */ public bool AllowRepair;
        /* 0x015 */ public bool AllowCharge;
        /* 0x016 */ public bool AllowDismantle;
        /* 0x017 */ public bool AllowDiscard;
        /* 0x018 */ public bool AllowInstallTech;
        /* 0x019 */ public bool AllowCraftProduct;
        /* 0x01A */ public bool AllowTransfer;
        /* 0x01B */ public bool AllowMoveAndStack;
        /* 0x01C */ public bool AllowTransferIn;
        /* 0x01D */ public bool AutoCompleteOnStart;
        /* 0x01E */ public bool UseModelResourceRenderer;
        /* 0x01F */ public bool UseBoundsForIconCentre;
        /* 0x020 */ public bool ForceRemoveUIRenderLayer;
        /* 0x021 */ public bool HideMaxAmountOnProductSlots;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        /* 0x024 */ public InteractableEnum Interactable;
        /* 0x028 */ public bool ForceNoninteraction;
        /* 0x02C */ public float CompletedTransitionDelay;
        /* 0x030 */ public bool ShareInteractionModelRender;
        /* 0x031 */ public bool UseInteractionStyleCameraEvent;
        /* 0x040 */ public TkModelRendererData ModelRenderData;
        /* 0x0F0 */ public TkModelRendererData ModelRenderDataAlt;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        /* 0x1A0 */ public ModelRendererResourceEnum ModelRendererResource;
        /* 0x1A4 */ public GcBroadcastLevel BroadcastLevel;
        /* 0x1A8 */ public NMSString0x20A Title;
        /* 0x1C8 */ public NMSString0x20A Description;
        /* 0x1E8 */ public NMSString0x20A ActionButtonOverride;
        /* 0x208 */ public NMSString0x20A ActionDescriptionOverride;
        /* 0x228 */ public NMSString0x20A TransferButtonOverride;
        /* 0x248 */ public NMSString0x20A TransferDescriptionOverride;
        /* 0x268 */ public NMSString0x20A DiscardButtonOverride;
        /* 0x288 */ public NMSString0x20A DiscardDescriptionOverride;
        /* 0x2A8 */ public NMSString0x20A ChargeButtonOverride;
        /* 0x2C8 */ public NMSString0x20A ChargeDescriptionOverride;
        /* 0x2E8 */ public NMSString0x20A ActionWarningOverride;
        /* 0x308 */ public bool SilenceSuitVOIAlerts;
        /* 0x30C */ public float InWorldUIScaler;
        /* 0x310 */ public float InWorldUIMinDistOverride;
        /* 0x314 */ public float InWorldUIMinDistOverrideV2;
        /* 0x318 */ public float InWorldUIForcedOffset;
        /* 0x31C */ public float InWorldUIForcedOffsetV2;
        /* 0x320 */ public bool InWorldUIUseCameraUp;
        /* 0x321 */ public bool InteractionRequiresPower;
        /* 0x328 */ public NMSString0x10 StartMissionOnUse;
        /* 0x338 */ public NMSString0x10 GiveRewardOnCompletion;
        /* 0x348 */ public bool OpenInteractionOnQuit;
        /* 0x349 */ public bool ForceOneClickRepair;
        /* 0x34C */ public GcAudioWwiseEvents AudioIDOnSuccess;
        /* 0x350 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        /* 0x3E0 */ public bool DisableSynchronise;
    }
}
