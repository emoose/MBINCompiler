namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC3376240A715E64, NameHash = 0x4EA99277E076565E)]
    public class GcGyroSettingsData : NMSTemplate
    {
        /* 0x00 */ public bool GyroEnabled;
        /* 0x01 */ public bool GyroEnabledHandheld;
        // size: 0x4
        public enum ActiveModeOnFootEnum {
            None,
            ScopeOnly,
            ScopeOrFiring,
            Always,
        }
        /* 0x04 */ public ActiveModeOnFootEnum ActiveModeOnFoot;
        /* 0x08 */ public bool AllowWhenRidingCreatures;
        // size: 0x4
        public enum ActiveModeWhenBuildingEnum {
            None,
            BuildPlacementOnly,
            SelectionModeOnly,
            Always,
        }
        /* 0x0C */ public ActiveModeWhenBuildingEnum ActiveModeWhenBuilding;
        // size: 0x3
        public enum EnableGyroInBuildingFreeCamEnum {
            Never,
            MatchActiveModeWhenBuilding,
            Always,
        }
        /* 0x10 */ public EnableGyroInBuildingFreeCamEnum EnableGyroInBuildingFreeCam;
        // size: 0x3
        public enum ActiveModeInExocraftEnum {
            None,
            Firing,
            Always,
        }
        /* 0x14 */ public ActiveModeInExocraftEnum ActiveModeInExocraft;
        // size: 0x3
        public enum LookStickEnabledEnum {
            None,
            Disabled,
            Enabled,
        }
        /* 0x18 */ public LookStickEnabledEnum LookStickEnabled;
        /* 0x1C */ public bool GyroCursorEnabled;
        /* 0x20 */ public float CursorSensitivityX;
        /* 0x24 */ public float CursorSensitivityY;
        /* 0x28 */ public float CursorTighteningThreshold;
        // size: 0x2
        public enum CursorLookStickEnabledEnum {
            None,
            Disabled,
        }
        /* 0x2C */ public CursorLookStickEnabledEnum CursorLookStickEnabled;
        // size: 0x2
        public enum HandednessEnum {
            Left,
            Right,
        }
        /* 0x30 */ public HandednessEnum Handedness;
        /* 0x34 */ public float SensitivityX;
        /* 0x38 */ public float SensitivityY;
        /* 0x3C */ public float Steadying;
        /* 0x40 */ public float Acceleration;
        /* 0x44 */ public bool EnableAdvancedOptions;
        /* 0x48 */ public float ScopeMultiplier;
        /* 0x4C */ public float AimingMultiplier;
        /* 0x50 */ public float ExocraftMultiplier;
        /* 0x54 */ public float BuildingMultiplier;
        /* 0x58 */ public bool ZoomScalesSensitivity;
        // size: 0x2
        public enum GyroRotationSpaceEnum {
            Local,
            Player,
        }
        /* 0x5C */ public GyroRotationSpaceEnum GyroRotationSpace;
        // size: 0x2
        public enum GyroRotationSpaceHandheldEnum {
            Local,
            Player,
        }
        /* 0x60 */ public GyroRotationSpaceHandheldEnum GyroRotationSpaceHandheld;
        // size: 0x3
        public enum YawAxisDirectionEnum {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x64 */ public YawAxisDirectionEnum YawAxisDirection;
        // size: 0x3
        public enum RollAxisDirectionEnum {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x68 */ public RollAxisDirectionEnum RollAxisDirection;
        // size: 0x3
        public enum PitchAxisDirectionEnum {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x6C */ public PitchAxisDirectionEnum PitchAxisDirection;
        /* 0x70 */ public float SmoothingThreshold;
        /* 0x74 */ public float SmoothingWindow;
        /* 0x78 */ public float TighteningThreshold;
        /* 0x7C */ public float Deadzone;
        /* 0x80 */ public bool FilterControllerVibrations;
    }
}
