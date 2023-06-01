using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD02CADCEED644E8, NameHash = 0xDAB0554EA36957B5)]
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
        /* 0x0C0 */ public TkModelRendererData RendererAlt;
        /* 0x170 */ public GcAlienRace Race;
        /* 0x174 */ public float AttractDistanceSq;
        /* 0x178 */ public bool SecondaryMeshAlwaysVisible;
        /* 0x179 */ public bool RepeatInteraction;
        /* 0x17A */ public bool UseInteractCamera;
        /* 0x17C */ public float BlendToCameraTime;
        /* 0x180 */ public float BlendFromCameraTime;
        /* 0x188 */ public GcInteractionActivationCost ActivationCost;
        /* 0x1F0 */ public NMSString0x10 TriggerAction;
        /* 0x200 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x210 */ public bool BroadcastTriggerAction;
        /* 0x214 */ public float InteractAngle;
        /* 0x218 */ public float InteractDistance;
        /* 0x21C */ public bool InteractInvertFace;
        /* 0x220 */ public GcInteractionType SecondaryInteractionType;
        /* 0x228 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x290 */ public List<TkModelRendererData> EventRenderers;
        /* 0x2A0 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x2B0 */ public float SecondaryCameraTransitionTime;
        /* 0x2B4 */ public GcInteractionDof DepthOfField;
        /* 0x2C8 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x2D8 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : uint {
            No,
            Interior,
            Exterior,
        }
        /* 0x318 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        /* 0x31C */ public bool ReseedAfterRewardSuccess;
        /* 0x31D */ public bool UsePersonalPersistentBuffer;
        /* 0x320 */ public float InWorldUIScaler;
        /* 0x324 */ public float InWorldUIMinDistOverride;
        /* 0x328 */ public float InWorldUIMinDistOverrideV2;
        /* 0x32C */ public float InWorldUIForcedOffset;
        /* 0x330 */ public float InWorldUIForcedOffsetV2;
        /* 0x334 */ public bool InWorldUIUseCameraUp;
        /* 0x338 */ public NMSString0x10 StartMissionOnUse;
        /* 0x348 */ public bool AllowMissionUnderwater;
        /* 0x349 */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
