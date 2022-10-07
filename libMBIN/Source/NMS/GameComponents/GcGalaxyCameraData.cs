namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFD832D5AAAFFA2A, NameHash = 0x76DA44862CDF100D)]
    public class GcGalaxyCameraData : NMSTemplate
    {
        /* 0x00 */ public float CameraFOV;
        /* 0x04 */ public float MovementBlendRateFree;
        /* 0x08 */ public float MovementBlendRateLocked;
        /* 0x0C */ public float MovementBlendRateLookLocked;
        /* 0x10 */ public float LockTransitionRate;
        /* 0x14 */ public float LockedSpinSpeed;
        /* 0x18 */ public float LockedScaledPushSpeed;
        /* 0x1C */ public float LockedScaledElevationSpeed;
        /* 0x20 */ public float FreePanSpeed;
        /* 0x24 */ public float FreePanSpeedTurbo;
        /* 0x28 */ public float FreeUpDownSpeed;
        /* 0x2C */ public float FreeUpDownSpeedTurbo;
        /* 0x30 */ public float FreeRotateSpeed;
        /* 0x34 */ public float FreeElevationBlendRate;
        /* 0x38 */ public float ZoomOutSpin;
        /* 0x3C */ public float ZoomOutElevation;
        /* 0x40 */ public float ZoomOutPushDist;
        /* 0x44 */ public float ZoomOutRate;
        /* 0x48 */ public float ZoomInRate;
        /* 0x4C */ public float MinZoomDistance;
        /* 0x50 */ public float MaxZoomDistance;
        /* 0x54 */ public float MinPushingZoomDistance;
        /* 0x58 */ public float MinPushingZoomDistanceScaler;
        /* 0x5C */ public float CameraShakeDriftClip;
        /* 0x60 */ public float CameraShakeDriftShift;
        /* 0x64 */ public float CameraShakeSmoothingRate;
        /* 0x68 */ public float CameraShakeMaximum;
    }
}
