using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7157800CF625C3AF)]
    public class GcVehicleData : NMSTemplate        // size: 0xBB0
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;
        /* 0x010 */ public int NumWheels;
        /* 0x014 */ public float WheelRadius;
        /* 0x018 */ public float WheelGuardExtraRadius;
        /* 0x01C */ public float WheelGuardExtraHeight;
        /* 0x020 */ public float WheelGuardAdjustUpwards;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;
        [NMS(Size = 0xA)]
        /* 0x030 */ public Vector4f[] WheelLocs;
        [NMS(Size = 0xA)]
        /* 0x0D0 */ public NMSString0x20[] WheelNames;
        [NMS(Size = 0xA)]
        /* 0x210 */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Size = 0xA)]
        /* 0x350 */ public NMSString0x10[] SuspensionAnimNames;
        /* 0x3F0 */ public Vector4f CollOffset;
        /* 0x400 */ public Vector4f ExtraCollOffset;
        /* 0x410 */ public Vector4f CollDimensions;
        /* 0x420 */ public Vector4f InertiaDimensions;

        /* 0x430 */ public float CollRadius;
        /* 0x434 */ public float InertiaMull;
        /* 0x438 */ public float WheelSuspensionlength;
        /* 0x43C */ public float WheelSuspensionForce;
        /* 0x440 */ public float WheelSuspensionDamping;
        /* 0x444 */ public float WheelSuspensionAnimMin;
        /* 0x448 */ public float WheelSuspensionAnimMax;
        /* 0x44C */ public float TopSpeedForward;
        /* 0x450 */ public float TopSpeedReverse;
        /* 0x454 */ public float WheelMaxAccelForceForward;
        /* 0x458 */ public float WheelMaxAccelForceReverse;
        /* 0x45C */ public float WheelMaxDecelForceNonBraking;
        /* 0x460 */ public float WheelMaxDecelForceBraking;
        /* 0x464 */ public float WheelSpinniness;
        /* 0x468 */ public float WheelDragginess;
        /* 0x46C */ public float HardStopSpeedThreshold;
        /* 0x470 */ public float WheelFrontFrictionOmega;
        /* 0x474 */ public float WheelFrontFrictionDynamic;
        /* 0x478 */ public float WheelFrontFrictionDynamicThreshold;
        /* 0x47C */ public float WheelFrontFrictionStatic;
        /* 0x480 */ public float WheelFrontFrictionStaticThreshold;
        /* 0x484 */ public float WheelSideFrictionOmega;
        /* 0x488 */ public float WheelSideFrictionDynamic;
        /* 0x48C */ public float WheelSideFrictionDynamicThreshold;
        /* 0x490 */ public float WheelSideFrictionStatic;
        /* 0x494 */ public float WheelSideFrictionStaticThreshold;
        /* 0x498 */ public float TurningWheelForce;
        /* 0x49C */ public float TurningWheelFrictionOmega;
        /* 0x4A0 */ public float TurningWheelFrictionNonBraking;
        /* 0x4A4 */ public float TurningWheelFrictionBraking;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4A8 */ public byte[] Padding4A8;

        /* 0x4B0 */ public Vector4f WheelForwardAngularFactor;
        /* 0x4C0 */ public Vector4f WheelTurnAngularFactor;
        /* 0x4D0 */ public Vector4f WheelSuspensionAngularFactor;
        /* 0x4E0 */ public Vector4f WheelSideAngularFactor;
        /* 0x4F0 */ public float VehicleGravity;
        /* 0x4F4 */ public float VehicleGravityWater;
        /* 0x4F8 */ public float VehicleJumpForce;
        /* 0x4FC */ public float VehicleJumpAirControlForce;
        /* 0x500 */ public float VehicleBoostForce;
        /* 0x504 */ public float VehicleBoostMaxSpeed;
        /* 0x508 */ public float VehicleBoostSpeedFalloff;
        /* 0x50C */ public float VehicleBoostTime;
        /* 0x510 */ public float VehicleBoostRechargeTime;
        /* 0x514 */ public float VehicleJumpAirRotatexAmount;
        /* 0x518 */ public float VehicleJumpAirRotateZAmount;
        /* 0x50C */ public float VehicleJumpAirRotateTimeMin;
        /* 0x520 */ public float VehicleJumpAirRotateTimeMax;
        /* 0x524 */ public float VehicleJumpAirMaxTorque;
        /* 0x528 */ public bool UseBuggySuspensionHack;
        /* 0x529 */ public bool UseRoverWheelHack;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x52A */ public byte[] Padding52A;

        [NMS(Size = 0x10)]
        /* 0x530 */ public string SideSkidParticle;
        /* 0x540 */ public float SideSkidParticleMinRate;
        /* 0x544 */ public float SideSkidParticleMaxRate;
        /* 0x548 */ public float SideSkidParticleMinThresh;
        /* 0x54C */ public float SideSkidParticleMaxThresh;

        [NMS(Size = 0x10)]
        /* 0x550 */ public string WheelSpinParticle;
        /* 0x560 */ public float WheelSpinParticleMinRate;
        /* 0x564 */ public float WheelSpinParticleMaxRate;
        /* 0x568 */ public float WheelSpinParticleMinThresh;
        /* 0x56C */ public float WheelSpinParticleMaxThresh;
        /* 0x570 */ public float WheelGuardVerticalResponseMin;
        /* 0x574 */ public float WheelGuardVerticalResponseMax;
        /* 0x578 */ public float WheelGuardPenetrationScaleMin;
        /* 0x57C */ public float WheelGuardPenetrationScaleMax;
        /* 0x580 */ public float WheelGuardPenetrationScaleMinClamp;
        /* 0x584 */ public float WheelGuardMassScaleMin;
        /* 0x588 */ public float WheelGuardMassScaleMax;
        /* 0x58C */ public float WheelGuardMassScaleMinClamp;
        /* 0x590 */ public float VehicleLinearDampingGround;
        /* 0x594 */ public float VehicleAngularDampingGround;
        /* 0x598 */ public float VehicleLinearDampingAerial;
        /* 0x59C */ public float VehicleAngularDampingAerial;
        /* 0x5A0 */ public float VehicleLinearDampingWater;
        /* 0x5A4 */ public float VehicleAngularDampingWater;
        /* 0x5A8 */ public float WheelStartHeight;
        /* 0x5AC */ public float WheelEndHeight;
        /* 0x5B0 */ public float VehicleComCheat;
        /* 0x5B4 */ public float VehicleAudioSpeedMul;
        /* 0x5B8 */ public float VehicleAudioTorqueMul;
        /* 0x5BC */ public float VehicleAudioSideSkidMul;
        /* 0x5C0 */ public float VehicleAudioSideSkidThreshold;
        /* 0x5C4 */ public float VehicleAudioSpinSkidMul;
        /* 0x5C8 */ public float VehicleAudioSpinSkidThreshold;
        /* 0x5CC */ public float AudioImpactSpeedThreshold;
        /* 0x5D0 */ public float AudioImpactSpeedMul;
        /* 0x5D4 */ public bool VehicleAudioSwapSkidAndSpeed;
        [NMS(Size = 0x80)]
        /* 0x5D5 */ public string AudioBoostStart;
        [NMS(Size = 0x80)]
        /* 0x655 */ public string AudioBoostStop;
        [NMS(Size = 0x80)]
        /* 0x6D5 */ public string AudioHornStart;
        [NMS(Size = 0x80)]
        /* 0x755 */ public string AudioHornStop;
        [NMS(Size = 0x80)]
        /* 0x7D5 */ public string AudioIdleExterior;
        [NMS(Size = 0x80)]
        /* 0x855 */ public string AudioImpacts;
        [NMS(Size = 0x80)]
        /* 0x8D5 */ public string AudioStart;
        [NMS(Size = 0x80)]
        /* 0x955 */ public string AudioStop;
        [NMS(Size = 0x80)]
        /* 0x9D5 */ public string AudioSuspension;
        [NMS(Size = 0x80)]
        /* 0xA55 */ public string AudioJump;

        /* 0xAD5 */ public bool DriveOnTopOfWater;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0xAD6 */ public byte[] PaddingAD6;
        /* 0xAD8 */ public float VehicleUnderwaterRotateTime;
        /* 0xADC */ public float VehicleAudioSuspensionThreshold;
        /* 0xAE0 */ public float VehicleAudioSuspensionScale;
        /* 0xAE4 */ public int NumGrassPushers;
        /* 0xAE8 */ public float WheelGrassPusherStrength;
        /* 0xAEC */ public float WheelGrassPusherWobble;
        /* 0xAF0 */ public float WheelGrassPusherFrequency;
        /* 0xAF4 */ public float WheelGrassPusherReduce;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xAF8 */ public byte[] PaddingAF8;
        [NMS(Size = 0xA)]
        /* 0xB00 */ public Vector4f[] WheelGrassPushers;
        /* 0xBA0 */ public float CreatureMassScale;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xBA4 */ public byte[] EndPadding;
    }
}
