using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8144743176952031, NameHash = 0x357DD91E)]
    public class GcVehicleData : NMSTemplate
    {
        [NMS(Index = 144, Size = 0xA)]
        /* 0x0000 */ public Vector3f[] WheelGrassPushers;
        [NMS(Index = 22, Size = 0xA)]
        /* 0x00A0 */ public Vector3f[] WheelLocs;
        [NMS(Index = 31)]
        /* 0x0140 */ public Vector3f CollDimensions;
        [NMS(Index = 29)]
        /* 0x0150 */ public Vector3f CollOffset;
        [NMS(Index = 30)]
        /* 0x0160 */ public Vector3f ExtraCollOffset;
        [NMS(Index = 1)]
        /* 0x0170 */ public Vector3f FirstPersonSeatAdjust;
        [NMS(Index = 32)]
        /* 0x0180 */ public Vector3f InertiaDimensions;
        [NMS(Index = 65)]
        /* 0x0190 */ public Vector3f WheelForwardAngularFactor;
        [NMS(Index = 68)]
        /* 0x01A0 */ public Vector3f WheelSideAngularFactor;
        [NMS(Index = 67)]
        /* 0x01B0 */ public Vector3f WheelSuspensionAngularFactor;
        [NMS(Index = 66)]
        /* 0x01C0 */ public Vector3f WheelTurnAngularFactor;
        [NMS(Index = 27, Size = 0xA)]
        /* 0x01D0 */ public NMSString0x10[] SuspensionAnimNames;
        [NMS(Index = 0)]
        /* 0x0270 */ public NMSString0x10 Name;
        [NMS(Index = 86)]
        /* 0x0280 */ public NMSString0x10 SideSkidParticle;
        [NMS(Index = 97)]
        /* 0x0290 */ public NMSString0x10 SubSplashParticle;
        [NMS(Index = 91)]
        /* 0x02A0 */ public NMSString0x10 WheelSpinParticle;
        [NMS(Index = 96)]
        /* 0x02B0 */ public NMSString0x10 WheelSplashParticle;
        [NMS(Index = 26, Size = 0xA)]
        /* 0x02C0 */ public float[] WheelRadiusMultiplier;
        [NMS(Index = 25, Size = 0xA)]
        /* 0x02E8 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Index = 124)]
        /* 0x0310 */ public float AudioImpactSpeedMul;
        [NMS(Index = 123)]
        /* 0x0314 */ public float AudioImpactSpeedThreshold;
        [NMS(Index = 28)]
        /* 0x0318 */ public GcVehicleCollisionInertia CollisionInertiaMode;
        [NMS(Index = 33)]
        /* 0x031C */ public float CollRadius;
        [NMS(Index = 145)]
        /* 0x0320 */ public float CreatureMassScale;
        [NMS(Index = 48)]
        /* 0x0324 */ public float HardStopSpeedThreshold;
        [NMS(Index = 149)]
        /* 0x0328 */ public float HeadlightIntensity;
        [NMS(Index = 34)]
        /* 0x032C */ public float InertiaMul;
        [NMS(Index = 140)]
        /* 0x0330 */ public int NumGrassPushers;
        [NMS(Index = 2)]
        /* 0x0334 */ public int NumWheels;
        [NMS(Index = 88)]
        /* 0x0338 */ public float SideSkidParticleMaxRate;
        [NMS(Index = 90)]
        /* 0x033C */ public float SideSkidParticleMaxThresh;
        [NMS(Index = 87)]
        /* 0x0340 */ public float SideSkidParticleMinRate;
        [NMS(Index = 89)]
        /* 0x0344 */ public float SideSkidParticleMinThresh;
        [NMS(Index = 21)]
        /* 0x0348 */ public float SteeringWheelPushRange;
        [NMS(Index = 20)]
        /* 0x034C */ public float SteeringWheelSpringMultiplier;
        [NMS(Index = 99)]
        /* 0x0350 */ public float SubSplashParticleMaxThresh;
        [NMS(Index = 98)]
        /* 0x0354 */ public float SubSplashParticleMinThresh;
        [NMS(Index = 40)]
        /* 0x0358 */ public float TopSpeedForward;
        [NMS(Index = 41)]
        /* 0x035C */ public float TopSpeedReverse;
        [NMS(Index = 60)]
        /* 0x0360 */ public float TurningWheelForce;
        [NMS(Index = 61)]
        /* 0x0364 */ public float TurningWheelForceDamperVR;
        [NMS(Index = 64)]
        /* 0x0368 */ public float TurningWheelFrictionBraking;
        [NMS(Index = 63)]
        /* 0x036C */ public float TurningWheelFrictionNonBraking;
        [NMS(Index = 62)]
        /* 0x0370 */ public float TurningWheelFrictionOmega;
        [NMS(Index = 15)]
        /* 0x0374 */ public float UnderwaterAlignDir;
        [NMS(Index = 16)]
        /* 0x0378 */ public float UnderwaterAlignUp;
        [NMS(Index = 13)]
        /* 0x037C */ public float UnderwaterEngineDirectionBrake;
        [NMS(Index = 14)]
        /* 0x0380 */ public float UnderwaterEngineDirectionBrakeVertical;
        [NMS(Index = 12)]
        /* 0x0384 */ public float UnderwaterEngineFalloff;
        [NMS(Index = 10)]
        /* 0x0388 */ public float UnderwaterEngineMaxSpeed;
        [NMS(Index = 11)]
        /* 0x038C */ public float UnderwaterEngineMaxSpeedVR;
        [NMS(Index = 8)]
        /* 0x0390 */ public float UnderwaterEnginePower;
        [NMS(Index = 9)]
        /* 0x0394 */ public float UnderwaterEnginePowerVR;
        [NMS(Index = 111)]
        /* 0x0398 */ public float VehicleAngularDampingAerial;
        [NMS(Index = 109)]
        /* 0x039C */ public float VehicleAngularDampingGround;
        [NMS(Index = 113)]
        /* 0x03A0 */ public float VehicleAngularDampingWater;
        [NMS(Index = 119)]
        /* 0x03A4 */ public float VehicleAudioSideSkidMul;
        [NMS(Index = 120)]
        /* 0x03A8 */ public float VehicleAudioSideSkidThreshold;
        [NMS(Index = 117)]
        /* 0x03AC */ public float VehicleAudioSpeedMul;
        [NMS(Index = 121)]
        /* 0x03B0 */ public float VehicleAudioSpinSkidMul;
        [NMS(Index = 122)]
        /* 0x03B4 */ public float VehicleAudioSpinSkidThreshold;
        [NMS(Index = 139)]
        /* 0x03B8 */ public float VehicleAudioSuspensionScale;
        [NMS(Index = 138)]
        /* 0x03BC */ public float VehicleAudioSuspensionThreshold;
        [NMS(Index = 118)]
        /* 0x03C0 */ public float VehicleAudioTorqueMul;
        [NMS(Index = 75)]
        /* 0x03C4 */ public float VehicleBoostExtraMaxSpeedAir;
        [NMS(Index = 73)]
        /* 0x03C8 */ public float VehicleBoostForce;
        [NMS(Index = 74)]
        /* 0x03CC */ public float VehicleBoostMaxSpeed;
        [NMS(Index = 78)]
        /* 0x03D0 */ public float VehicleBoostRechargeTime;
        [NMS(Index = 76)]
        /* 0x03D4 */ public float VehicleBoostSpeedFalloff;
        [NMS(Index = 77)]
        /* 0x03D8 */ public float VehicleBoostTime;
        [NMS(Index = 116)]
        /* 0x03DC */ public float VehicleComCheat;
        [NMS(Index = 69)]
        /* 0x03E0 */ public float VehicleGravity;
        [NMS(Index = 70)]
        /* 0x03E4 */ public float VehicleGravityWater;
        [NMS(Index = 72)]
        /* 0x03E8 */ public float VehicleJumpAirControlForce;
        [NMS(Index = 83)]
        /* 0x03EC */ public float VehicleJumpAirMaxTorque;
        [NMS(Index = 82)]
        /* 0x03F0 */ public float VehicleJumpAirRotateTimeMax;
        [NMS(Index = 81)]
        /* 0x03F4 */ public float VehicleJumpAirRotateTimeMin;
        [NMS(Index = 79)]
        /* 0x03F8 */ public float VehicleJumpAirRotateXAmount;
        [NMS(Index = 80)]
        /* 0x03FC */ public float VehicleJumpAirRotateZAmount;
        [NMS(Index = 71)]
        /* 0x0400 */ public float VehicleJumpForce;
        [NMS(Index = 110)]
        /* 0x0404 */ public float VehicleLinearDampingAerial;
        [NMS(Index = 108)]
        /* 0x0408 */ public float VehicleLinearDampingGround;
        [NMS(Index = 112)]
        /* 0x040C */ public float VehicleLinearDampingWater;
        [NMS(Index = 137)]
        /* 0x0410 */ public float VehicleUnderwaterRotateTime;
        [NMS(Index = 19)]
        /* 0x0414 */ public float VisualPitchAmount;
        [NMS(Index = 17)]
        /* 0x0418 */ public float VisualRollAmount;
        [NMS(Index = 18)]
        /* 0x041C */ public float VisualRollOffsetY;
        [NMS(Index = 47)]
        /* 0x0420 */ public float WheelDragginess;
        [NMS(Index = 115)]
        /* 0x0424 */ public float WheelEndHeight;
        [NMS(Index = 50)]
        /* 0x0428 */ public float WheelFrontFrictionDynamic;
        [NMS(Index = 51)]
        /* 0x042C */ public float WheelFrontFrictionDynamicThreshold;
        [NMS(Index = 49)]
        /* 0x0430 */ public float WheelFrontFrictionOmega;
        [NMS(Index = 52)]
        /* 0x0434 */ public float WheelFrontFrictionStatic;
        [NMS(Index = 53)]
        /* 0x0438 */ public float WheelFrontFrictionStaticThreshold;
        [NMS(Index = 143)]
        /* 0x043C */ public float WheelGrassPusherFrequency;
        [NMS(Index = 141)]
        /* 0x0440 */ public float WheelGrassPusherStrength;
        [NMS(Index = 142)]
        /* 0x0444 */ public float WheelGrassPusherWobble;
        [NMS(Index = 6)]
        /* 0x0448 */ public float WheelGuardAdjustUpwards;
        [NMS(Index = 5)]
        /* 0x044C */ public float WheelGuardExtraHeight;
        [NMS(Index = 4)]
        /* 0x0450 */ public float WheelGuardExtraRadius;
        [NMS(Index = 106)]
        /* 0x0454 */ public float WheelGuardMassScaleMax;
        [NMS(Index = 105)]
        /* 0x0458 */ public float WheelGuardMassScaleMin;
        [NMS(Index = 107)]
        /* 0x045C */ public float WheelGuardMassScaleMinClamp;
        [NMS(Index = 103)]
        /* 0x0460 */ public float WheelGuardPenetrationScaleMax;
        [NMS(Index = 102)]
        /* 0x0464 */ public float WheelGuardPenetrationScaleMin;
        [NMS(Index = 104)]
        /* 0x0468 */ public float WheelGuardPenetrationScaleMinClamp;
        [NMS(Index = 101)]
        /* 0x046C */ public float WheelGuardVerticalResponseMax;
        [NMS(Index = 100)]
        /* 0x0470 */ public float WheelGuardVerticalResponseMin;
        [NMS(Index = 42)]
        /* 0x0474 */ public float WheelMaxAccelForceForward;
        [NMS(Index = 43)]
        /* 0x0478 */ public float WheelMaxAccelForceReverse;
        [NMS(Index = 45)]
        /* 0x047C */ public float WheelMaxDecelForceBraking;
        [NMS(Index = 44)]
        /* 0x0480 */ public float WheelMaxDecelForceNonBraking;
        [NMS(Index = 3)]
        /* 0x0484 */ public float WheelRadius;
        [NMS(Index = 55)]
        /* 0x0488 */ public float WheelSideFrictionDynamic;
        [NMS(Index = 56)]
        /* 0x048C */ public float WheelSideFrictionDynamicThreshold;
        [NMS(Index = 54)]
        /* 0x0490 */ public float WheelSideFrictionOmega;
        [NMS(Index = 57)]
        /* 0x0494 */ public float WheelSideFrictionStatic;
        [NMS(Index = 58)]
        /* 0x0498 */ public float WheelSideFrictionStaticThreshold;
        [NMS(Index = 46)]
        /* 0x049C */ public float WheelSpinniness;
        [NMS(Index = 93)]
        /* 0x04A0 */ public float WheelSpinParticleMaxRate;
        [NMS(Index = 95)]
        /* 0x04A4 */ public float WheelSpinParticleMaxThresh;
        [NMS(Index = 92)]
        /* 0x04A8 */ public float WheelSpinParticleMinRate;
        [NMS(Index = 94)]
        /* 0x04AC */ public float WheelSpinParticleMinThresh;
        [NMS(Index = 114)]
        /* 0x04B0 */ public float WheelStartHeight;
        [NMS(Index = 39)]
        /* 0x04B4 */ public float WheelSuspensionAnimMax;
        [NMS(Index = 38)]
        /* 0x04B8 */ public float WheelSuspensionAnimMin;
        [NMS(Index = 37)]
        /* 0x04BC */ public float WheelSuspensionDamping;
        [NMS(Index = 36)]
        /* 0x04C0 */ public float WheelSuspensionForce;
        [NMS(Index = 35)]
        /* 0x04C4 */ public float WheelSuspensionlength;
        [NMS(Index = 148, Size = 0x2)]
        /* 0x04C8 */ public NMSString0x100[] CockpitHeadlightNames;
        [NMS(Index = 146, Size = 0x2)]
        /* 0x06C8 */ public NMSString0x100[] HeadlightNames;
        [NMS(Index = 147, Size = 0x2)]
        /* 0x08C8 */ public NMSString0x100[] VolumetricHeadlightNames;
        [NMS(Index = 23, Size = 0xA)]
        /* 0x0AC8 */ public NMSString0x20[] WheelNames;
        [NMS(Index = 24, Size = 0xA)]
        /* 0x0C08 */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Index = 126)]
        /* 0x0D48 */ public NMSString0x80 AudioBoostStart;
        [NMS(Index = 127)]
        /* 0x0DC8 */ public NMSString0x80 AudioBoostStop;
        [NMS(Index = 128)]
        /* 0x0E48 */ public NMSString0x80 AudioHornStart;
        [NMS(Index = 129)]
        /* 0x0EC8 */ public NMSString0x80 AudioHornStop;
        [NMS(Index = 130)]
        /* 0x0F48 */ public NMSString0x80 AudioIdleExterior;
        [NMS(Index = 131)]
        /* 0x0FC8 */ public NMSString0x80 AudioImpacts;
        [NMS(Index = 135)]
        /* 0x1048 */ public NMSString0x80 AudioJump;
        [NMS(Index = 132)]
        /* 0x10C8 */ public NMSString0x80 AudioStart;
        [NMS(Index = 133)]
        /* 0x1148 */ public NMSString0x80 AudioStop;
        [NMS(Index = 134)]
        /* 0x11C8 */ public NMSString0x80 AudioSuspension;
        [NMS(Index = 136)]
        /* 0x1248 */ public bool DriveOnTopOfWater;
        [NMS(Index = 7)]
        /* 0x1249 */ public bool GenerateWheelGuards;
        [NMS(Index = 59)]
        /* 0x124A */ public bool LockVehicleAxis;
        [NMS(Index = 84)]
        /* 0x124B */ public bool UseBuggySuspensionHack;
        [NMS(Index = 85)]
        /* 0x124C */ public bool UseRoverWheelHack;
        [NMS(Index = 125)]
        /* 0x124D */ public bool VehicleAudioSwapSkidAndSpeed;
    }
}
