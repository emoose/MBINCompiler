using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBF28F88CAC268BE, NameHash = 0xDAB0554EA36957B5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        // size: 0x3
        public enum InteractionActionEnum : uint {
            PressButton,
            HoldButton,
            Shoot,
        }
        /* 0x000 */ public InteractionActionEnum InteractionAction;
        /* 0x004 */ public GcInteractionType InteractionType;
        /* 0x008 */ public bool UseIntermediateUI;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x0D0 */ public TkModelRendererData RendererAlt;
        /* 0x190 */ public GcAlienRace Race;
        /* 0x194 */ public float AttractDistanceSq;
        /* 0x198 */ public bool SecondaryMeshAlwaysVisible;
        /* 0x199 */ public bool RepeatInteraction;
        /* 0x19A */ public bool UseInteractCamera;
        /* 0x19C */ public float BlendToCameraTime;
        /* 0x1A0 */ public float BlendFromCameraTime;
        /* 0x1A8 */ public GcInteractionActivationCost ActivationCost;
        /* 0x210 */ public NMSString0x10 TriggerAction;
        /* 0x220 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x230 */ public bool BroadcastTriggerAction;
        /* 0x234 */ public float InteractAngle;
        /* 0x238 */ public float InteractDistance;
        /* 0x23C */ public bool InteractInvertFace;
        /* 0x240 */ public GcInteractionType SecondaryInteractionType;
        /* 0x248 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x2B0 */ public List<TkModelRendererData> EventRenderers;
        /* 0x2C0 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x2D0 */ public List<GcInteractionDof> EventRenderersDoF;
        /* 0x2E0 */ public float SecondaryCameraTransitionTime;
        /* 0x2E4 */ public GcInteractionDof DepthOfField;
        /* 0x2F8 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x308 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : uint {
            No,
            Interior,
            Exterior,
        }
        /* 0x348 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        /* 0x34C */ public bool ReseedAfterRewardSuccess;
        /* 0x34D */ public bool UsePersonalPersistentBuffer;
        /* 0x350 */ public float InWorldUIScaler;
        /* 0x354 */ public float InWorldUIMinDistOverride;
        /* 0x358 */ public float InWorldUIMinDistOverrideV2;
        /* 0x35C */ public float InWorldUIForcedOffset;
        /* 0x360 */ public float InWorldUIForcedOffsetV2;
        /* 0x364 */ public bool InWorldUIUseCameraUp;
        /* 0x368 */ public NMSString0x10 StartMissionOnUse;
        /* 0x378 */ public bool AllowMissionUnderwater;
        /* 0x379 */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
