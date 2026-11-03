namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E41CB124657A087, NameHash = 0x6FB11939)]
    public class GcGalaxyCameraData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Camera FOV")]
        /* 0x00 */ public float CameraFOV;
        [NMS(Index = 24, MxmlName = "Camera Shake Drift Clip")]
        /* 0x04 */ public float CameraShakeDriftClip;
        [NMS(Index = 25, MxmlName = "Camera Shake Drift Shift")]
        /* 0x08 */ public float CameraShakeDriftShift;
        [NMS(Index = 27, MxmlName = "Camera Shake Maximum")]
        /* 0x0C */ public float CameraShakeMaximum;
        [NMS(Index = 26, MxmlName = "Camera Shake Smoothing Rate")]
        /* 0x10 */ public float CameraShakeSmoothingRate;
        [NMS(Index = 17, MxmlName = "Fixed Zoom Rate")]
        /* 0x14 */ public float FixedZoomRate;
        [NMS(Index = 13, MxmlName = "Free Elevation Blend Rate")]
        /* 0x18 */ public float FreeElevationBlendRate;
        [NMS(Index = 8, MxmlName = "Free Pan Speed")]
        /* 0x1C */ public float FreePanSpeed;
        [NMS(Index = 9, MxmlName = "Free Pan Speed Turbo")]
        /* 0x20 */ public float FreePanSpeedTurbo;
        [NMS(Index = 12, MxmlName = "Free Rotate Speed")]
        /* 0x24 */ public float FreeRotateSpeed;
        [NMS(Index = 10, MxmlName = "Free UpDown Speed")]
        /* 0x28 */ public float FreeUpDownSpeed;
        [NMS(Index = 11, MxmlName = "Free UpDown Speed Turbo")]
        /* 0x2C */ public float FreeUpDownSpeedTurbo;
        [NMS(Index = 4, MxmlName = "Lock Transition Rate")]
        /* 0x30 */ public float LockTransitionRate;
        [NMS(Index = 7, MxmlName = "Locked Scaled Elevation Speed")]
        /* 0x34 */ public float LockedScaledElevationSpeed;
        [NMS(Index = 6, MxmlName = "Locked Scaled Push Speed")]
        /* 0x38 */ public float LockedScaledPushSpeed;
        [NMS(Index = 5, MxmlName = "Locked Spin Speed")]
        /* 0x3C */ public float LockedSpinSpeed;
        [NMS(Index = 21)]
        /* 0x40 */ public float MaxZoomDistance;
        [NMS(Index = 22)]
        /* 0x44 */ public float MinPushingZoomDistance;
        [NMS(Index = 23)]
        /* 0x48 */ public float MinPushingZoomDistanceScaler;
        [NMS(Index = 20)]
        /* 0x4C */ public float MinZoomDistance;
        [NMS(Index = 1, MxmlName = "Movement Blend Rate Free")]
        /* 0x50 */ public float MovementBlendRateFree;
        [NMS(Index = 2, MxmlName = "Movement Blend Rate Locked")]
        /* 0x54 */ public float MovementBlendRateLocked;
        [NMS(Index = 3, MxmlName = "Movement Blend Rate Look Locked")]
        /* 0x58 */ public float MovementBlendRateLookLocked;
        [NMS(Index = 19, MxmlName = "Zoom In Rate")]
        /* 0x5C */ public float ZoomInRate;
        [NMS(Index = 15, MxmlName = "Zoom Out Elevation")]
        /* 0x60 */ public float ZoomOutElevation;
        [NMS(Index = 16, MxmlName = "Zoom Out Push Dist")]
        /* 0x64 */ public float ZoomOutPushDist;
        [NMS(Index = 18, MxmlName = "Zoom Out Rate")]
        /* 0x68 */ public float ZoomOutRate;
        [NMS(Index = 14, MxmlName = "Zoom Out Spin")]
        /* 0x6C */ public float ZoomOutSpin;
    }
}
