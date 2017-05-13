namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyCameraData : NMSTemplate // size = 0x58
    {
        /* 0x00 */ public float CameraFOV;                      // 42C80000h
        /* 0x04 */ public float MovementBlendRateFree;          // 40400000h
        /* 0x08 */ public float MovementBlendRateLocked;        // 40A00000h
        /* 0x0C */ public float LockTransitionRate;             // 40800000h
        /* 0x10 */ public float LockedSpinSpeed;                // 3F666666h
        /* 0x14 */ public float LockedScaledPushSpeed;          // 41A00000h
        /* 0x18 */ public float LockedScaledElevationSpeed;     // 43480000h
        /* 0x1C */ public float FreePanSpeed;                   // 3F800000h
        /* 0x20 */ public float FreePanSpeedTurbo;              // 40300000h
        /* 0x24 */ public float FreeUpDownSpeed;                // 41F00000h
        /* 0x28 */ public float FreeUpDownSpeedTurbo;           // 42F00000h
        /* 0x2C */ public float FreeRotateSpeed;                // 40000000h
        /* 0x30 */ public float FreeElevationBlendRate;         // 3F800000h
        /* 0x34 */ public float ZoomOutSpin;                    // 3F4CCCCDh
        /* 0x38 */ public float ZoomOutElevation;               // 0BF4CCCCDh
        /* 0x3C */ public float ZoomOutPushDist;                // 400CCCCDh
        /* 0x40 */ public float ZoomOutRate;                    // 3ECCCCCDh
        /* 0x44 */ public float ZoomInRate;                     // 40400000h
        /* 0x48 */ public float CameraShakeDriftClip;           // 3E99999Ah
        /* 0x4C */ public float CameraShakeDriftShift;          // 3D4CCCCDh
        /* 0x50 */ public float CameraShakeSmoothingRate;       // 40800000h
        /* 0x54 */ public float CameraShakeMaximum;             // 3F800000h
    }
}
