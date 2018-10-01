using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFF1BC076103D0E5E, Size = 0xC00)]
    public class GcVehicleData : NMSTemplate
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
        /* 0x350 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Size = 0xA)]
        /* 0x378 */ public float[] WheelRadiusMultiplier;
        [NMS(Size = 0xA)]
        /* 0x3A0 */ public NMSString0x10[] SuspensionAnimNames;
        /* 0x340 */ public Vector4f CollOffset;
        /* 0x450 */ public Vector4f ExtraCollOffset;
        /* 0x460 */ public Vector4f CollDimensions;
        /* 0x470 */ public Vector4f InertiaDimensions;

        /* 0x480 */ public float CollRadius;
        /* 0x484 */ public float InertiaMull;
        /* 0x488 */ public float WheelSuspensionlength;
        /* 0x48C */ public float WheelSuspensionForce;
        /* 0x490 */ public float WheelSuspensionDamping;
        /* 0x494 */ public float WheelSuspensionAnimMin;
        /* 0x498 */ public float WheelSuspensionAnimMax;
        /* 0x49C */ public float TopSpeedForward;
        /* 0x4A0 */ public float TopSpeedReverse;
        /* 0x4A4 */ public float WheelMaxAccelForceForward;
        /* 0x4A8 */ public float WheelMaxAccelForceReverse;
        /* 0x4AC */ public float WheelMaxDecelForceNonBraking;
        /* 0x4B0 */ public float WheelMaxDecelForceBraking;
        /* 0x4B4 */ public float WheelSpinniness;
        /* 0x4B8 */ public float WheelDragginess;
        /* 0x4BC */ public float HardStopSpeedThreshold;
        /* 0x4C0 */ public float WheelFrontFrictionOmega;
        /* 0x4C4 */ public float WheelFrontFrictionDynamic;
        /* 0x4C8 */ public float WheelFrontFrictionDynamicThreshold;
        /* 0x4CC */ public float WheelFrontFrictionStatic;
        /* 0x4D0 */ public float WheelFrontFrictionStaticThreshold;
        /* 0x4D4 */ public float WheelSideFrictionOmega;
        /* 0x4D8 */ public float WheelSideFrictionDynamic;
        /* 0x4DC */ public float WheelSideFrictionDynamicThreshold;
        /* 0x4E0 */ public float WheelSideFrictionStatic;
        /* 0x4E4 */ public float WheelSideFrictionStaticThreshold;
        /* 0x4E8 */ public float TurningWheelForce;
        /* 0x4EC */ public float TurningWheelFrictionOmega;
        /* 0x4F0 */ public float TurningWheelFrictionNonBraking;
        /* 0x4F4 */ public float TurningWheelFrictionBraking;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4F8 */ public byte[] Padding4F8;

        /* 0x500 */ public Vector4f WheelForwardAngularFactor;
        /* 0x510 */ public Vector4f WheelTurnAngularFactor;
        /* 0x520 */ public Vector4f WheelSuspensionAngularFactor;
        /* 0x530 */ public Vector4f WheelSideAngularFactor;
        /* 0x540 */ public float VehicleGravity;
        /* 0x544 */ public float VehicleGravityWater;
        /* 0x548 */ public float VehicleJumpForce;
        /* 0x54C */ public float VehicleJumpAirControlForce;
        /* 0x550 */ public float VehicleBoostForce;
        /* 0x554 */ public float VehicleBoostMaxSpeed;
        /* 0x554 */ public float VehicleBoostExtraMaxSpeedAir;
        /* 0x55C */ public float VehicleBoostSpeedFalloff;
        /* 0x560 */ public float VehicleBoostTime;
        /* 0x564 */ public float VehicleBoostRechargeTime;
        /* 0x568 */ public float VehicleJumpAirRotatexAmount;
        /* 0x56C */ public float VehicleJumpAirRotateZAmount;
        /* 0x570 */ public float VehicleJumpAirRotateTimeMin;
        /* 0x574 */ public float VehicleJumpAirRotateTimeMax;
        /* 0x578 */ public float VehicleJumpAirMaxTorque;
        /* 0x57C */ public bool UseBuggySuspensionHack;
        /* 0x57D */ public bool UseRoverWheelHack;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x57E */ public byte[] Padding57E;

        [NMS(Size = 0x10)]
        /* 0x580 */ public string SideSkidParticle;
        /* 0x590 */ public float SideSkidParticleMinRate;
        /* 0x594 */ public float SideSkidParticleMaxRate;
        /* 0x598 */ public float SideSkidParticleMinThresh;
        /* 0x59C */ public float SideSkidParticleMaxThresh;

        [NMS(Size = 0x10)]
        /* 0x5A0 */ public string WheelSpinParticle;
        /* 0x5B0 */ public float WheelSpinParticleMinRate;
        /* 0x5B4 */ public float WheelSpinParticleMaxRate;
        /* 0x5B8 */ public float WheelSpinParticleMinThresh;
        /* 0x5BC */ public float WheelSpinParticleMaxThresh;
        /* 0x5C0 */ public float WheelGuardVerticalResponseMin;
        /* 0x5C4 */ public float WheelGuardVerticalResponseMax;
        /* 0x5C8 */ public float WheelGuardPenetrationScaleMin;
        /* 0x5CC */ public float WheelGuardPenetrationScaleMax;
        /* 0x5D0 */ public float WheelGuardPenetrationScaleMinClamp;
        /* 0x5D4 */ public float WheelGuardMassScaleMin;
        /* 0x5D8 */ public float WheelGuardMassScaleMax;
        /* 0x5DC */ public float WheelGuardMassScaleMinClamp;
        /* 0x5E0 */ public float VehicleLinearDampingGround;
        /* 0x5E4 */ public float VehicleAngularDampingGround;
        /* 0x5E8 */ public float VehicleLinearDampingAerial;
        /* 0x5EC */ public float VehicleAngularDampingAerial;
        /* 0x5F0 */ public float VehicleLinearDampingWater;
        /* 0x5F4 */ public float VehicleAngularDampingWater;
        /* 0x5F8 */ public float WheelStartHeight;
        /* 0x5FC */ public float WheelEndHeight;
        /* 0x600 */ public float VehicleComCheat;
        /* 0x604 */ public float VehicleAudioSpeedMul;
        /* 0x608 */ public float VehicleAudioTorqueMul;
        /* 0x60C */ public float VehicleAudioSideSkidMul;
        /* 0x610 */ public float VehicleAudioSideSkidThreshold;
        /* 0x614 */ public float VehicleAudioSpinSkidMul;
        /* 0x618 */ public float VehicleAudioSpinSkidThreshold;
        /* 0x61C */ public float AudioImpactSpeedThreshold;
        /* 0x620 */ public float AudioImpactSpeedMul;
        /* 0x624 */ public bool VehicleAudioSwapSkidAndSpeed;
        [NMS(Size = 0x80)]
        /* 0x625 */ public string AudioBoostStart;
        [NMS(Size = 0x80)]
        /* 0x6A5 */ public string AudioBoostStop;
        [NMS(Size = 0x80)]
        /* 0x725 */ public string AudioHornStart;
        [NMS(Size = 0x80)]
        /* 0x7A5 */ public string AudioHornStop;
        [NMS(Size = 0x80)]
        /* 0x825 */ public string AudioIdleExterior;
        [NMS(Size = 0x80)]
        /* 0x8A5 */ public string AudioImpacts;
        [NMS(Size = 0x80)]
        /* 0x925 */ public string AudioStart;
        [NMS(Size = 0x80)]
        /* 0x9A5 */ public string AudioStop;
        [NMS(Size = 0x80)]
        /* 0xA25 */ public string AudioSuspension;
        [NMS(Size = 0x80)]
        /* 0xAA5 */ public string AudioJump;

        /* 0xB25 */ public bool DriveOnTopOfWater;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0xB26 */ public byte[] PaddingB26;
        /* 0xB28 */ public float VehicleUnderwaterRotateTime;
        /* 0xB2C */ public float VehicleAudioSuspensionThreshold;
        /* 0xB30 */ public float VehicleAudioSuspensionScale;
        /* 0xB34 */ public int NumGrassPushers;
        /* 0xB38 */ public float WheelGrassPusherStrength;
        /* 0xB3C */ public float WheelGrassPusherWobble;
        /* 0xB40 */ public float WheelGrassPusherFrequency;
        /* 0xB44 */ public float WheelGrassPusherReduce;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xB48 */ public byte[] PaddingB48;
        [NMS(Size = 0xA)]
        /* 0xB50 */ public Vector4f[] WheelGrassPushers;
        /* 0xBF0 */ public float CreatureMassScale;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xBF4 */ public byte[] EndPadding;
    }
}
