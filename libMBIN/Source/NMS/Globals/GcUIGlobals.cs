using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x2024E20B1CE649A0, NameHash = 0x95C306B1A90F3E08)]
    public class GcUIGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool ShowDifficultyStar;
        /* 0x0004 */ public int DebugMedalRank;
        /* 0x0008 */ public TkCurveType PadCursorUICurve;
        /* 0x0010 */ public Colour JoaoBoxCompletedObjectiveColour;
        /* 0x0020 */ public Colour InvSlotGradientBaseColour;
        /* 0x0030 */ public float InvSlotGradientFactorMin;
        /* 0x0034 */ public float InvSlotGradientFactor;
        /* 0x0038 */ public float InvSlotGradientTime;
        /* 0x003C */ public float GridDecayRateSwitchValue;
        /* 0x0040 */ public float PadCursorUICurveStrength;
        /* 0x0044 */ public bool ReplaceItemBarWithNumbers;
        /* 0x0048 */ public NMSString0x10 DebugInventoryHint;
        /* 0x0058 */ public int MaxSubstanceMaxAmountForAmountFraction;
        /* 0x005C */ public bool UseSquareSlots;
        /* 0x005D */ public bool BigPicking;
        /* 0x005E */ public bool BigPickingUsesNumbers;
        /* 0x0060 */ public float FreighterMegaWarpTransitionTime;
        /* 0x0064 */ public bool EnablePopupUses;
        /* 0x0065 */ public bool TechBoxesCanStack;
        /* 0x0068 */ public int UnknownWordsToShowInCatalogue;
        /* 0x006C */ public bool UseIntermediateMissionGiverOptions;
        /* 0x0070 */ public float SentinelsDisabledHUDMessageTime;
        /* 0x0074 */ public float UseZoomedOutBuildCamRadius;
        /* 0x0078 */ public float ParagraphAutoScrollSpeed;
        /* 0x007C */ public bool AutoScrollParagraphs;
        /* 0x0080 */ public float EggModifiyAnimMaxSize;
        /* 0x0084 */ public float EggModifiyAnimLoopTime;
        /* 0x0088 */ public int SeasonFinalStageIndex;
        /* 0x0090 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        /* 0x00A0 */ public float SeasonalRingMultiplier;
        /* 0x00A4 */ public float SeasonalRingPulseTime;
        /* 0x00A8 */ public float SeasonalRingChangeTime;
        /* 0x00AC */ public float MinSeasonPlayTimeInDays;
        /* 0x00B0 */ public float ExpeditionStageChangeTime;
        /* 0x00B4 */ public float MilestoneStingDisplayTime;
        /* 0x00B8 */ public float StageStingDisplayTime;
        /* 0x00BC */ public float EndOfSeasonAlertDelay;
        /* 0x00C0 */ public int ShowHoursIfLessThan;
        /* 0x00C4 */ public int ShowDaysIfLessThan;
        /* 0x00C8 */ public int ShowWeeksIfLessThan;
        /* 0x00D0 */ public NMSString0x10 ExplorationLogMissionID;
        /* 0x00E0 */ public int ForceOpenHazardProtInventoryThreshold;
        /* 0x00E4 */ public float PlanetDataExtraRadius;
        /* 0x00E8 */ public float StackSizeRateChangeRate;
        /* 0x00EC */ public float StackSizeChangeMinRate;
        /* 0x00F0 */ public float StackSizeChangeMaxRate;
        /* 0x00F4 */ public float ClosestDoorMarkerBuffer;
        /* 0x00F8 */ public bool SkipShopIntro;
        /* 0x00FC */ public float ZoomFactorOverride;
        /* 0x0100 */ public float HandheldZoomFactor;
        /* 0x0104 */ public float PlacedMarkerFadeTime;
        /* 0x0108 */ public float LoadingTravelDistance;
        /* 0x010C */ public float LoadingScreenTravelSpeed;
        /* 0x0110 */ public float LoadingScreenTime;
        /* 0x0114 */ public float OSDMessagePauseOffscreenAngle;
        /* 0x0118 */ public float QuickMenuCentrePos;
        /* 0x011C */ public float QuickMenuSideOffset;
        /* 0x0120 */ public float QuickMenuCentreSideOffset;
        /* 0x0124 */ public float InWorldInteractLabelScale;
        /* 0x0128 */ public float InWorldScreenScaleDistance;
        /* 0x012C */ public Vector2f InWorldInteractLabelAlignment;
        /* 0x0140 */ public Vector3f InWorldInteractLabelCentreOffset;
        /* 0x0150 */ public Vector3f InWorldInteractLabelTopOffset;
        /* 0x0160 */ public Vector3f InWorldInteractLabelLineOffset;
        /* 0x0170 */ public float InWorldInteractLabelMinHeadOffset;
        /* 0x0174 */ public float InWorldInteractLabelNearDistance;
        /* 0x0178 */ public float InWorldInteractLabelNearRange;
        /* 0x017C */ public float InWorldInteractLabelFarDistance;
        /* 0x0180 */ public float InWorldInteractLabelFarRange;
        /* 0x0184 */ public float ShipHUDMarkerHideDistance;
        /* 0x0188 */ public float ShipHUDMarkerOffset;
        /* 0x018C */ public float ExocraftHUDMarkerHideDistance;
        /* 0x0190 */ public float ExocraftHUDMarkerOffset;
        /* 0x0194 */ public float PetSlotUnlockBounceTime;
        /* 0x0198 */ public float PetHUDMarkerExtraFollowInfoDistance;
        /* 0x019C */ public float PetHUDMarkerHideDistance;
        /* 0x01A0 */ public float PetHUDMarkerHideDistanceShort;
        /* 0x01A4 */ public float PetHUDMarkerOffset;
        /* 0x01A8 */ public float PetMoodMarkerOffset;
        /* 0x01AC */ public float BeaconHUDMarkerOffset;
        /* 0x01B0 */ public Vector2f BinocularEdgeFade;
        /* 0x01B8 */ public float BinocularScreenOffset;
        /* 0x01BC */ public float BinocularScreenScale;
        /* 0x01C0 */ public float BinocularMarkerSideAngle;
        /* 0x01C4 */ public float BinocularMarkerUpAngle;
        /* 0x01C8 */ public bool BinocularScanScreen;
        /* 0x01CC */ public float BinocularsNearIconOpacity;
        /* 0x01D0 */ public float BinocularsNearIconDist;
        /* 0x01D4 */ public float BinocularsNearIconFadeDist;
        /* 0x01D8 */ public float BinocularsMidIconOpacity;
        /* 0x01DC */ public float BinocularsFarIconOpacity;
        /* 0x01E0 */ public float BinocularsFarIconDist;
        /* 0x01E4 */ public float BinocularsFarIconFadeDist;
        /* 0x01E8 */ public float AlignmentRequiredToDisableFrostedGlass;
        /* 0x01F0 */ public Vector3f BinocularPanelLinePointOffset;
        /* 0x0200 */ public float FrontendOffsetVR;
        /* 0x0204 */ public float ProjectorScale;
        /* 0x0208 */ public float CockpitGlassFrostTime;
        /* 0x020C */ public float CockpitGlassDefrostTime;
        /* 0x0210 */ public float TextPrintoutMultiplier;
        /* 0x0214 */ public float TextPrintoutMultiplierAlien;
        /* 0x0218 */ public bool EnableHandMenuButtons;
        /* 0x0219 */ public bool AllowInWorldDebugBorders;
        /* 0x021C */ public Vector2f MarkerDistanceVRAlignment;
        /* 0x0224 */ public float CompassIconOffsetVR;
        /* 0x0228 */ public float LowerHelmetScreenScale;
        /* 0x022C */ public float LowerHelmetScreenPitch;
        /* 0x0230 */ public Vector3f LowerHelmetScreenOffset;
        /* 0x0240 */ public float InWorldScreenMinScreenDistance;
        /* 0x0244 */ public float InWorldScreenForwardOffset;
        /* 0x0248 */ public float InWorldNGuiScreenScale;
        /* 0x0250 */ public Vector3f InWorldNGuiScreenRotation;
        /* 0x0260 */ public Vector2f InWorldNGuiParallax;
        /* 0x0268 */ public Vector2f InWorldGameGuiAlignment;
        /* 0x0270 */ public int InWorldInteractLabelWidth;
        /* 0x0274 */ public int InWorldInteractLabelHeight;
        /* 0x0278 */ public NMSString0x20 VRDistanceWarningUIFile;
        /* 0x0298 */ public bool ShowVRDistanceWarning;
        /* 0x02A0 */ public Vector3f FaceLockedScreenOffset;
        /* 0x02B0 */ public int VRFaceLockedScreenWidth;
        /* 0x02B4 */ public int VRFaceLockedScreenHeight;
        /* 0x02B8 */ public bool OnlyShowEjectHandlesInVR;
        /* 0x02BC */ public int CompassScreenWidth;
        /* 0x02C0 */ public int CompassScreenHeight;
        /* 0x02C4 */ public float CompassLineContractionStartAngle;
        /* 0x02C8 */ public float CompassLineContractionEndAngle;
        /* 0x02CC */ public float CompassLineContractionTargetAngle;
        /* 0x02D0 */ public int CompassLineNumNotches;
        /* 0x02D4 */ public float CompassLineThickness;
        /* 0x02D8 */ public float CompassLineOffset;
        /* 0x02DC */ public float CompassLineNotchAngleRange;
        /* 0x02E0 */ public float CompassLineNotchThickness;
        /* 0x02E4 */ public float CompassLineNotchLength;
        /* 0x02E8 */ public bool EnableHandMenuDebug;
        /* 0x02EC */ public float HandControlMenuCursorScale;
        /* 0x02F0 */ public float QuickMenuCursorScale;
        /* 0x02F4 */ public float QuickMenuAlpha;
        /* 0x02F8 */ public float HandScreenGraphicsWidth;
        /* 0x02FC */ public float HandScreenGraphicsHeight;
        /* 0x0300 */ public float HandScreenNearActivateDistance;
        /* 0x0304 */ public float HandButtonRadius;
        /* 0x0308 */ public float HandButtonRadiusTouch;
        /* 0x030C */ public float HandButtonRadiusTouchNear;
        /* 0x0310 */ public float HandButtonRadiusTouchNearActive;
        /* 0x0314 */ public float HandButtonPostClickTime;
        /* 0x0318 */ public float HandButtonReleaseThreshold;
        /* 0x031C */ public float HandButtonReleaseThresholdInit;
        /* 0x0320 */ public float HandButtonCursorScale;
        /* 0x0324 */ public float HandButtonPushDistance;
        /* 0x0328 */ public float HandButtonNearDistance;
        /* 0x032C */ public float HandButtonRadiusClick;
        /* 0x0330 */ public float HandButtonClickTime;
        /* 0x0334 */ public float HandButtonTouchReturnTime;
        /* 0x0338 */ public float HandButtonFrontendCursorScale;
        /* 0x033C */ public float HandButtonThickness;
        /* 0x0340 */ public float HandButtonDotRadius;
        /* 0x0344 */ public float HandButtonPulseRadius;
        /* 0x0348 */ public float HandButtonPulseThickness;
        /* 0x034C */ public float ShipSideScreenHeight;
        /* 0x0350 */ public float SolidPointerScale;
        /* 0x0354 */ public float SolidPointerLengthScale;
        /* 0x0358 */ public float SolidPointerMaxLength;
        /* 0x035C */ public float InWorldInteractionScreenScale;
        /* 0x0360 */ public float InWorldNPCInteractionScreenScale;
        /* 0x0364 */ public bool EnableCraftingTree;
        /* 0x0365 */ public bool QuickMenuEnableSwipe;
        /* 0x0368 */ public float QuickMenuSwipeHeightMin;
        /* 0x036C */ public float QuickMenuSwipeHeightMax;
        /* 0x0370 */ public float BuildMenuItemNavAnimTime;
        /* 0x0374 */ public float BuildMenuItemNextNavAnimTime;
        /* 0x0378 */ public float BuildMenuItemNextNavAnimWait;
        /* 0x037C */ public float QuickMenuInteractAdjustX;
        /* 0x0380 */ public float QuickMenuInteractAdjustY;
        /* 0x0384 */ public int QuickMenuScreenWidth;
        /* 0x0388 */ public int QuickMenuScreenHeight;
        /* 0x038C */ public float QuickMenuHighlightRate;
        /* 0x0390 */ public float HandControlButtonSize;
        /* 0x0394 */ public float HandControlPointMargin;
        /* 0x0398 */ public float HandControlPointActiveMargin;
        /* 0x039C */ public float HandControlMenuMoveDistance;
        /* 0x03A0 */ public float HandControlMenuMoveDistanceScroll;
        /* 0x03A4 */ public float HandControlMenuMoveDistanceVertical;
        /* 0x03A8 */ public float HandControlMenuMoveActionDistance;
        /* 0x03AC */ public float HandControlMenuAngle;
        /* 0x03B0 */ public float HandControlMenuSurfaceOffset;
        /* 0x03B4 */ public float HandControlMenuSelectRadius;
        /* 0x03B8 */ public float HandControlMenuSelectRadius1;
        /* 0x03BC */ public float HandControlMenuSelectRadius2;
        /* 0x03C0 */ public float HandControlTopMenuSelectRadius;
        /* 0x03C4 */ public int HandScreenWeaponWidth;
        /* 0x03C8 */ public int HandScreenWeaponHeight;
        /* 0x03CC */ public int HandScreenWidth;
        /* 0x03D0 */ public int HandScreenHeight;
        /* 0x03E0 */ public Colour DebugEditorAxisColourUpInactive;
        /* 0x03F0 */ public Colour DebugEditorAxisColourUpActive;
        /* 0x0400 */ public Colour DebugEditorAxisColourRightInactive;
        /* 0x0410 */ public Colour DebugEditorAxisColourRightActive;
        /* 0x0420 */ public Colour DebugEditorAxisColourAtInactive;
        /* 0x0430 */ public Colour DebugEditorAxisColourAtActive;
        /* 0x0440 */ public Colour QuickMenuSelectedItemColour1;
        /* 0x0450 */ public Colour QuickMenuSelectedItemColour2;
        /* 0x0460 */ public TkModelRendererData ShipThumbnailModelView;
        /* 0x0510 */ public TkModelRendererData PetThumbnailModelView;
        /* 0x05C0 */ public TkModelRendererData MultitoolThumbnailModelView;
        /* 0x0670 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        /* 0x0720 */ public Colour FrontendCursorBackgroundColour;
        /* 0x0730 */ public float NGuiHmdOffset;
        /* 0x0734 */ public float HmdFramerateScreenPitch;
        /* 0x0740 */ public Vector3f HmdFramerateScreenOffset;
        /* 0x0750 */ public float CrosshairScaleHmd;
        /* 0x0754 */ public float CrosshairOffsetHmd;
        /* 0x0758 */ public float CrosshairOffsetHmdUp;
        /* 0x075C */ public int CrosshairScreenWidth;
        /* 0x0760 */ public int CrosshairScreenHeight;
        /* 0x0764 */ public float HUDMarkerHoverAngleTestGroundHmd;
        /* 0x0768 */ public float HUDMarkerWideHoverAngleTestHmd;
        /* 0x076C */ public bool InteractionInWorldPlayerCamAlways;
        /* 0x0770 */ public float InteractionInWorldPitchDistance;
        /* 0x0774 */ public float InteractionInWorldMinScreenDistance;
        /* 0x0778 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        /* 0x077C */ public float TravelTargetRadius;
        /* 0x0780 */ public float TravelLineThickness;
        /* 0x0790 */ public Colour TravelLineColour;
        /* 0x07A0 */ public Colour TravelLineTooFarColour;
        /* 0x07B0 */ public Colour TravelLineTooSteepColour;
        /* 0x07C0 */ public Colour TravelLineInvalidColour;
        /* 0x07D0 */ public Colour TravelLineNotAllowedColour;
        /* 0x07E0 */ public Colour TravelTargetColour;
        /* 0x07F0 */ public bool AlwaysCloseQuickMenu;
        /* 0x07F1 */ public bool UseWorldNodesForRepair;
        /* 0x07F2 */ public bool RepairTechUseTechIcon;
        /* 0x07F3 */ public bool DebugMissionLogText;
        /* 0x07F4 */ public bool DebugShowMaintenanceScreenCentre;
        /* 0x07F5 */ public bool DebugPopupSizes;
        /* 0x07F6 */ public bool DebugInventoryIndices;
        /* 0x07F7 */ public bool FixedInventoryIconPositions;
        /* 0x0800 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        /* 0x0860 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        /* 0x08C0 */ public float OSDMessageQueueSpeedMultiplier;
        /* 0x08C4 */ public int OSDMessageQueueMin;
        /* 0x08C8 */ public int OSDMessageQueueMax;
        /* 0x08CC */ public float PopupValueSectionBaseHeight;
        /* 0x08D0 */ public float PopupValueSectionHeight;
        /* 0x08E0 */ public Colour ProcProductColourCommon;
        /* 0x08F0 */ public Colour ProcProductColourUncommon;
        /* 0x0900 */ public Colour ProcProductColourRare;
        /* 0x0910 */ public List<Vector2f> InventoryIconPositions;
        /* 0x0920 */ public Colour PickedItemBorderColour;
        /* 0x0930 */ public Colour MultiplayerMissionParticipantsColour;
        /* 0x0940 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        /* 0x0950 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        /* 0x0960 */ public float NotificationHazardMinTimeAfterRecharge;
        /* 0x0964 */ public float LoadFadeInDefaultTime;
        /* 0x0968 */ public float DroneIndicatorRadius;
        /* 0x096C */ public float DroneIndicatorCentreRadiusMax;
        /* 0x0970 */ public float DroneIndicatorCentreRadiusMin;
        /* 0x0974 */ public float DroneIndicatorFadeRange;
        /* 0x0978 */ public float WantedDetectMessageTime;
        /* 0x097C */ public float WantedDetectMinTimeout;
        /* 0x0980 */ public float TakeoffFuelMessageTime;
        /* 0x0984 */ public float MarkerHorizonOffsetAngle;
        /* 0x0988 */ public float MarkerHorizonMinOffset;
        /* 0x098C */ public float MarkerHorizonApproachAngle;
        /* 0x0990 */ public float MarkerOffsetTypeAngle;
        /* 0x0994 */ public float MarkerOffsetTypeAngleBattle;
        /* 0x0998 */ public float MarkerOffsetTypeAngleBounty;
        /* 0x099C */ public float MarkerOffsetTypeAnglePlayerShip;
        /* 0x09A0 */ public float MarkerOffsetTypeAngleAsteroid;
        /* 0x09A4 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        /* 0x09A8 */ public float MarkerHorizonShipApproachOffset;
        /* 0x09AC */ public float TransferPopupCursorOffsetFactor;
        /* 0x09B0 */ public float ScannableIconMergeAngle;
        /* 0x09B4 */ public float CreatureIconMergeAngle;
        /* 0x09B8 */ public int MaxNumMessageBeaconIcons;
        /* 0x09BC */ public float MissionObjectiveBaseHeight;
        /* 0x09C0 */ public float MissionObjectiveDoneHeight;
        /* 0x09C4 */ public float MissionDetailsPageBaseHeight;
        /* 0x09C8 */ public float MarkerTagAppearDelay;
        /* 0x09CC */ public Vector2f CompassCentre;
        /* 0x09D4 */ public float CompassHeight;
        /* 0x09D8 */ public float CompassWidth;
        /* 0x09DC */ public float CompassDistanceScaleMin;
        /* 0x09E0 */ public float CompassDistanceScaleRange;
        /* 0x09E4 */ public float CompassDistanceSpaceScaleMin;
        /* 0x09E8 */ public float CompassDistanceSpaceScaleRange;
        /* 0x09EC */ public float CompassDistanceScale;
        /* 0x09F0 */ public float CompassDistanceShipMinScale;
        /* 0x09F4 */ public float CompassDistanceMaxAngle;
        /* 0x09F8 */ public float CompassDistanceYOffset;
        /* 0x09FC */ public float CompassAngleClamp;
        /* 0x0A00 */ public float CompassAngleFade;
        /* 0x0A04 */ public TkCurveType CompassCurve;
        /* 0x0A08 */ public float CompassAngleClampSpace;
        /* 0x0A0C */ public float BaseComplexityDangerFactor;
        /* 0x0A10 */ public float BaseComplexityWarningFactor;
        /* 0x0A20 */ public Colour BaseComplexityDefaultColour;
        /* 0x0A30 */ public Colour BaseComplexityWarningColour;
        /* 0x0A40 */ public Colour BaseComplexityDangerColour;
        /* 0x0A50 */ public float BuildMenuActionMessageDuration;
        // size: 0x10
        public enum BuildMenuOnActionLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionLocIDsEnum))]
        /* 0x0A58 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        // size: 0x10
        public enum BuildMenuOnActionDisabledLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionDisabledLocIDsEnum))]
        /* 0x0C58 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        // size: 0x10
        public enum BuildMenuOnActionErrorLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionErrorLocIDsEnum))]
        /* 0x0E58 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        // size: 0x10
        public enum BuildMenuUseSmallIconOnPadEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuUseSmallIconOnPadEnum))]
        /* 0x1058 */ public bool[] BuildMenuUseSmallIconOnPad;
        /* 0x1070 */ public Colour BuildMenuPassiveErrorTextColour;
        /* 0x1080 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        /* 0x1090 */ public Colour BuildMenuErrorTextColour;
        /* 0x10A0 */ public Colour BuildMenuErrorTextOutlineColour;
        /* 0x10B0 */ public Colour BuildMenuErrorTextFlashColour;
        /* 0x10C0 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        /* 0x10D0 */ public Colour BuildMenuInfoTextColour;
        /* 0x10E0 */ public Colour BuildMenuInfoTextOutlineColour;
        /* 0x10F0 */ public float IconGlowStrengthError;
        /* 0x10F4 */ public float IconGlowStrengthActive;
        /* 0x10F8 */ public float IconGlowStrengthNeutral;
        /* 0x10FC */ public float IconGlowStrengthHighlight;
        /* 0x1100 */ public Colour IconGlowColourError;
        /* 0x1110 */ public Colour IconGlowColourActive;
        /* 0x1120 */ public Colour IconGlowColourNeutral;
        /* 0x1130 */ public Colour IconGlowColourHighlight;
        /* 0x1140 */ public float BaseBuildingPinHighlightDuration;
        /* 0x1144 */ public float BaseBuildingInputHighlightDuration;
        /* 0x1148 */ public float BaseBuildingInputHighlightAlpha;
        /* 0x114C */ public float BaseBuildingScaleSpeed;
        /* 0x1150 */ public float BaseBuildingMinFreeRotateSpeed;
        /* 0x1154 */ public float BaseBuildingMaxFreeRotateSpeed;
        /* 0x1158 */ public float BaseBuildingTimeToMaxRotationSpeed;
        /* 0x115C */ public float BaseBuildingRotationResetRate;
        /* 0x1160 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        /* 0x1164 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        /* 0x1168 */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        /* 0x116C */ public bool BaseBuildingSmoothMenuWhileSnapped;
        /* 0x1170 */ public float BaseBuildingUIHorizontalSafeArea;
        /* 0x1174 */ public float BaseBuildingUIVerticalSafeArea;
        /* 0x1178 */ public float BaseBuildingUIVerticalPosWiring;
        /* 0x117C */ public float BaseBuildingUIVerticalOffset;
        /* 0x1180 */ public float BaseBuildingUIVerticalOffsetEdit;
        /* 0x1184 */ public float BaseBuildingUIVerticalOffsetFromBB;
        /* 0x1188 */ public float BaseBuildingUIErrorFadeTime;
        /* 0x118C */ public float BaseBuildingUIAdjustTime;
        /* 0x1190 */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        /* 0x1194 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        /* 0x1198 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        /* 0x119C */ public float BaseBuildingPartsGridScrollSpeed;
        /* 0x11A0 */ public float BaseBuildingPartsGridPopupDelay;
        /* 0x11A4 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        /* 0x1228 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        /* 0x12AC */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        /* 0x1330 */ public float MarkerRingInnerRadius;
        /* 0x1334 */ public float MarkerRingOuterRadius;
        /* 0x1340 */ public Colour MarkerRingBGColour;
        /* 0x1350 */ public float RepairTechRepairedWaitTime1;
        /* 0x1354 */ public float RepairTechRepairedWaitTime2;
        /* 0x1358 */ public float RepairTechRepairedMessageTime;
        /* 0x135C */ public float TechPopupRepairLayerHeight;
        /* 0x1360 */ public float TechPopupBuildLayerHeight;
        /* 0x1364 */ public float TechPopupRequirementHeight;
        /* 0x1368 */ public float DamageTrackArrowTime;
        /* 0x136C */ public bool EnableBlackouts;
        /* 0x1370 */ public float HUDMarkerObjectMinScreenDistance;
        /* 0x1374 */ public float HUDMarkerDistanceOrTimeDistance;
        /* 0x1378 */ public float MarkerComponentOffset;
        /* 0x137C */ public float RepairTechLabelOffset;
        /* 0x1380 */ public float MaintenanceIconFadeStart;
        /* 0x1384 */ public float MaintenanceIconFadeTime;
        /* 0x1390 */ public TkModelRendererData RepairCamera;
        /* 0x1440 */ public TkModelRendererData RepairWeaponCamera;
        /* 0x14F0 */ public TkModelRendererData RepairBackpackCamera;
        /* 0x15A0 */ public TkModelRendererData RepairShipCameraInWorld;
        /* 0x1650 */ public TkModelRendererData RepairShipCameraModelView;
        /* 0x1700 */ public TkModelRendererData RepairShipCameraVR;
        /* 0x17B0 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        /* 0x17C0 */ public Vector2f BinocularsDiscoveryPos;
        /* 0x17D0 */ public Colour InteractionLabelCostColour;
        /* 0x17E0 */ public Colour InteractionLabelPickupColour;
        /* 0x17F0 */ public Colour InteractionLabelPickupFillColour;
        /* 0x1800 */ public Vector2f PersonalRefinerInputPos;
        /* 0x1808 */ public Vector2f PersonalRefinerOutputPos;
        /* 0x1810 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        /* 0x1894 */ public float RefinerPadStartTime;
        /* 0x1898 */ public float RefinerPadStartDecayTime;
        /* 0x189C */ public float RefinerBeginDialInnerRadius;
        /* 0x18A0 */ public float RefinerProgressDialInnerRadius;
        /* 0x18B0 */ public Vector3f DefaultRefinerOffsetIn;
        /* 0x18C0 */ public Vector3f DefaultRefinerOffsetOut;
        /* 0x18D0 */ public Vector2f RefinerParallax;
        /* 0x18D8 */ public Vector2f ModelViewWorldParallax;
        /* 0x18E0 */ public Vector2f HUDPlayerSentinelPulseFreq;
        /* 0x18E8 */ public Vector2f HUDPlayerSentinelPulseSize;
        /* 0x18F0 */ public float HUDPlayerSentinelPulseWidth;
        /* 0x18F4 */ public float HUDPlayerSentinelRangeFactor;
        /* 0x18F8 */ public float HUDPlayerSentinelPulseScanFreq;
        /* 0x18FC */ public float HUDPlayerPhonePulseScanFreq;
        /* 0x1900 */ public float RefinerAutoCloseTime;
        /* 0x1910 */ public Colour RefinerBackgroundColour;
        /* 0x1920 */ public Colour RefinerErrorBackgroundColour;
        /* 0x1930 */ public Colour GridDisconnectedColour;
        /* 0x1940 */ public Colour GridOnlineColour;
        /* 0x1950 */ public Colour GridOfflineColour;
        /* 0x1960 */ public Colour GridBackgroundNeutralColour;
        /* 0x1970 */ public Colour GridBackgroundPositiveColour;
        /* 0x1980 */ public Colour GridBackgroundNegativeColour;
        /* 0x1990 */ public Colour TransferSendPopupColour;
        /* 0x19A0 */ public float BountyMarkerOffset;
        /* 0x19A4 */ public float PlanetRaidMarkerOffset;
        /* 0x19A8 */ public float TransitionOffset;
        /* 0x19AC */ public float PageTurnTime;
        /* 0x19B0 */ public TkCurveType PageTurnCurve;
        /* 0x19B4 */ public TkCurveType PageTurnFadeCurve;
        /* 0x19B8 */ public float LowHealthShieldMin;
        /* 0x19BC */ public float LowHealthShieldFactor;
        /* 0x19C0 */ public int MaxDialogCharSizeRoman;
        /* 0x19C4 */ public NMSString0x20 MaxDialogCharSizeRomanString;
        /* 0x19E4 */ public int MaxDialogCharSizeIdeographic;
        /* 0x19E8 */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        /* 0x1A08 */ public float ShipOverheatSwitchMessageWait;
        /* 0x1A0C */ public float ShipOverheatSwitchMessageTime;
        /* 0x1A10 */ public bool LeadTargetEnabled;
        /* 0x1A11 */ public bool SpaceOnlyLeadTargetEnabled;
        /* 0x1A14 */ public Vector2f SaveIconPosition;
        /* 0x1A1C */ public float MissionStartEndTime;
        /* 0x1A20 */ public float MissionStartEndOSDTime;
        /* 0x1A24 */ public float MissionStartEndOSDTimeProcedural;
        /* 0x1A28 */ public float StandingRewardOSDTime;
        /* 0x1A30 */ public Colour MissionOSDMessageBarColour;
        /* 0x1A40 */ public Colour NotificationDefaultColour;
        /* 0x1A50 */ public Colour NotificationDangerColour;
        /* 0x1A60 */ public Colour NotificationInfoColour;
        /* 0x1A70 */ public Colour NotificationUrgentColour;
        /* 0x1A80 */ public float ShipDamageDirectionIndicatorRadius;
        /* 0x1A84 */ public float ShipDamageDirectionIndicatorFadeRange;
        /* 0x1A88 */ public float OnFootDamageDirectionIndicatorRadius;
        /* 0x1A8C */ public float OnFootDamageDirectionIndicatorFadeRange;
        /* 0x1A90 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        /* 0x1A94 */ public Vector2f DialogPageCursorOffset;
        /* 0x1A9C */ public Vector2f IntermediateInteractionPageCursorOffset;
        /* 0x1AA4 */ public Vector2f CursorlessDialogPageCursorOffset;
        /* 0x1AAC */ public int MissionSpecificMissionPercent;
        /* 0x1AB0 */ public int MissionLoopCount;
        /* 0x1AB4 */ public int MissionSeedOffset;
        /* 0x1AC0 */ public Vector3f SpaceMapCockpitOffset;
        /* 0x1AD0 */ public float SpaceMapCockpitScale;
        /* 0x1AD4 */ public float SpaceMapCockpitScaleAdjustDropShip;
        /* 0x1AD8 */ public float SpaceMapCockpitScaleAdjustFighter;
        /* 0x1ADC */ public float SpaceMapCockpitScaleAdjustScientific;
        /* 0x1AE0 */ public float SpaceMapCockpitScaleAdjustShuttle;
        /* 0x1AE4 */ public float SpaceMapCockpitScaleAdjustRoyal;
        /* 0x1AE8 */ public float SpaceMapCockpitScaleAdjustSail;
        /* 0x1AEC */ public float SpaceMapCockpitScaleAdjustAlien;
        /* 0x1AF0 */ public float SpaceMapCockpitAngle;
        /* 0x1AF4 */ public float TargetDisplayScale;
        /* 0x1AF8 */ public float TargetDisplayShipScale;
        /* 0x1B00 */ public Vector3f TargetDisplayShipOffset;
        /* 0x1B10 */ public float TargetDisplayDamageFlashTime;
        /* 0x1B20 */ public GcScanEffectData TargetDisplayScanEffect;
        /* 0x1B70 */ public bool ProgressiveDialogStyle;
        /* 0x1B74 */ public float CommunicatorMessageTime;
        /* 0x1B80 */ public Colour CommunicatorMessageColour;
        /* 0x1B90 */ public float GridFlickerBaseAlpha;
        /* 0x1B94 */ public float GridFlickerFreq;
        /* 0x1B98 */ public float GridFlickerAmp;
        /* 0x1B9C */ public float HUDMarkerLabelWidthMultiplier;
        /* 0x1BA0 */ public float HUDMarkerLabelBaseWidth;
        /* 0x1BA4 */ public float HUDMarkerLabelArriveDistance;
        /* 0x1BA8 */ public float HUDMarkerLabelDisplayDistance;
        /* 0x1BAC */ public float HUDMarkerNonActiveMissionAlpha;
        /* 0x1BB0 */ public bool DebugMarkerLabels;
        /* 0x1BC0 */ public GcScanEffectData DebugEditorPreviewEffect;
        /* 0x1C10 */ public bool ShowDamageNumbers;
        /* 0x1C14 */ public float QuickMenuCloseTime;
        /* 0x1C18 */ public float QuickMenuErrorTime;
        /* 0x1C1C */ public float FrontendWaitResponse;
        /* 0x1C20 */ public float FrontendWaitInitial;
        /* 0x1C24 */ public float FrontendWaitInitialTerminal;
        /* 0x1C28 */ public float FrontendWaitFadeTextOut;
        /* 0x1C2C */ public float FrontendWaitFadeTextFrameOut;
        /* 0x1C30 */ public float FrontendWaitFadeProgressiveDialogOut;
        /* 0x1C34 */ public float FrontendWaitResponseOffset;
        /* 0x1C38 */ public float TalkBoxAlienTextSpeed;
        /* 0x1C3C */ public float TalkBoxAlienTextTimeMin;
        /* 0x1C40 */ public float TalkBoxAlienTextTimeMax;
        /* 0x1C44 */ public float DescriptionTextDelay;
        /* 0x1C48 */ public float DescriptionTextSpeed;
        /* 0x1C4C */ public float DescriptionTextSpeedProgressive;
        /* 0x1C50 */ public float DescriptionTextTimeMin;
        /* 0x1C54 */ public float DescriptionTextTimeMax;
        /* 0x1C58 */ public float ConsoleTextSpeed;
        /* 0x1C5C */ public float ConsoleTextTimeMin;
        /* 0x1C60 */ public float ConsoleTextTimeMax;
        /* 0x1C64 */ public float HoverOffscreenBorder;
        /* 0x1C68 */ public float HoverOffscreenBorderVR;
        /* 0x1C6C */ public float TransferSendOffscreenBorder;
        /* 0x1C70 */ public float TimedEventLookTime;
        /* 0x1C74 */ public float CreatureDistanceSize;
        /* 0x1C78 */ public float CreatureDistanceOffsetY;
        /* 0x1C7C */ public float CreatureDistanceShadowOffset;
        /* 0x1C80 */ public float CreatureDistanceDisplayAngle;
        /* 0x1C84 */ public float CreatureDistanceFadeTime;
        /* 0x1C88 */ public float CreatureDistanceAlpha;
        /* 0x1C8C */ public bool ShowOnscreenPredatorMarkers;
        /* 0x1C90 */ public float DamageImpactMergeTime;
        /* 0x1C94 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x1C98 */ public float DamageImpactMinDistance;
        /* 0x1C9C */ public float DamagePerSecondSampleTime;
        /* 0x1CA0 */ public float DamageNumberTime;
        /* 0x1CA4 */ public float DamageNumberSizeInShip;
        /* 0x1CA8 */ public float DamageNumberSize;
        /* 0x1CAC */ public float DamageNumberSizeCritMultiplier;
        /* 0x1CB0 */ public float DamageNumberSizeLaserMultiplier;
        /* 0x1CB4 */ public float DamageNumberLaserMinDamage;
        /* 0x1CB8 */ public float DamageNumberLaserMaxDamage;
        /* 0x1CBC */ public float DamageNumberBlackAlpha;
        /* 0x1CC0 */ public float DamageNumberOutline;
        /* 0x1CC4 */ public float DamageNumberOutline2;
        /* 0x1CC8 */ public float DamageNumberOffsetX;
        /* 0x1CCC */ public float DamageNumberOffsetY;
        /* 0x1CD0 */ public Vector2f DamageNumberSideSpeed;
        /* 0x1CD8 */ public float DamageNumberFadeIn;
        /* 0x1CDC */ public float DamageNumberFadeOut;
        /* 0x1CE0 */ public float DamageNumberUpOffset;
        /* 0x1CE4 */ public TkCurveType DamageNumberUpCurve;
        /* 0x1CF0 */ public Colour DamageNumberCriticalColour;
        /* 0x1D00 */ public Colour DamageNumberIneffectiveColour;
        /* 0x1D10 */ public Colour DamageNumberIneffectiveWarningColour;
        /* 0x1D20 */ public Colour PhotoModeSelectedColour;
        /* 0x1D30 */ public Colour PhotoModeUnselectedColour;
        /* 0x1D40 */ public Colour FuelBgColour;
        /* 0x1D50 */ public float PhotoModeValueAlpha;
        /* 0x1D54 */ public float PhotoModeTimeofDayChange;
        /* 0x1D58 */ public float FrigateIconOffset;
        /* 0x1D5C */ public float CreatureIconOffset;
        /* 0x1D60 */ public float CreatureIconOffsetPhysics;
        /* 0x1D64 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        /* 0x1D68 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        /* 0x1D6C */ public float FreighterSummonTurn;
        /* 0x1D70 */ public float FreighterSummonPitch;
        /* 0x1D74 */ public float FreighterSummonOffset;
        /* 0x1D78 */ public float FreighterSummonOffsetPulse;
        /* 0x1D7C */ public float FreighterSummonDelay;
        /* 0x1D80 */ public int FreighterSummonTurnNumTries;
        /* 0x1D84 */ public float FreighterSummonTurnAngleIncrement;
        /* 0x1D88 */ public float FreighterSummonGridSize;
        /* 0x1D8C */ public float FreighterCommanderMarkerMinDistance;
        /* 0x1D90 */ public float FreighterSurfaceMinAngle;
        /* 0x1D94 */ public float FreighterSummonPulseRate;
        /* 0x1D98 */ public float FreighterSummonPulseFadeAmount;
        /* 0x1D9C */ public float FreighterSummonPlanetOffset;
        /* 0x1DA0 */ public float FreighterSummonLookTime;
        /* 0x1DA4 */ public float FreighterHighlightRange;
        /* 0x1DB0 */ public GcScanEffectData FreighterSummonScanEffect;
        /* 0x1E00 */ public Colour FreighterSummonScanEffectColourBlocked;
        /* 0x1E10 */ public Colour FreighterSummonScanEffectColourHighlight;
        /* 0x1E20 */ public float PirateCountdownTime;
        /* 0x1E24 */ public float PirateAttackIndicatorWidth;
        /* 0x1E28 */ public float PirateAttackIndicatorRadius;
        /* 0x1E2C */ public float PirateAttackProbeDisplayFinishFactor;
        /* 0x1E30 */ public float HazardArrowsLevel2Threshold;
        /* 0x1E34 */ public float HazardArrowsLevel3Threshold;
        /* 0x1E38 */ public float ArrowBounceLength;
        /* 0x1E3C */ public float ArrowBounceRate;
        /* 0x1E40 */ public float ArrowBounceRightRate1;
        /* 0x1E44 */ public float ArrowBounceRightRate2;
        /* 0x1E48 */ public TkCurveType ArrowBounceRightCurve;
        /* 0x1E4C */ public float ArrowBounceLeftRate1;
        /* 0x1E50 */ public float ArrowBounceLeftRate2;
        /* 0x1E54 */ public float ArrowBounceLeftRate3;
        /* 0x1E58 */ public TkCurveType ArrowBounceLeftCurve;
        /* 0x1E5C */ public float PlanetScanDelayTime;
        /* 0x1E60 */ public float AlwaysShowIconFadeDistance;
        /* 0x1E64 */ public float AlwaysShowIconFadeRange;
        /* 0x1E68 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        /* 0x1E6C */ public float FrigateDamageIconVisibilityDistance;
        /* 0x1E70 */ public float FreighterLeaderIconDistance;
        /* 0x1E74 */ public float FreighterEntranceOffset;
        /* 0x1E78 */ public float ShipHeadsUpDisplayDistance;
        /* 0x1E7C */ public float ShipHeadsUpLineFadeTime;
        /* 0x1E80 */ public float CrosshairAimTime;
        /* 0x1E84 */ public float CrosshairAimOffTime;
        /* 0x1E88 */ public float CrosshairInnerMinFade;
        /* 0x1E8C */ public float CrosshairInnerMinFadeRange;
        /* 0x1E90 */ public float CrosshairLeadScaleIn;
        /* 0x1E94 */ public float CrosshairLeadInDelay;
        /* 0x1E98 */ public float CrosshairLeadInTime;
        /* 0x1E9C */ public float CrosshairLeadCornerOffset;
        /* 0x1EA0 */ public float CrosshairLeadTopOffset;
        /* 0x1EA4 */ public float CrosshairLeadTopLock;
        /* 0x1EA8 */ public float CrosshairLeadPulseSize;
        /* 0x1EAC */ public TkCurveType CrosshairLeadScaleCurve;
        /* 0x1EB0 */ public float CrosshairSpringTime;
        /* 0x1EB4 */ public float CrosshairSpringAimTime;
        /* 0x1EB8 */ public float CrosshairLeadSpring;
        /* 0x1EBC */ public float CrosshairLeadSpringOff;
        /* 0x1EC0 */ public float CrosshairLeadFadeRange;
        /* 0x1EC4 */ public float CrosshairLeadFadeSize;
        /* 0x1ED0 */ public Colour CrosshairLeadThreatColour;
        /* 0x1EE0 */ public Colour CrosshairLeadPassiveColour;
        /* 0x1EF0 */ public float CrosshairInterceptSize;
        /* 0x1EF4 */ public float CrosshairInterceptBaseSize;
        /* 0x1EF8 */ public float CrosshairInterceptCentreBaseSize;
        /* 0x1EFC */ public float CrosshairInterceptSpringTime;
        /* 0x1F00 */ public float CrosshairInterceptAlpha;
        /* 0x1F04 */ public float CrosshairInterceptLockRange;
        /* 0x1F08 */ public float CrosshairTargetLockSize;
        [NMS(Size = 0x13)]
        /* 0x1F0C */ public float[] CrosshairTargetLockSizeSpecific;
        /* 0x1F58 */ public TkCurveType CrosshairTargetLockCurve;
        /* 0x1F5C */ public TkCurveType CrosshairTargetLockAlphaCurve;
        /* 0x1F60 */ public Colour CrosshairColour;
        /* 0x1F70 */ public TkHitCurveData CrosshairLeadHitCurve;
        /* 0x1F80 */ public TkHitCurveData ShootableHitCurve;
        /* 0x1F90 */ public int ControlScrollSteps;
        /* 0x1F94 */ public float ControlScrollDistance;
        /* 0x1FA0 */ public Colour SelectedControlColour;
        /* 0x1FB0 */ public Colour RemappedControlColour;
        /* 0x1FC0 */ public float MissionCompassIconScaler;
        /* 0x1FC4 */ public float MissionMarkerSize;
        /* 0x1FC8 */ public float CreatureRoutineMarkerTime;
        /* 0x1FCC */ public int CreatureRoutineRegionsPerFrame;
        /* 0x1FD0 */ public float SpaceMarkersOffset;
        /* 0x1FD4 */ public float SpaceMarkersBattleOffset;
        /* 0x1FD8 */ public float LargeSpaceIconSize;
        /* 0x1FDC */ public float SmallSpaceIconSize;
        /* 0x1FE0 */ public float PetHoverIconSize;
        /* 0x1FE4 */ public float PetIconSize;
        /* 0x1FE8 */ public Vector2f TrackTypeIconOffset;
        /* 0x1FF0 */ public float TrackTypeIconSize;
        /* 0x1FF4 */ public float TrackPrimaryCentreOffset;
        /* 0x1FF8 */ public float TrackTimerAlpha;
        /* 0x1FFC */ public float TrackTimerRadarPulseSize;
        /* 0x2000 */ public float TrackTimerIconOuterRadius;
        /* 0x2004 */ public float TrackTimerIconInnerRadius;
        /* 0x2008 */ public float TrackTimerIconExclaimRadius;
        /* 0x200C */ public float MissileCentreOffset;
        /* 0x2010 */ public float TrackMissileTargetPulseRate;
        /* 0x2014 */ public float TrackScaleCritical;
        /* 0x2018 */ public float TrackScaleHit;
        /* 0x201C */ public float TrackLeadTargetInScale;
        /* 0x2020 */ public float TrackReticuleScale;
        /* 0x2024 */ public float TrackReticuleAngle;
        /* 0x2028 */ public float TrackReticuleInTime;
        /* 0x202C */ public float TrackReticuleInactiveTime;
        /* 0x2030 */ public float TrackReticuleRandomTime;
        /* 0x2034 */ public float TrackReticuleRandomDelay;
        /* 0x2038 */ public TkCurveType TrackReticuleInCurve;
        /* 0x203C */ public TkCurveType TrackReticuleInAngleCurve;
        /* 0x2040 */ public float CreatureReticuleScale;
        /* 0x2044 */ public TkCurveType CreatureReticuleScaleCurve;
        /* 0x2048 */ public TkCurveType CreatureReticuleAlphaCurve;
        /* 0x204C */ public bool CreatureInteractLabelUseBB;
        /* 0x2050 */ public float CreatureInteractLabelOffsetY;
        /* 0x2054 */ public float HUDDroneHealingPulse;
        /* 0x2058 */ public float HUDDroneSummoningPulse;
        /* 0x205C */ public float HUDDroneCombatPulse;
        /* 0x2060 */ public float HUDPlayerTrackNoSightPulse;
        /* 0x2064 */ public float HUDPlayerTrackTimerStart;
        /* 0x2068 */ public float HUDPlayerTrackTimerStartFade;
        /* 0x206C */ public float HUDPlayerTrackTimerEnd;
        /* 0x2070 */ public float HUDPlayerTrackTimerPulseRate;
        /* 0x2074 */ public TkCurveType TrackCritCurve;
        /* 0x2078 */ public Vector2f TrackCriticalHitOffset;
        /* 0x2080 */ public float TrackCriticalHitSize;
        /* 0x2084 */ public float TrackCriticalPulseTime;
        /* 0x2088 */ public float ThirdPersonCrosshairDistance;
        /* 0x208C */ public float ThirdPersonCrosshairCircle1Distance;
        /* 0x2090 */ public float ThirdPersonCrosshairCircle2Distance;
        /* 0x2094 */ public float HUDPlayerTrackArrowShipLabelOffset;
        /* 0x2098 */ public float HUDPlayerTrackArrowIconPulseTime;
        /* 0x209C */ public float HUDPlayerTrackArrowIconShowTime;
        /* 0x20A0 */ public float HUDPlayerTrackArrowIconFadeTime;
        /* 0x20A4 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        /* 0x20AC */ public float HUDPlayerTrackArrowIconPulseWidth1;
        /* 0x20B0 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        /* 0x20B4 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        /* 0x20B8 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        /* 0x20BC */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        /* 0x20C0 */ public float HUDPlayerTrackArrowIconFadeDist;
        /* 0x20C4 */ public float HUDPlayerTrackArrowIconFadeRange;
        /* 0x20C8 */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        /* 0x20CC */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        /* 0x20D0 */ public float HUDPlayerTrackArrowPulseOffset;
        /* 0x20D4 */ public float HUDPlayerTrackArrowPulseRate;
        /* 0x20D8 */ public Vector2f HUDPlayerTrackIconOffset;
        /* 0x20E0 */ public float ShipFullscreenDamperMin;
        /* 0x20E4 */ public float ShipFullscreenDamper;
        /* 0x20E8 */ public float ShipDesatDamper;
        /* 0x20EC */ public float ScanEventArrowShipFadeRange;
        /* 0x20F0 */ public float ScanEventArrowShipFadeDistance;
        /* 0x20F4 */ public float ScanEventArrowPlayerFadeRange;
        /* 0x20F8 */ public float ScanEventArrowPlayerFadeDistance;
        /* 0x20FC */ public float ScanEventArrowOffsetMultiplier;
        /* 0x2100 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        /* 0x2104 */ public float ScanEventArrowSecondaryAlpha;
        /* 0x2108 */ public GcAudioWwiseEvents ScanEventIconAudio;
        /* 0x210C */ public TkNGuiRectanglePulseEffect PulseBarData;
        /* 0x2120 */ public TkNGuiRectanglePulseEffect PulseIconData;
        /* 0x2140 */ public Colour PulseDamageColour;
        /* 0x2150 */ public Colour PulseAlertColour;
        /* 0x2160 */ public float TechDisplayDelayTime;
        /* 0x2164 */ public float CriticalMessageTime;
        /* 0x2168 */ public int NumDeathQuotes;
        /* 0x2170 */ public NMSString0x10 ShowStatWithDeathQuote;
        /* 0x2180 */ public bool EnableKanaConversion;
        /* 0x2184 */ public float HUDDisplayTime;
        /* 0x2188 */ public float HUDPlayerTrackDangerPulse;
        /* 0x218C */ public float HUDPlayerTrackArrowTextOffset;
        /* 0x2190 */ public float HUDPlayerTrackArrowTextHeight;
        /* 0x21A0 */ public Colour HUDPlayerTrackArrowTextColour;
        /* 0x21B0 */ public float HUDPlayerTrackArrowHealthOffset;
        /* 0x21B4 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        /* 0x21C0 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        /* 0x21D0 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        /* 0x21E0 */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        /* 0x21E4 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        /* 0x21E8 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        /* 0x21F0 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        /* 0x21F4 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        /* 0x21F8 */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        /* 0x2200 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        /* 0x2210 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        /* 0x2220 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        /* 0x2224 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        /* 0x2230 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        /* 0x2240 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        /* 0x2250 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        /* 0x2254 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        /* 0x225C */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        /* 0x2260 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        /* 0x2268 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        /* 0x226C */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        /* 0x2270 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        /* 0x2280 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        /* 0x2290 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        /* 0x22A0 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        /* 0x22A4 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        /* 0x22A8 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        /* 0x22B0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        /* 0x22C0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        /* 0x22D0 */ public float HUDPlayerTrackArrowTargetDistShip;
        /* 0x22D4 */ public float HUDPlayerTrackArrowTargetDist;
        /* 0x22D8 */ public float HUDPlayerTrackArrowOffset;
        /* 0x22DC */ public float HUDPlayerTrackArrowScreenBorder;
        /* 0x22E0 */ public float HUDPlayerTrackArrowSize;
        /* 0x22E4 */ public float HUDPlayerTrackArrowSizeMin;
        /* 0x22E8 */ public float HUDPlayerTrackArrowSizeMax;
        /* 0x22EC */ public float HUDPlayerTrackArrowIconSize;
        /* 0x22F0 */ public float HUDPlayerTrackArrowSmallIconSize;
        /* 0x22F4 */ public float HUDPlayerTrackArrowArrowSize;
        /* 0x22F8 */ public float HUDPlayerTrackArrowDotSize;
        /* 0x2300 */ public Colour HUDPlayerTrackArrowDotColour;
        /* 0x2310 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        /* 0x2320 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        /* 0x2330 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        /* 0x2340 */ public Colour HUDWarningColour;
        /* 0x2350 */ public Colour HUDNotifyColour;
        /* 0x2360 */ public float HUDPlayerTrackArrowMinFadeDist;
        /* 0x2364 */ public float HUDPlayerTrackArrowFadeRange;
        // size: 0x4
        public enum SystemHooverLEDColoursEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(SystemHooverLEDColoursEnum))]
        /* 0x2370 */ public Colour[] SystemHooverLEDColours;
        // size: 0x4
        public enum SystemHooverStatusBarColoursEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(SystemHooverStatusBarColoursEnum))]
        /* 0x23B0 */ public Colour[] SystemHooverStatusBarColours;
        /* 0x23F0 */ public float GalaxyMapRadialBorder;
        /* 0x23F4 */ public float GalaxyMapRadialTargetDist;
        /* 0x23F8 */ public float IconBackgroundAlpha;
        /* 0x23FC */ public float WantedLevelWitnessPulseRate;
        /* 0x2400 */ public float WantedLevelWitnessOffset;
        /* 0x2404 */ public float WantedLevelTimeoutPulseRate;
        /* 0x2408 */ public float WantedLevelWitnessAlpha;
        /* 0x240C */ public float WantedLevelScanAlpha;
        /* 0x2410 */ public float WantedLevelScannedRate;
        /* 0x2418 */ public List<NMSString0x80> StatIcons;
        /* 0x2428 */ public bool ShowJetpackNotificationForNonTerrain;
        /* 0x242C */ public float StatsMessageDelayTime;
        /* 0x2430 */ public float SeasonMessageDelayTime;
        /* 0x2434 */ public bool HideExtremePlanetNotifications;
        /* 0x2438 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        /* 0x243C */ public float NotificationBackgroundGradientAlphaInShip;
        /* 0x2440 */ public int NotificationsResourceExtractHintCount;
        /* 0x2444 */ public float NotificationStaminaHintDistanceWalked;
        /* 0x2448 */ public float NotificationMinVisibleTime;
        /* 0x244C */ public float NotificationHazardSafeThreshold;
        /* 0x2450 */ public float NotificationHazardTimer;
        /* 0x2454 */ public float NotificationInteractHintStartTime;
        /* 0x2458 */ public float NotificationBuildHintStartTime;
        /* 0x245C */ public float NotificationJetpackTime;
        /* 0x2460 */ public float NotificationShieldTime;
        /* 0x2464 */ public float NotificationShipBoostTime;
        /* 0x2468 */ public float NotificationShipBoostTimeVR;
        /* 0x246C */ public float NotificationCantFireTime;
        /* 0x2470 */ public float NotificationDangerTime;
        /* 0x2474 */ public float NotificationScanTime;
        /* 0x2478 */ public float NotificationScanTimeCutoff;
        /* 0x247C */ public float NotificationMessageCycleTime;
        /* 0x2480 */ public float NotificationMaxPageHintTime;
        /* 0x2484 */ public float NotificationShipJumpMinTime;
        /* 0x2488 */ public float NotificationShipJumpReminderTime;
        /* 0x248C */ public float NotificationShipJumpReminderTutorial;
        /* 0x2490 */ public float NotificationShipBoostMinTime;
        /* 0x2494 */ public float NotificationShipBoostReminderTime;
        /* 0x2498 */ public float NotificationShipBoostReminderTimeTutorial;
        /* 0x249C */ public float LandNotifySpeedThreshold;
        /* 0x24A0 */ public float LandNotifyHeightThreshold;
        /* 0x24A4 */ public float LandNotifyTimeThreshold;
        /* 0x24A8 */ public float NotificationTimeBeforeHeridiumMarker;
        /* 0x24AC */ public float NotificationUrgentMessageTime;
        /* 0x24B0 */ public float NotificationGoToSpaceStationWait;
        /* 0x24B4 */ public float NotificationMonolithMissionWait;
        /* 0x24B8 */ public float NotificationFinalMissionWait;
        /* 0x24BC */ public float NotificationWaypointReachDistance;
        /* 0x24C0 */ public float NotificationBridgeReachDistance;
        /* 0x24C4 */ public float NotificationDiscoveryIdleTime;
        /* 0x24C8 */ public float NotificationInfoIdleTime;
        /* 0x24CC */ public float NotificationNewTechIdleTime;
        /* 0x24D0 */ public float NotificationScanEventMissionIdleTime;
        /* 0x24D4 */ public float NotificationDeviceIdleTime;
        /* 0x24D8 */ public float NotificationMissionHintTime;
        /* 0x24DC */ public float NotificationMissionHintTimeCritical;
        /* 0x24E0 */ public float NotificationMissionHintTimeSecondary;
        /* 0x24E4 */ public Vector2f NotificationMissionHintPauseTime;
        /* 0x24EC */ public Vector2f NotificationMissionHintPauseTimeCritical;
        /* 0x24F4 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        /* 0x24FC */ public float TooltipTime;
        /* 0x2500 */ public float InventoryIconTime;
        /* 0x2504 */ public float MessageNotificationTime;
        /* 0x2508 */ public float MessageTimeQuick;
        /* 0x250C */ public float ItemReceivedMessageTimeToAdd;
        /* 0x2510 */ public float DeathMessageSwitchTime;
        /* 0x2514 */ public float DeathMessageTotalTime;
        /* 0x2520 */ public Colour DeathMessageColour;
        /* 0x2530 */ public Colour PinnedRecipeBorder;
        /* 0x2540 */ public NMSString0x20 DistanceUnitM;
        /* 0x2560 */ public NMSString0x20 DistanceUnitKM;
        /* 0x2580 */ public NMSString0x20 DistanceUnitMpS;
        /* 0x25A0 */ public float ZoomHUDElementsOffsetX;
        /* 0x25A4 */ public float ZoomHUDElementsOffsetY;
        /* 0x25A8 */ public float ZoomHUDElementTime;
        /* 0x25AC */ public float HUDElementsOffsetHMDSide;
        /* 0x25B0 */ public float HUDElementsOffsetHMDTop;
        /* 0x25B4 */ public float HUDElementsOffsetHMDBottom;
        /* 0x25B8 */ public float HUDElementsOffsetX_0;
        /* 0x25BC */ public float HUDElementsOffsetY_0;
        /* 0x25C0 */ public float HUDElementsOffsetX_1;
        /* 0x25C4 */ public float HUDElementsOffsetY_1;
        /* 0x25C8 */ public float HUDElementsOffsetX_2;
        /* 0x25CC */ public float HUDElementsOffsetY_2;
        /* 0x25D0 */ public float HUDElementsOffsetX_3;
        /* 0x25D4 */ public float HUDElementsOffsetY_3;
        /* 0x25D8 */ public float HUDElementsOffsetX_4;
        /* 0x25DC */ public float HUDElementsOffsetY_4;
        /* 0x25E0 */ public float HUDElementsOffsetX_5;
        /* 0x25E4 */ public float HUDElementsOffsetY_5;
        /* 0x25E8 */ public GcWorldUISettings WorldUISettings;
        /* 0x261C */ public float PauseMenuHoldTime;
        /* 0x2620 */ public Vector2f PlanetLabelOffset;
        /* 0x2628 */ public Vector2f PlanetMeasureOffset;
        /* 0x2630 */ public Vector2f PlanetLineOffset;
        /* 0x2638 */ public float PlanetLabelTime;
        /* 0x263C */ public float PlanetLabelAngle;
        /* 0x2640 */ public Colour ItemSlotColourSubstance;
        /* 0x2650 */ public Colour ItemSlotColourTech;
        /* 0x2660 */ public Colour ItemSlotColourTechCharge;
        /* 0x2670 */ public Colour ItemSlotColourTechDamage;
        /* 0x2680 */ public Colour ItemSlotColourPartiallyInstalled;
        /* 0x2690 */ public float ItemSlotColourTechChargeRate;
        /* 0x26A0 */ public Colour ItemSlotColourProduct;
        /* 0x26B0 */ public Colour ItemSlotTextColourSubstance;
        /* 0x26C0 */ public Colour ItemSlotTextColourTech;
        /* 0x26D0 */ public Colour ItemSlotTextColourProduct;
        /* 0x26E0 */ public float InteractionScanScanTime;
        /* 0x26E4 */ public float InteractionScanMinTime;
        /* 0x26E8 */ public float InteractionScanDisplayTime;
        /* 0x26EC */ public float InteractionScanSlapTime;
        /* 0x26F0 */ public float InteractionScanSlapScale;
        /* 0x26F4 */ public float InteractionScanSlapOverallTime;
        /* 0x26F8 */ public TkCurveType InteractionScanSlapCurve;
        /* 0x26FC */ public float ShipHUDMissileLockSizeMin;
        /* 0x2700 */ public float ShipHUDMissileLockSizeMax;
        /* 0x2704 */ public float ShipHUDMissileLockSpringSlow;
        /* 0x2708 */ public float ShipHUDMissileLockSpringFast;
        /* 0x270C */ public float ShipHUDMaxOffscreenTargetDist;
        /* 0x2710 */ public float ShipHUDTargetRadius;
        /* 0x2714 */ public float ShipHUDTargetTriangleRadius;
        /* 0x2718 */ public float ShipHUDTargetAlpha;
        /* 0x271C */ public float ShipHUDTargetArrowLength;
        /* 0x2720 */ public float ShipHUDTargetMinDist;
        /* 0x2724 */ public float ShipHUDTargetRange;
        /* 0x2728 */ public float ShipHUDTargetScale;
        /* 0x272C */ public float ShipHUDTargetArrowsRotationRate;
        /* 0x2730 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        /* 0x2740 */ public Colour ShipHUDTargetArrowsColourThreat;
        /* 0x2750 */ public Colour ShipHUDTargetArrowsColourLocal;
        /* 0x2760 */ public List<Colour> ShipHUDTargetArrowsColour;
        /* 0x2770 */ public Colour ShipHUDAimTargetColour;
        /* 0x2780 */ public Colour ShipHUDAimTargetCritColour;
        /* 0x2790 */ public float ShipHUDHitPointTime;
        /* 0x2794 */ public float ShipHUDHitPointSize;
        /* 0x2798 */ public float TargetScreenFoV;
        /* 0x279C */ public float TargetScreenDistance;
        /* 0x27A0 */ public Vector2f TargetScreenCamOffset;
        /* 0x27A8 */ public float InventoryFullMessageRepeatTime;
        /* 0x27AC */ public float HoldTimerResetTime;
        /* 0x27B0 */ public bool ModelRendererBGPass;
        /* 0x27B1 */ public bool ModelRendererPass1;
        /* 0x27B2 */ public bool ModelRendererPass2;
        /* 0x27B4 */ public float HazardScreenEffectPulseRate;
        /* 0x27B8 */ public float KeepHazardBarActiveTime;
        /* 0x27BC */ public float KeepSecondHazardBarActiveTime;
        /* 0x27C0 */ public float HazardBarPulseTime;
        /* 0x27C4 */ public float HazardScreenEffectPulseTime;
        /* 0x27C8 */ public float HazardScreenEffectStrength;
        /* 0x27CC */ public float HazardWarningPulseTime;
        /* 0x27D0 */ public float HazardWarningPulseStrength;
        /* 0x27D4 */ public float HazardPainPulseStrength;
        /* 0x27D8 */ public float ShieldSpringTime;
        /* 0x27DC */ public float ShieldPulseTime;
        /* 0x27E0 */ public float ShieldHazardPulseRate;
        /* 0x27E4 */ public bool ShieldHUDAlwaysOn;
        /* 0x27E8 */ public float ShieldHazardPulseThreshold;
        /* 0x27EC */ public float AlwaysOnHazardThreshold;
        /* 0x27F0 */ public float AlwaysOnHazardStrengthTox;
        /* 0x27F4 */ public float AlwaysOnHazardStrengthHeat;
        /* 0x27F8 */ public float AlwaysOnHazardStrengthRad;
        /* 0x27FC */ public float AlwaysOnHazardStrengthCold;
        /* 0x2800 */ public float AlwaysOnHazardMultiplierTox;
        /* 0x2804 */ public float AlwaysOnHazardMultiplierHeat;
        /* 0x2808 */ public float AlwaysOnHazardMultiplierRad;
        /* 0x280C */ public float AlwaysOnHazardMultiplierCold;
        /* 0x2810 */ public float HazardPulseRate;
        /* 0x2818 */ public List<NMSString0x80> HazardTextures;
        /* 0x2828 */ public List<NMSString0x80> HazardNormalMaps;
        /* 0x2838 */ public List<NMSString0x80> HazardHeightmaps;
        /* 0x2848 */ public NMSString0x80 CamoTexture;
        /* 0x28C8 */ public NMSString0x80 CamoNormalTexture;
        /* 0x2948 */ public float IconPulseRate;
        /* 0x2950 */ public Colour EnergyBgColour;
        /* 0x2960 */ public Colour EnergyBgPulseColour;
        /* 0x2970 */ public Colour HazardBgPulseColour;
        /* 0x2980 */ public Colour HazardDamagePulseColour;
        /* 0x2990 */ public Colour ShieldColour;
        /* 0x29A0 */ public Colour ShieldDamageColour;
        /* 0x29B0 */ public Colour ShieldBgColour;
        /* 0x29C0 */ public Colour ShieldDamageBgColour;
        /* 0x29D0 */ public Vector2f ScanLabelOffset;
        /* 0x29D8 */ public Vector2f InteractionLabelOffset;
        /* 0x29E0 */ public Vector2f InteractionLabelOffset_1;
        /* 0x29E8 */ public Vector2f InteractionLabelSize;
        /* 0x29F0 */ public Vector2f InteractionLabelLineOffset;
        /* 0x29F8 */ public float InteractionLabelRadiusScaler;
        /* 0x29FC */ public float InteractionLabelHeight;
        /* 0x2A00 */ public float InteractionLabelLineAlpha;
        /* 0x2A04 */ public float InteractionIconInnerRadius;
        /* 0x2A08 */ public float InteractionIconOuterRadius;
        /* 0x2A0C */ public float InteractionLabelPixelHeightMin;
        /* 0x2A10 */ public float InteractionLabelPixelHeightMax;
        /* 0x2A14 */ public float ScanTime;
        /* 0x2A20 */ public GcModelViewCollection ModelViews;
        /* 0x40D0 */ public Colour CursorColour;
        /* 0x40E0 */ public Colour CursorConfirmColour;
        /* 0x40F0 */ public Colour CursorTransferUploadColour;
        /* 0x4100 */ public Colour CursorDeleteColour;
        /* 0x4110 */ public float CursorHoverSlowFactor;
        /* 0x4114 */ public float CursorHoverSlowFactorMin;
        /* 0x4118 */ public float FrontendBGAlpha;
        /* 0x411C */ public float FrontendConfirmTimeMouseMultiplier;
        /* 0x4120 */ public float FrontendConfirmTimeFast;
        /* 0x4124 */ public float FrontendTouchConfirmTimeFastMultiplier;
        /* 0x4128 */ public float FrontendConfirmTime;
        /* 0x412C */ public float FrontendConfirmTimeSlow;
        /* 0x4130 */ public TkCurveType FrontendConfirmCurve;
        /* 0x4134 */ public float FrontendCursorSize;
        /* 0x4138 */ public float FrontendCursorOffset;
        /* 0x413C */ public float PopupXClampOffset;
        /* 0x4140 */ public float PopupXClampOffsetRightAligned;
        /* 0x4144 */ public float PopupSlotWidthOffset;
        /* 0x4148 */ public float FrontendCursorWidth;
        /* 0x414C */ public float FrontendDeactivateTime;
        /* 0x4150 */ public float FrontendDeactivateSplit;
        /* 0x4154 */ public float FrontendActivateTime;
        /* 0x4158 */ public float FrontendActivateSplit;
        /* 0x415C */ public float FrontendStatCircleWidth;
        /* 0x4160 */ public float FrontendStatCircleWidthExtra;
        /* 0x4164 */ public float FrontendBootTime;
        /* 0x4168 */ public float FrontendBootBarTime;
        /* 0x416C */ public TkCurveType FrontendBootBarCurve;
        /* 0x4170 */ public float PopupDebounceTime;
        /* 0x4174 */ public float PopupActivateTime;
        /* 0x4178 */ public float PopupDeactivateTime;
        /* 0x417C */ public TkCurveType PopupActivateCurve1;
        /* 0x4180 */ public TkCurveType PopupActivateCurve2;
        /* 0x4184 */ public float ByteBeatTreeLineWidth;
        /* 0x4190 */ public Colour ByteBeatTreeLineColour;
        /* 0x41A0 */ public float ByteBeatVisLineWidth;
        /* 0x41B0 */ public Colour ByteBeatVisLineColour;
        /* 0x41C0 */ public Colour ByteBeatVisGridColour;
        /* 0x41D0 */ public float ByteBeatIconLineWidth;
        /* 0x41D4 */ public float ByteBeatIconPad;
        /* 0x41D8 */ public float ByteBeatArpLineWidth;
        /* 0x41DC */ public float ByteBeatArpRadius;
        /* 0x41E0 */ public float ByteBeatArpPad;
        /* 0x41F0 */ public Colour ByteBeatArpGridInactiveColour;
        /* 0x4200 */ public Colour ByteBeatArpGridActiveColour;
        /* 0x4210 */ public Colour ByteBeatArpPipInactiveColour;
        /* 0x4220 */ public Colour ByteBeatArpPipActiveColour;
        /* 0x4230 */ public float ByteBeatSequencerLineWidth;
        /* 0x4234 */ public float ByteBeatSequencerPad;
        /* 0x4238 */ public float ByteBeatPartSequencerPad;
        /* 0x423C */ public float ByteBeatSequencerCornerRadius;
        /* 0x4240 */ public float ByteBeatRhythmBeatPad;
        /* 0x4244 */ public float ByteBeatSequencerInactiveSaturation;
        /* 0x4248 */ public float ByteBeatSequencerActiveSaturation;
        /* 0x424C */ public float ByteBeatRhythmSequencerInactiveSaturation;
        /* 0x4250 */ public float ByteBeatRhythmSequencerActiveSaturation;
        /* 0x4254 */ public float ByteBeatSequencerUnpoweredTintStrength;
        /* 0x4260 */ public Colour ByteBeatSequencerUnpoweredTint;
        /* 0x4270 */ public Colour ByteBeatSequencerBGColourActive;
        /* 0x4280 */ public Colour ByteBeatSequencerBGColourInactive;
        /* 0x4290 */ public Colour ByteBeatSequencerRimColourActive;
        /* 0x42A0 */ public Colour ByteBeatSequencerRimColourInactive;
        /* 0x42B0 */ public Colour ByteBeatRhythmColour0Active;
        /* 0x42C0 */ public Colour ByteBeatRhythmColour0Inactive;
        /* 0x42D0 */ public Colour ByteBeatRhythmColour1Active;
        /* 0x42E0 */ public Colour ByteBeatRhythmColour1Inactive;
        /* 0x42F0 */ public Colour ByteBeatRhythmColour2Active;
        /* 0x4300 */ public Colour ByteBeatRhythmColour2Inactive;
        /* 0x4310 */ public Colour ByteBeatSequencerHighlightColour;
        /* 0x4320 */ public float ByteBeatSequencerHighlightLineWidth;
        /* 0x4324 */ public float ByteBeatSliderLineWidth;
        /* 0x4328 */ public float ByteBeatSliderPad;
        /* 0x432C */ public float ByteBeatSliderCornerRadius;
        /* 0x4330 */ public Colour ByteBeatSliderFGColour;
        /* 0x4340 */ public Colour ByteBeatSliderTextActiveColour;
        /* 0x4350 */ public Colour ByteBeatSliderTextInactiveColour;
        /* 0x4360 */ public float ByteBeatSwitchPanelAlpha;
        /* 0x4364 */ public float ByteBeatSwitchPanelSplit;
        /* 0x4370 */ public Colour RadialMenuInnerColourSelected;
        /* 0x4380 */ public Colour RadialMenuOuterColourSelected;
        /* 0x4390 */ public Colour RadialMenuInnerColourUnselected;
        /* 0x43A0 */ public Colour RadialMenuOuterColourUnselected;
        /* 0x43B0 */ public Colour RadialMenuInnerColourDisabled;
        /* 0x43C0 */ public Colour RadialMenuOuterColourDisabled;
        /* 0x43D0 */ public float RadialMenuInnerRadius;
        /* 0x43D4 */ public float RadialMenuInnerRadiusCursor;
        /* 0x43D8 */ public float RadialMenuWedgeOffset;
        /* 0x43DC */ public float HatchPulseSpeed;
        /* 0x43E0 */ public float HatchPulseWidth;
        /* 0x43E4 */ public float HatchPulsePauseTime;
        /* 0x43E8 */ public int HatchCount;
        /* 0x43EC */ public float HatchCursorRadius;
        /* 0x43F0 */ public float HatchAlphaMain;
        /* 0x43F4 */ public float HatchAlphaBase;
        /* 0x43F8 */ public float HatchAlphaCursor;
        /* 0x43FC */ public float FrontendDoFNearPlaneMin;
        /* 0x4400 */ public float FrontendDoFNearPlaneMax;
        /* 0x4404 */ public float FrontendDoFFarPlaneMin;
        /* 0x4408 */ public float FrontendDoFFarPlaneMax;
        /* 0x440C */ public float FrontendDoFFarPlaneFadeMin;
        /* 0x4410 */ public float FrontendDoFFarPlaneFadeMax;
        /* 0x4414 */ public float FrontendDoFBlurMultiplier;
        /* 0x4418 */ public bool FrontendDoFEnableBokeh;
        /* 0x441C */ public TkCurveType FrontendDoFCurve;
        /* 0x4420 */ public float FrontendShineSpeed;
        /* 0x4424 */ public float FrontendToolbarTextHeight;
        /* 0x4428 */ public float FrontendToolbarTextHeightSelected;
        /* 0x442C */ public float FrontendTitleFontSpacing;
        /* 0x4430 */ public float NGuiPadSensitivity;
        /* 0x4434 */ public float NGuiMouseSensitivity;
        /* 0x4438 */ public Vector2f NGuiTouchPadSensitivity;
        /* 0x4440 */ public Colour TargetMarkerColour;
        /* 0x4450 */ public Colour TargetMarkerHighlightColour;
        /* 0x4460 */ public float TargetMarkerScaleStart;
        /* 0x4464 */ public float TargetMarkerScaleEnd;
        /* 0x4468 */ public float TargetMarkerFadeAngleMin;
        /* 0x446C */ public float TargetMarkerFadeAngleRange;
        /* 0x4470 */ public float HitMarkerPulseSize;
        /* 0x4474 */ public float HitMarkerPulseSizeStatic;
        /* 0x4478 */ public float HitMarkerPulseTime;
        /* 0x4480 */ public Colour WantedColour;
        /* 0x4490 */ public Colour UnseenItemColour;
        /* 0x44A0 */ public float PlanetPoleMaxDotProduct;
        /* 0x44A4 */ public float SpaceMapLineWidth;
        /* 0x44A8 */ public float SpaceMapLineBaseScale;
        /* 0x44AC */ public float SpaceMapLineBaseFade;
        /* 0x44B0 */ public float SpaceMapShipCombineDistance;
        /* 0x44B4 */ public bool SpaceMapShowPlanets;
        /* 0x44B5 */ public bool SpaceMapShowPlanetLines;
        /* 0x44B6 */ public bool SpaceMapShowStation;
        /* 0x44B7 */ public bool SpaceMapShowStationLines;
        /* 0x44B8 */ public bool SpaceMapShowAnomaly;
        /* 0x44B9 */ public bool SpaceMapShowAnomalyLines;
        /* 0x44BA */ public bool SpaceMapShowNexus;
        /* 0x44BB */ public bool SpaceMapShowNexusLines;
        /* 0x44BC */ public bool SpaceMapShowShips;
        /* 0x44BD */ public bool SpaceMapShowShipLines;
        /* 0x44BE */ public bool SpaceMapShowFrieghters;
        /* 0x44BF */ public bool SpaceMapShowFrieghterLines;
        /* 0x44C0 */ public bool SpaceMapShowPulseEncounters;
        /* 0x44C1 */ public bool SpaceMapShowPulseEncounterLines;
        /* 0x44C4 */ public float SpaceMapFoV;
        /* 0x44C8 */ public float SpaceMapAspectRatio;
        /* 0x44CC */ public float SpaceMapDistanceScale;
        /* 0x44D0 */ public float SpaceMapDistanceLogScaler;
        /* 0x44D4 */ public TkCurveType SpaceMapDistanceCurve;
        /* 0x44D8 */ public float SpaceMapScaleMin;
        /* 0x44DC */ public float SpaceMapScaleRangeMin;
        /* 0x44E0 */ public float SpaceMapScaleRangeMax;
        /* 0x44E4 */ public float SpaceMapObjectScale;
        /* 0x44E8 */ public float SpaceMapFreighterScale;
        /* 0x44EC */ public float SpaceMapStationScale;
        /* 0x44F0 */ public float SpaceMapAnomalyScale;
        /* 0x44F4 */ public float SpaceMapPlanetScale;
        /* 0x44F8 */ public float SpaceMapPlanetLineOffset;
        /* 0x44FC */ public float SpaceMapMoonScale;
        /* 0x4500 */ public float SpaceMapActionScale;
        /* 0x4504 */ public float SpaceMapShipScale;
        /* 0x4508 */ public float SpaceMapMarkerScale;
        /* 0x450C */ public float SpaceMapDistance;
        /* 0x4510 */ public float SpaceMapMaxTraderDistance;
        /* 0x4514 */ public float SpaceMapDistanceMultiplier;
        /* 0x4518 */ public float SpaceMapHorizonThickness;
        /* 0x451C */ public float SpaceMapFadeAngleMin;
        /* 0x4520 */ public float SpaceMapFadeAngleMax;
        /* 0x4524 */ public float SpaceMapCamHeight;
        /* 0x4528 */ public float SpaceMapCamAngle;
        /* 0x452C */ public float SpaceMapCamDistance;
        /* 0x4530 */ public float SpaceMapShipScaleMin;
        /* 0x4534 */ public float SpaceMapLightPitch;
        /* 0x4538 */ public float SpaceMapLightYaw;
        /* 0x4540 */ public Colour SpaceFriendlyShipLineColour;
        /* 0x4550 */ public Colour SpaceEnemyShipLineColour;
        /* 0x4560 */ public Vector3f SpaceMapPosScaler;
        /* 0x4570 */ public Colour SpaceMapAttackColour;
        /* 0x4580 */ public Colour SpaceMapOtherPlayerColour;
        /* 0x4590 */ public Colour SpaceMapThreatColour;
        /* 0x45A0 */ public Colour SpaceMapNeutralColour;
        /* 0x45B0 */ public Colour SpaceMapSquadronColour;
        /* 0x45C0 */ public Colour SpaceMapDeathPointColour;
        /* 0x45D0 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        /* 0x4600 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        /* 0x4630 */ public GcSpaceMapObjectData SpaceMapStationData;
        /* 0x4660 */ public GcSpaceMapObjectData SpaceMapNexusData;
        /* 0x4690 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        /* 0x46C0 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        /* 0x46F0 */ public GcSpaceMapObjectData SpaceMapShipData;
        /* 0x4720 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        /* 0x4750 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        /* 0x4780 */ public Vector2f HUDTargetHealthOffset;
        /* 0x4788 */ public Vector2f HUDTargetHealthSize;
        /* 0x4790 */ public Vector2f HUDTargetHealthIconOffset;
        /* 0x4798 */ public float HUDTargetHealthIconSize;
        /* 0x479C */ public float HUDTargetHealthDangerTime;
        /* 0x47A0 */ public float HUDTargetMarkerOffset;
        /* 0x47A4 */ public float HUDTargetMarkerSize;
        /* 0x47A8 */ public float HUDTargetIconOffset;
        /* 0x47AC */ public float HUDTargetIconSize;
        /* 0x47B0 */ public float HUDMarkerOffset;
        /* 0x47C0 */ public Colour HUDMarkerColour;
        /* 0x47D0 */ public Colour HUDSpaceshipColour;
        /* 0x47E0 */ public Colour HUDRelicMarkerColourDiscovered;
        /* 0x47F0 */ public Colour HUDRelicMarkerColourUnknown;
        /* 0x4800 */ public Colour HUDOutpostColour;
        /* 0x4810 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        /* 0x4818 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        /* 0x4820 */ public NMSString0x100 HUDMarkerIcon;
        /* 0x4920 */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        /* 0x4A20 */ public NMSString0x100 HUDMarkerColourIcon;
        /* 0x4B20 */ public NMSString0x100 HUDPointIcon;
        /* 0x4C20 */ public NMSString0x100 HUDSpaceshipIcon;
        /* 0x4D20 */ public NMSString0x100 HUDSaveIcon;
        /* 0x4E20 */ public NMSString0x100 HUDDeathPointIcon;
        /* 0x4F20 */ public NMSString0x100 HUDHexAnimIcon;
        /* 0x5020 */ public NMSString0x100 HUDCircleAnimIcon;
        /* 0x5120 */ public float HUDMarkerAnimSpeed;
        /* 0x5124 */ public float HUDMarkerAnimScale;
        /* 0x5128 */ public float HUDMarkerAnimOffset;
        /* 0x512C */ public float HUDMarkerAnimLoopTime;
        /* 0x5130 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        /* 0x5134 */ public TkCurveType HUDMarkerAnimCurve;
        /* 0x5138 */ public float HUDMarkerPrimaryIndicatorSize;
        /* 0x513C */ public float HUDPetMarkerAngleTest;
        /* 0x5140 */ public float HUDMarkerHoverAngleTestGround;
        /* 0x5144 */ public float HUDPetCentreScreenAngle;
        /* 0x5148 */ public float HUDNetworkMarkerHoverAngleTestGround;
        /* 0x514C */ public float HUDMarkerWideHoverAngleTest;
        /* 0x5150 */ public float HUDMarkerHoverAngleTestShip;
        /* 0x5154 */ public float HUDMarkerHoverShowLargeAngleTest;
        /* 0x5158 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        /* 0x515C */ public float HUDMarkerShipOffsetMaxDist;
        /* 0x5160 */ public float HUDMarkerShipOffsetMinDist;
        /* 0x5164 */ public float HUDMarkerNearFadeDistance;
        /* 0x5168 */ public float HUDMarkerNearFadeRange;
        /* 0x516C */ public float HUDMarkerFarDistance;
        /* 0x5170 */ public float HUDMarkerFarFadeRange;
        /* 0x5174 */ public float HUDMarkerScalerMin;
        /* 0x5178 */ public float HUDMarkerScalerRange;
        /* 0x517C */ public float HUDMarkerScalerSizeMin;
        /* 0x5180 */ public float HUDMarkerScalerSizeMax;
        /* 0x5184 */ public float HUDMarkerHorizonBlendRange;
        /* 0x5188 */ public float HUDMarkerAlpha;
        /* 0x518C */ public float HUDMarkerModelFadeRange;
        /* 0x5190 */ public float HUDMarkerModelFadeMinHeight;
        /* 0x5194 */ public float HUDMarkerShowActualIconDistance;
        /* 0x5198 */ public float HUDMarkerShowActualSpaceIconDistance;
        /* 0x519C */ public float HUDMarkerActiveTime;
        /* 0x51A0 */ public TkCurveType HUDMarkerActiveCurve;
        /* 0x51A4 */ public float HUDMarkerIconHoverMinScale;
        /* 0x51A8 */ public float AltimeterResolution;
        /* 0x51AC */ public float AltimeterLineSpacing;
        /* 0x51B0 */ public float AltimeterWidth;
        /* 0x51B4 */ public float AltimeterMin;
        /* 0x51B8 */ public float AltimeterMax;
        /* 0x51BC */ public float AltimeterTextSize;
        /* 0x51C0 */ public float AltimeterMinValue;
        /* 0x51D0 */ public Colour AltimeterBandColour1;
        /* 0x51E0 */ public Colour AltimeterBandColour2;
        /* 0x51F0 */ public Colour AltimeterColour1;
        /* 0x5200 */ public Colour AltimeterColour2;
        /* 0x5210 */ public float LockOnMarkerSize;
        /* 0x5214 */ public float LockOnMarkerSizeLock;
        /* 0x5220 */ public Colour LockOnMarkerActiveColour;
        /* 0x5230 */ public float AsteroidMarkerMinDisplayDistance;
        /* 0x5234 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        /* 0x5238 */ public float MissileIconAttackPulseTime;
        /* 0x523C */ public float MissileIconAttackPulseAmount;
        /* 0x5240 */ public float NGuiModelRotationDegreesX;
        /* 0x5244 */ public float NGuiModelRotationDegreesY;
        /* 0x5248 */ public float NGuiModelRotationDegreesZ;
        /* 0x524C */ public float NGuiModelViewDistanceGlobal;
        /* 0x5250 */ public float NGuiModelViewDistanceSuitPage;
        /* 0x5254 */ public float NGuiModelViewDistanceWeaponPage;
        /* 0x5258 */ public float NGuiModelViewDistanceShipPage;
        /* 0x525C */ public float NGuiModelViewDistanceDiscoveryPage;
        /* 0x5260 */ public float NGuiModelViewFov;
        /* 0x5264 */ public float NGuiModelViewCdSmoothTime;
        /* 0x5268 */ public float NGuiAltPlacementDistanceScrollSpeed;
        /* 0x526C */ public float NGuiPlacementAngleScrollSpeed;
        /* 0x5270 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        /* 0x5280 */ public Vector3f NGuiModelTranslationFactors;
        /* 0x5290 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        /* 0x52A0 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        /* 0x52B0 */ public float NGuiThumbnailModelRotationDegreesY;
        /* 0x52B4 */ public float NGuiThumbnailModelViewDistance;
        /* 0x52B8 */ public float NGuiCursorOffsetMultiplier;
        /* 0x52BC */ public float NGuiActiveAreaOffsetTime;
        /* 0x52C0 */ public Vector2f NGuiMin2DParallax;
        /* 0x52C8 */ public Vector2f NGuiMax2DParallax;
        /* 0x52D0 */ public Vector2f NGuiModelParallax;
        /* 0x52D8 */ public Vector2f NGuiShipInteractParallax;
        /* 0x52E0 */ public Vector2f InteractionWorldParallax;
        /* 0x52E8 */ public float TargetParallaxMouseMultiplier;
        /* 0x52EC */ public float TargetParallaxMaintenancePageMultiplier;
        /* 0x52F0 */ public float NGuiModelViewFadeInAfterRenderTime;
        /* 0x52F4 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        /* 0x52F8 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        /* 0x52FC */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        /* 0x5308 */ public GcHUDStartupTable IntroTiming;
        /* 0x5458 */ public GcHUDStartupTable IntroTimingFreighter;
        /* 0x55A8 */ public GcInventorySlotActionData InstallTechSlotAction;
        /* 0x55C4 */ public GcInventorySlotActionData BuildProductSlotAction;
        /* 0x55E0 */ public GcInventorySlotActionData ChargeSlotAction;
        /* 0x55FC */ public GcInventorySlotActionData RepairSlotAction;
        /* 0x5618 */ public GcInventorySlotActionData NewSlotRevealAction;
        /* 0x5634 */ public GcInventorySlotActionData NewSlotPulseAction;
        /* 0x5650 */ public GcInventorySlotActionData InventoryHintAction;
        /* 0x566C */ public float ReportBaseFlashTime;
        /* 0x5670 */ public float ReportBaseFlashIntensity;
        /* 0x5674 */ public float ReportBaseFlashDelay;
        /* 0x5678 */ public int ReportBaseTexWidth;
        /* 0x567C */ public int ReportBaseTexHeight;
        /* 0x5680 */ public float ReportCameraSpeed;
        /* 0x5684 */ public float AmbientModeFadeTime;
        /* 0x5688 */ public bool HideQuickMenuControls;
        /* 0x5689 */ public bool QuickMenuAllowCycle;
        /* 0x568C */ public float TextChatMaxDisplayTime;
        /* 0x5690 */ public float TextChatStayBigAfterTextInput;
        /* 0x5694 */ public int BuildingShopMaxItems;
        /* 0x5698 */ public float ShipScreenTexScale;
        /* 0x569C */ public float MultiplayerTeleportEffectDisappearTime;
        /* 0x56A0 */ public float MultiplayerTeleportEffectAppearTime;
        /* 0x56A4 */ public int AbandonedFreighterAirlockRoomNumber;
        /* 0x56A8 */ public float SettlementStatInnerRadius;
        /* 0x56AC */ public float SettlementStatOuterRadius;
        /* 0x56B0 */ public Colour SettlementStatColour;
        /* 0x56C0 */ public Colour SettlementStatBackgroundColour;
        // size: 0x7
        public enum SettlementStatLocEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatLocEnum))]
        /* 0x56D0 */ public NMSString0x20A[] SettlementStatLoc;
        // size: 0x7
        public enum SettlementStatFormatLocEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatFormatLocEnum))]
        /* 0x57B0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        // size: 0x7
        public enum SettlementStatBasicImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatBasicImagesEnum))]
        /* 0x5890 */ public TkTextureResource[] SettlementStatBasicImages;
        // size: 0x7
        public enum SettlementStatPositiveImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatPositiveImagesEnum))]
        /* 0x5C2C */ public TkTextureResource[] SettlementStatPositiveImages;
        // size: 0x7
        public enum SettlementStatNegativeImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatNegativeImagesEnum))]
        /* 0x5FC8 */ public TkTextureResource[] SettlementStatNegativeImages;
        /* 0x6364 */ public float MinimumHoldFill;
        /* 0x6368 */ public bool EnableAccessibleUI;
        /* 0x636C */ public float AccessibleUIPopupScale;
        /* 0x6370 */ public float DetailMessageDismissTime;
        /* 0x6374 */ public float TouchScrollMaxDelta;
        /* 0x6378 */ public float TextTouchScrollCap;
        /* 0x637C */ public float TouchScrollChangePageThreshold;
        /* 0x6380 */ public float ManualScrollChangePerInputMin;
        /* 0x6384 */ public float ManualScrollChangePerInputMax;
        /* 0x6388 */ public float InfoPortalGuideCycleTime;
        /* 0x638C */ public float InfoPortalMilestonesCycleTime;
        /* 0x6390 */ public float FeedFrigateAnimPeriod;
        /* 0x6394 */ public int FeedFrigateAnimNumPeriods;
        /* 0x6398 */ public float FeedFrigateAnimScaleChange;
        /* 0x639C */ public float FeedFrigateAnimAlphaChange;
    }
}
