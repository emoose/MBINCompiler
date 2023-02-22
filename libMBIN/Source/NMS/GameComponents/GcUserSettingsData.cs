using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6EFF7D6E5D8CCC5, NameHash = 0x3A50D683FD1CF4BF)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool InvertVRInWorldFlightControls;
        /* 0x0003 */ public bool VRVehiclesUseWorldControls;
        /* 0x0004 */ public bool HUDHidden;
        /* 0x0005 */ public bool Vibration;
        /* 0x0008 */ public int ScreenBrightness;
        /* 0x000C */ public int MusicVolume;
        /* 0x0010 */ public int SfxVolume;
        /* 0x0014 */ public int LookSensitivityMode1;
        /* 0x0018 */ public int LookSensitivityMode2;
        /* 0x001C */ public int FlightSensitivityMode1;
        /* 0x0020 */ public int FlightSensitivityMode2;
        /* 0x0024 */ public int CursorSensitivityMode1;
        /* 0x0028 */ public int CursorSensitivityMode2;
        /* 0x002C */ public int MouseSpringSmoothing;
        /* 0x0030 */ public GcBlockListPersistence BlockList;
        /* 0x3880 */ public int MotionBlurAmount;
        /* 0x3884 */ public int Filter;
        /* 0x3888 */ public bool DamageNumbers;
        // size: 0x3
        public enum PS4FixedFPSEnum {
            Invalid,
            False,
            True,
        }
        /* 0x388C */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x3890 */ public float PS4FOVFoot;
        /* 0x3894 */ public float PS4FOVShip;
        /* 0x3898 */ public bool XboxOneXHighResolutionMode;
        /* 0x3899 */ public bool PS4VignetteAndScanlines;
        // size: 0x3
        public enum BaseSharingModeEnum {
            Undecided,
            On,
            Off,
        }
        /* 0x389C */ public BaseSharingModeEnum BaseSharingMode;
        /* 0x38A0 */ public List<NMSString0x10> SeenSubstances;
        /* 0x38B0 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x38C0 */ public List<NMSString0x10> SeenProducts;
        /* 0x38D0 */ public List<NMSString0x20A> SeenWikiTopics;
        /* 0x38E0 */ public List<NMSString0x20A> UnlockedWikiTopics;
        /* 0x38F0 */ public List<NMSString0x10> UnlockedTitles;
        /* 0x3900 */ public List<NMSString0x10> UnlockedSpecials;
        /* 0x3910 */ public List<NMSString0x10> UnlockedSeasonRewards;
        /* 0x3920 */ public List<NMSString0x10> UnlockedTwitchRewards;
        /* 0x3930 */ public List<NMSString0x10> UnlockedPlatformRewards;
        /* 0x3940 */ public bool VoiceChat;
        /* 0x3941 */ public bool Multiplayer;
        /* 0x3942 */ public bool InstantUIInputs;
        /* 0x3943 */ public bool SpeechToText;
        /* 0x3944 */ public bool Translate;
        /* 0x3945 */ public bool CrossPlatform;
        // size: 0x4
        public enum TemperatureUnitEnum {
            Invalid,
            C,
            F,
            K,
        }
        /* 0x3948 */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x394C */ public bool UseOldMouseFlight;
        /* 0x3950 */ public int LastSeenCommunityMission;
        /* 0x3954 */ public int LastSeenCommunityMissionTier;
        // size: 0x2
        public enum MovementModeEnum {
            Teleporter,
            Smooth,
        }
        /* 0x3958 */ public MovementModeEnum MovementMode;
        /* 0x395C */ public GcMovementDirection MovementDirectionPad;
        /* 0x3960 */ public GcMovementDirection MovementDirectionHands;
        /* 0x3964 */ public bool EnableControllerCursorInVR;
        // size: 0x2
        public enum TurnModeEnum {
            Smooth,
            Snap,
        }
        /* 0x3968 */ public TurnModeEnum TurnMode;
        /* 0x396C */ public float VRVignetteStrength;
        /* 0x3970 */ public bool UseShipAutoControlVignette;
        /* 0x3974 */ public float HUDZoom;
        /* 0x3978 */ public float FrontendZoom;
        /* 0x397C */ public bool UseAutoTorch;
        // size: 0x4
        public enum UIColourSchemeEnum {
            Default,
            Protanopia,
            Deuteranopia,
            Tritanopia,
        }
        /* 0x3980 */ public UIColourSchemeEnum UIColourScheme;
        /* 0x3984 */ public bool EnableModdingConsole;
        /* 0x3985 */ public bool HeadBob;
        /* 0x3986 */ public bool VRHeadBob;
        /* 0x3987 */ public bool VRShowBody;
        /* 0x3988 */ public bool UseCharacterHeightForCamera;
        /* 0x3989 */ public bool BaseComplexityLimitsEnabled;
        /* 0x398A */ public bool EnableLargeLobbies;
        /* 0x398C */ public int FireteamSessionCount;
        /* 0x3990 */ public int HeadsetVibrationStrength;
        /* 0x3994 */ public int VibrationStrength;
        /* 0x3998 */ public int CamerShakeStrength;
        /* 0x399C */ public int TriggerFeedbackStrength;
        // size: 0x3
        public enum SpaceCombatFollowModeEnum {
            Disabled,
            Hold,
            Toggle,
        }
        /* 0x39A0 */ public SpaceCombatFollowModeEnum SpaceCombatFollowMode;
        /* 0x39A8 */ public List<NMSString0x80> UpgradedUsers;
        /* 0x39B8 */ public bool AllowWhiteScreenTransitions;
        /* 0x39B9 */ public bool AccessibleText;
        /* 0x39BA */ public bool AutoScanDiscoveries;
        /* 0x39BB */ public bool SprintScanSwap;
        /* 0x39BC */ public bool PlaceJumpSwap;
        // size: 0x4
        public enum EyeTrackingEnum {
            None,
            Both,
            Left,
            Right,
        }
        /* 0x39C0 */ public EyeTrackingEnum EyeTracking;
        /* 0x39C4 */ public GcGyroSettingsData GyroSettings;
        /* 0x3A48 */ public TkLanguages Language;
        /* 0x3A4C */ public bool AutoRotateThirdPersonPlayerCamera;
        /* 0x3A50 */ public GcHand DominantHand;
        /* 0x3A54 */ public float HazardEffectsStrength;
        /* 0x3A58 */ public bool QuickMenuBuildMenuSwap;
        // size: 0x2
        public enum HighResVRUIEnum {
            High,
            Low,
        }
        /* 0x3A5C */ public HighResVRUIEnum HighResVRUI;
        /* 0x3A60 */ public float PlayerHUDVROffset;
        /* 0x3A64 */ public float ShipHUDVROffset;
    }
}
