using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABFDDC5DEA71CFB4, NameHash = 0xDAB0554EA36957B5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        // size: 0x3
        public enum InteractionActionEnum {
            PressButton,
            HoldButton,
            Shoot
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
        /* 0x1D0 */ public NMSString0x10 TriggerAction;
        /* 0x1E0 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x1F0 */ public bool BroadcastTriggerAction;
        /* 0x1F4 */ public float InteractAngle;
        /* 0x1F8 */ public float InteractDistance;
        /* 0x1FC */ public bool InteractInvertFace;
        /* 0x200 */ public GcInteractionType SecondaryInteractionType;
        /* 0x208 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x250 */ public List<TkModelRendererData> EventRenderers;
        /* 0x260 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x270 */ public float SecondaryCameraTransitionTime;
        /* 0x274 */ public GcInteractionDof DepthOfField;
        /* 0x288 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x298 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum {
            No,
            Interior,
            Exterior
        }
        /* 0x2D8 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        /* 0x2DC */ public bool ReseedAfterRewardSuccess;
        /* 0x2DD */ public bool UsePersonalPersistentBuffer;
        /* 0x2E0 */ public float InWorldUIScaler;
        /* 0x2E8 */ public NMSString0x10 StartMissionOnUse;
        /* 0x2F8 */ public bool AllowMissionUnderwater;
    }
}
