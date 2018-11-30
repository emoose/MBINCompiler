using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1E0, GUID = 0x6D20427FAFEA9820, Alignment = 0x10)]
    public class GcInteractionComponentData : NMSTemplate
    {
		public enum InteractionActionEnum { PressButton, HoldButton, Shoot }
		/* 0x000 */ public InteractionActionEnum InteractionAction;

        /* 0x004 */ public GcInteractionType InteractionType;
        [NMS(Size = 8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x0C0 */ public GcAlienRace Race;
        /* 0x0C4 */ public float AttractDistanceSq;
        /* 0x0C8 */ public bool RepeatInteraction;
        /* 0x0C9 */ public bool UseInteractCamera;
        /* 0x0CC */ public float BlendToCameraTime;
        /* 0x0D0 */ public float BlendFromCameraTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;
        /* 0x0D8 */ public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x10)]
        /* 0x110 */ public string TriggerAction;

        /* 0x120 */ public bool BroadcastTriggerAction;
        /* 0x124 */ public float InteractAngle;
        /* 0x128 */ public float InteractDistance;
        /* 0x12C */ public bool InteractInvertFace;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x12D */ public byte[] Padding12D;
        /* 0x130 */ public GcInteractionType SecondaryInteractionType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x134 */ public byte[] Padding134;
        /* 0x138 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x170 */ public List<TkModelRendererData> EventRenderers;

        /* 0x180 */ public float SecondaryCameraTransitionTime;
        /* 0x184 */ public GcInteractionDof DepthOfField;

        /* 0x198 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x1A8 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        /* 0x1D8 */ public bool ReseedAfterRewardSuccess;
        /* 0x1D9 */ public bool UsePersonalPersistentBuffer;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x1DA */ public byte[] EndPadding;
    }
}
