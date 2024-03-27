using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEB7C9677BE54349F, NameHash = 0xB62E6456DFE47836)]
    public class TkGlobals : NMSTemplate
    {
        // size: 0x4
        public enum AssertsLevelEnum : uint {
            Disabled,
            Ignored,
            Skipped,
            Enabled,
        }
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        /* 0x004 */ public bool DefaultSelectIgnoreAsserts;
        // size: 0x9
        [Flags]
        public enum EnabledChannelsEnum : uint {
            None = 0x0,
            Default = 0x1,
            Note = 0x2,
            Error = 0x4,
            Warning = 0x8,
            Info = 0x10,
            Alt = 0x20,
            AltWarn = 0x40,
            AltError = 0x80,
        }
        /* 0x008 */ public EnabledChannelsEnum EnabledChannels;
        /* 0x00C */ public NMSString0x100 IncludeLogFilter;
        /* 0x10C */ public NMSString0x100 ExcludeLogFilter;
        /* 0x20C */ public int LoadBalanceTimeoutMS;
        /* 0x210 */ public int VRLoadBalanceTimeoutMS;
        /* 0x214 */ public int PSVR2LoadBalanceTimeoutMS;
        /* 0x218 */ public bool LogInputSetup;
        /* 0x219 */ public bool LogInputChanges;
        /* 0x21A */ public bool DisableResScaling;
        /* 0x21C */ public int LODOverride;
        /* 0x220 */ public bool ColourLODs;
        /* 0x221 */ public bool MinGPUMode;
        /* 0x222 */ public bool ForceGPUPreset;
        // size: 0xD
        public enum ForceGPUPresetToEnum : uint {
            PC_Low,
            PC_Medium,
            PC_High,
            PC_Ultra,
            PS4,
            PS4VR,
            PS4Pro,
            PS4ProVR,
            XB1,
            XB1X,
            Oberon,
            MacOS,
            iOS,
        }
        /* 0x224 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        /* 0x228 */ public float WwiseVibrationMultiplierPrimary;
        /* 0x22C */ public float WwiseVibrationMultiplierSecondary;
        /* 0x230 */ public bool UseHeavyAir;
        /* 0x231 */ public bool SimulateDisabledParticleRefractions;
        /* 0x232 */ public bool DisableMultiplayer;
        /* 0x233 */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x234 */ public bool UseDebugScreenSettings;
        /* 0x238 */ public int ScreenWidth;
        /* 0x23C */ public int ScreenHeight;
        /* 0x240 */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        /* 0x244 */ public GameWindowModeEnum GameWindowMode;
        /* 0x248 */ public int Monitor;
        /* 0x24C */ public int TiledWindowsSplitCount;
        /* 0x250 */ public int TiledWindowsIndex;
        /* 0x254 */ public bool SampleCollisionWithCamera;
        /* 0x255 */ public bool ShowPlayerCollisions;
        /* 0x258 */ public float UpdatePeriod;
        /* 0x25C */ public float UpdatePeriodSteam;
        /* 0x260 */ public float VoiceUpdatePeriod;
        /* 0x264 */ public float VoiceUpdatePeriodSteam;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        /* 0x268 */ public TrialStatusEnum TrialStatus;
        /* 0x26C */ public bool HmdEnable;
        /* 0x26D */ public bool HmdFoveated;
        /* 0x270 */ public int HmdPreviewScale;
        /* 0x274 */ public bool HmdTracking;
        /* 0x275 */ public bool HmdStereoRender;
        /* 0x276 */ public bool HmdDistortionPassthru;
        /* 0x278 */ public int HmdMonitor;
        /* 0x27C */ public int HmdEyeBufferWidth;
        /* 0x280 */ public int HmdEyeBufferHeight;
        /* 0x284 */ public float HmdEyeScalePos;
        /* 0x288 */ public float HmdHeadScalePos;
        /* 0x28C */ public float HmdImmersionFactor;
        /* 0x290 */ public int FrameFlipRateDefault;
        /* 0x294 */ public int FrameFlipRateLoad;
        /* 0x298 */ public int FrameFlipRateGame;
        /* 0x29C */ public float MaxFrameRate;
    }
}
