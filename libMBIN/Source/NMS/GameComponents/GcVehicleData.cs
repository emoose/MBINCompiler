namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DC9930563101A5C, NameHash = 0x904DB42CF570F4BB)]
    public class GcVehicleData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x10 Name;
        /* 0x0010 */ public int NumWheels;
        /* 0x0014 */ public float WheelRadius;
        /* 0x0018 */ public float WheelGuardExtraRadius;
        /* 0x001C */ public float WheelGuardExtraHeight;
        /* 0x0020 */ public float WheelGuardAdjustUpwards;
        /* 0x0024 */ public float UnderwaterEnginePower;
        /* 0x0028 */ public float UnderwaterEngineMaxSpeed;
        /* 0x002C */ public float UnderwaterEngineFalloff;
        /* 0x0030 */ public float UnderwaterEngineDirectionBrake;
        /* 0x0034 */ public float UnderwaterEngineDirectionBrakeVertical;
        /* 0x0038 */ public float UnderwaterAlignDir;
        /* 0x003C */ public float UnderwaterAlignUp;
        /* 0x0040 */ public float VisualRollAmount;
        /* 0x0044 */ public float VisualRollOffsetY;
        /* 0x0048 */ public float SteeringWheelSpringMultiplier;
        /* 0x004C */ public float SteeringWheelPushRange;
        [NMS(Size = 0xA)]
        /* 0x0050 */ public Vector3f[] WheelLocs;
        [NMS(Size = 0xA)]
        /* 0x00F0 */ public NMSString0x20[] WheelNames;
        [NMS(Size = 0xA)]
        /* 0x0230 */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Size = 0xA)]
        /* 0x0370 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Size = 0xA)]
        /* 0x0398 */ public float[] WheelRadiusMultiplier;
        [NMS(Size = 0xA)]
        /* 0x03C0 */ public NMSString0x10[] SuspensionAnimNames;
        /* 0x0460 */ public bool CustomCollision;
        /* 0x0470 */ public Vector3f CollOffset;
        /* 0x0480 */ public Vector3f ExtraCollOffset;
        /* 0x0490 */ public Vector3f CollDimensions;
        /* 0x04A0 */ public Vector3f InertiaDimensions;
        /* 0x04B0 */ public float CollRadius;
        /* 0x04B4 */ public float InertiaMul;
        /* 0x04B8 */ public float WheelSuspensionlength;
        /* 0x04BC */ public float WheelSuspensionForce;
        /* 0x04C0 */ public float WheelSuspensionDamping;
        /* 0x04C4 */ public float WheelSuspensionAnimMin;
        /* 0x04C8 */ public float WheelSuspensionAnimMax;
        /* 0x04CC */ public float TopSpeedForward;
        /* 0x04D0 */ public float TopSpeedReverse;
        /* 0x04D4 */ public float WheelMaxAccelForceForward;
        /* 0x04D8 */ public float WheelMaxAccelForceReverse;
        /* 0x04DC */ public float WheelMaxDecelForceNonBraking;
        /* 0x04E0 */ public float WheelMaxDecelForceBraking;
        /* 0x04E4 */ public float WheelSpinniness;
        /* 0x04E8 */ public float WheelDragginess;
        /* 0x04EC */ public float HardStopSpeedThreshold;
        /* 0x04F0 */ public float WheelFrontFrictionOmega;
        /* 0x04F4 */ public float WheelFrontFrictionDynamic;
        /* 0x04F8 */ public float WheelFrontFrictionDynamicThreshold;
        /* 0x04FC */ public float WheelFrontFrictionStatic;
        /* 0x0500 */ public float WheelFrontFrictionStaticThreshold;
        /* 0x0504 */ public float WheelSideFrictionOmega;
        /* 0x0508 */ public float WheelSideFrictionDynamic;
        /* 0x050C */ public float WheelSideFrictionDynamicThreshold;
        /* 0x0510 */ public float WheelSideFrictionStatic;
        /* 0x0514 */ public float WheelSideFrictionStaticThreshold;
        /* 0x0518 */ public bool LockVehicleAxis;
        /* 0x051C */ public float TurningWheelForce;
        /* 0x0520 */ public float TurningWheelForceDamperVR;
        /* 0x0524 */ public float TurningWheelFrictionOmega;
        /* 0x0528 */ public float TurningWheelFrictionNonBraking;
        /* 0x052C */ public float TurningWheelFrictionBraking;
        /* 0x0530 */ public Vector3f WheelForwardAngularFactor;
        /* 0x0540 */ public Vector3f WheelTurnAngularFactor;
        /* 0x0550 */ public Vector3f WheelSuspensionAngularFactor;
        /* 0x0560 */ public Vector3f WheelSideAngularFactor;
        /* 0x0570 */ public float VehicleGravity;
        /* 0x0574 */ public float VehicleGravityWater;
        /* 0x0578 */ public float VehicleJumpForce;
        /* 0x057C */ public float VehicleJumpAirControlForce;
        /* 0x0580 */ public float VehicleBoostForce;
        /* 0x0584 */ public float VehicleBoostMaxSpeed;
        /* 0x0588 */ public float VehicleBoostExtraMaxSpeedAir;
        /* 0x058C */ public float VehicleBoostSpeedFalloff;
        /* 0x0590 */ public float VehicleBoostTime;
        /* 0x0594 */ public float VehicleBoostRechargeTime;
        /* 0x0598 */ public float VehicleJumpAirRotateXAmount;
        /* 0x059C */ public float VehicleJumpAirRotateZAmount;
        /* 0x05A0 */ public float VehicleJumpAirRotateTimeMin;
        /* 0x05A4 */ public float VehicleJumpAirRotateTimeMax;
        /* 0x05A8 */ public float VehicleJumpAirMaxTorque;
        /* 0x05AC */ public bool UseBuggySuspensionHack;
        /* 0x05AD */ public bool UseRoverWheelHack;
        /* 0x05B0 */ public NMSString0x10 SideSkidParticle;
        /* 0x05C0 */ public float SideSkidParticleMinRate;
        /* 0x05C4 */ public float SideSkidParticleMaxRate;
        /* 0x05C8 */ public float SideSkidParticleMinThresh;
        /* 0x05CC */ public float SideSkidParticleMaxThresh;
        /* 0x05D0 */ public NMSString0x10 WheelSpinParticle;
        /* 0x05E0 */ public float WheelSpinParticleMinRate;
        /* 0x05E4 */ public float WheelSpinParticleMaxRate;
        /* 0x05E8 */ public float WheelSpinParticleMinThresh;
        /* 0x05EC */ public float WheelSpinParticleMaxThresh;
        /* 0x05F0 */ public float WheelGuardVerticalResponseMin;
        /* 0x05F4 */ public float WheelGuardVerticalResponseMax;
        /* 0x05F8 */ public float WheelGuardPenetrationScaleMin;
        /* 0x05FC */ public float WheelGuardPenetrationScaleMax;
        /* 0x0600 */ public float WheelGuardPenetrationScaleMinClamp;
        /* 0x0604 */ public float WheelGuardMassScaleMin;
        /* 0x0608 */ public float WheelGuardMassScaleMax;
        /* 0x060C */ public float WheelGuardMassScaleMinClamp;
        /* 0x0610 */ public float VehicleLinearDampingGround;
        /* 0x0614 */ public float VehicleAngularDampingGround;
        /* 0x0618 */ public float VehicleLinearDampingAerial;
        /* 0x061C */ public float VehicleAngularDampingAerial;
        /* 0x0620 */ public float VehicleLinearDampingWater;
        /* 0x0624 */ public float VehicleAngularDampingWater;
        /* 0x0628 */ public float WheelStartHeight;
        /* 0x062C */ public float WheelEndHeight;
        /* 0x0630 */ public float VehicleComCheat;
        /* 0x0634 */ public float VehicleAudioSpeedMul;
        /* 0x0638 */ public float VehicleAudioTorqueMul;
        /* 0x063C */ public float VehicleAudioSideSkidMul;
        /* 0x0640 */ public float VehicleAudioSideSkidThreshold;
        /* 0x0644 */ public float VehicleAudioSpinSkidMul;
        /* 0x0648 */ public float VehicleAudioSpinSkidThreshold;
        /* 0x064C */ public float AudioImpactSpeedThreshold;
        /* 0x0650 */ public float AudioImpactSpeedMul;
        /* 0x0654 */ public bool VehicleAudioSwapSkidAndSpeed;
        /* 0x0655 */ public NMSString0x80 AudioBoostStart;
        /* 0x06D5 */ public NMSString0x80 AudioBoostStop;
        /* 0x0755 */ public NMSString0x80 AudioHornStart;
        /* 0x07D5 */ public NMSString0x80 AudioHornStop;
        /* 0x0855 */ public NMSString0x80 AudioIdleExterior;
        /* 0x08D5 */ public NMSString0x80 AudioImpacts;
        /* 0x0955 */ public NMSString0x80 AudioStart;
        /* 0x09D5 */ public NMSString0x80 AudioStop;
        /* 0x0A55 */ public NMSString0x80 AudioSuspension;
        /* 0x0AD5 */ public NMSString0x80 AudioJump;
        /* 0x0B55 */ public bool DriveOnTopOfWater;
        /* 0x0B58 */ public float VehicleUnderwaterRotateTime;
        /* 0x0B5C */ public float VehicleAudioSuspensionThreshold;
        /* 0x0B60 */ public float VehicleAudioSuspensionScale;
        /* 0x0B64 */ public int NumGrassPushers;
        /* 0x0B68 */ public float WheelGrassPusherStrength;
        /* 0x0B6C */ public float WheelGrassPusherWobble;
        /* 0x0B70 */ public float WheelGrassPusherFrequency;
        /* 0x0B74 */ public float WheelGrassPusherReduce;
        [NMS(Size = 0xA)]
        /* 0x0B80 */ public Vector3f[] WheelGrassPushers;
        /* 0x0C20 */ public float CreatureMassScale;
        [NMS(Size = 0x2)]
        /* 0x0C24 */ public NMSString0x100[] HeadlightNames;
        [NMS(Size = 0x2)]
        /* 0x0E24 */ public NMSString0x100[] VolumetricHeadlightNames;
        [NMS(Size = 0x2)]
        /* 0x1024 */ public NMSString0x100[] CockpitHeadlightNames;
        /* 0x1224 */ public float HeadlightIntensity;
    }
}
