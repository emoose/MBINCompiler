using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xE44F8EA503FCA519 )]
    public class GcGalaxyGlobals : NMSTemplate
    {
        /* 0x0000 */ public float PathUIWidth;
        /* 0x0004 */ public float StarPathUIWidth;
        /* 0x0008 */ public float FadeGameOutTimeCentreJourney;
        /* 0x000C */ public float FadeMapInTimeCentreJourney;
        /* 0x0010 */ public float PathUIAlpha;
        /* 0x0014 */ public float PathUIDotLength;
        /* 0x0018 */ public float PathUIGapLength;
        /* 0x001C */ public float PathUISelectionMultiplierPad;
        /* 0x0020 */ public float PathUISelectionMultiplierMouse;
        /* 0x0024 */ public float PathUISelectionMultiplierPushing;
        /* 0x0028 */ public float PathUISelectionGenerosity;
        /* 0x002C */ public float PathUISelectionMouseSmoothRate;
        /* 0x0030 */ public float PathUISelectionMouseDeadZone;
        /* 0x0034 */ public float PathUIHeight;
        /* 0x0038 */ public float PathUIXOffset;
        /* 0x003C */ public float PathUIYOffset;
        /* 0x0040 */ public float PathUISlotSpacing;
        /* 0x0044 */ public float PathUISlotRadiusInner;
        /* 0x0048 */ public float PathUISlotRadiusOuter;
        /* 0x004C */ public float PathUISlotRadiusRing;
        /* 0x0050 */ public float PathUISlotWidthRing;
        /* 0x0054 */ public float MarkerDropShadowSize;
        /* 0x0058 */ public float MarkerDropShadowMult;
        /* 0x005C */ public float PlanetUIIconLargeScale;
        /* 0x0060 */ public float PlanetUIIconMediumScale;
        /* 0x0064 */ public float PlanetUIIconSmallScale;
        /* 0x0068 */ public float ShowPopupAtCameraMinDistance;
        /* 0x006C */ public float GalacticPathMaximumJumpDistanceLightyears;
        /* 0x0070 */ public float GalacticPathPreferGuideStarsTillJump;
        /* 0x0074 */ public float ShowUIHelpDuration;
        /* 0x0078 */ public float SystemInfoPanelGeneralAlpha;
        /* 0x007C */ public TkCurveType MarkerPulseStartCurve;
        /* 0x0080 */ public TkCurveType MarkerPulseEndCurve;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x0084 */ public byte[] Padding84;
                     [NMS(Size = 0x06)]
        /* 0x0090 */ public Colour[] GalacticWaypointColours;
                     [NMS(Size = 0x07)]
        /* 0x00F0 */ public Colour[] RaceFilterColours;
                     [NMS(Size = 0x07)]
        /* 0x0160 */ public Colour[] EconomyFilterColours;
                     [NMS(Size = 0x03)]
        /* 0x01D0 */ public Colour[] ConflictFilterColours;
                     [NMS(Size = 0x0D)]
        /* 0x0200 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        /* 0x10A0 */ public float IntroFadeInRate;
        /* 0x10A4 */ public float IntroTitleFadeTrigger;
        /* 0x10A8 */ public float IntroTitleHoldTime;
        /* 0x10AC */ public float IntroFadeOutRate;
        /* 0x10B0 */ public float IntroCameraLookSmoothRate;
        /* 0x10B4 */ public float IntroTitleTextureScale;
        /* 0x10B8 */ public float TransitionTime;
        /* 0x10BC */ public TkCurveType TransitionOutCurve;
        /* 0x10C0 */ public float FinalHoldTime;
        /* 0x10C4 */ public float FinalFadedTime;
        /* 0x10C8 */ public float FinalHoldTowardsCenterTime;
        /* 0x10CC */ public float FinalFadeInRate;
        /* 0x10D0 */ public float FinalFadeOutRate;
        /* 0x10D4 */ public float FinalTransitionMaxSpeed;
        /* 0x10D8 */ public float FinalTransitionAcceleration;
        /* 0x10DC */ public float FinalTransitionInterpolationValue;
        /* 0x10E0 */ public float EarlyStageMultiplier;
        /* 0x10E4 */ public float OffWorldDistance;
        /* 0x10E8 */ public float DistanceComputerScale;
        /* 0x10EC */ public float PathRenderingSelectedStartAlpha;
        /* 0x10F0 */ public float PathRenderingSelectedEndAlpha;
        /* 0x10F4 */ public float PathRenderingSelectedStepAlpha;
        /* 0x10F8 */ public float PathRenderingUnselectedStartAlpha;
        /* 0x10FC */ public float PathRenderingUnselectedEndAlpha;
        /* 0x1100 */ public float PathRenderingUnselectedStepAlpha;
        /* 0x1104 */ public float StarBlurMaxDistanceFromCamera;
        /* 0x1108 */ public float StarBlurMaxBlurLength;
        /* 0x110C */ public float StarBlurSizeMultiplier;
        /* 0x1110 */ public float StarBlurLineWidth;
        /* 0x1114 */ public float StarBlurIntroMultiplier;
        /* 0x1118 */ public float AnostreakAlpha;
        /* 0x111C */ public TkCurveType AnostreakAlphaCurve;
        /* 0x1120 */ public TkCurveType AnostreakValueCurve;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x1124 */ public byte[] Padding1124;
        /* 0x1130 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        /* 0x1160 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        /* 0x1190 */ public float SelectionTreeAlpha;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x1194 */ public byte[] Padding1194;
        /* 0x11A0 */ public Colour SelectionTreeColour;
        /* 0x11B0 */ public Vector2f GoalDistanceRange;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x11B8 */ public byte[] Padding11B8;
        /* 0x11C0 */ public GcGalaxyStarColours BaseStarColours;
        /* 0x1200 */ public GcGalaxyCameraData Camera;
        /* 0x1264 */ public GcGalaxyAudioSetupData Audio;
        /* 0x12A8 */ public float FadeGameOutTime;
        /* 0x12AC */ public float FadeMapInTime;
        /* 0x12B0 */ public float FadeMapOutTime;
        /* 0x12B4 */ public float FadeGameInTime;
        /* 0x12B8 */ public float LargeAreaColourScale;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x12BC */ public byte[] Padding12BC;
        /* 0x12C0 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        /* 0x14D0 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        /* 0x1650 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        /* 0x1860 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;
        /* 0x19E0 */ public GcGalaxySolarSystemParams SolarSystemParameters;
    }
}
