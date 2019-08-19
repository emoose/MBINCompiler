using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x72E67855FFA1A753)]
    public class GcCharacterGlobals : NMSTemplate
    {
		/* 0x0 */ public float PitchTest;
		/* 0x4 */ public float RollTest;
		/* 0x8 */ public float WaterEffectHeightOffset;
		/* 0xC */ public float WaterEffectHeightRange;
		/* 0x10 */ public float WaterEffectFadeSpring;
		/* 0x14 */ public float WaterEffectSpeedFade;
		/* 0x18 */ public float WaterEffectSpeedFadeMin;
		/* 0x1C */ public float WaterEffectSpeedOffset;
		/* 0x20 */ public float WaterEffectMinScale;
		/* 0x24 */ public float WaterEffectSideOffset;
		/* 0x28 */ public float WaterEffectRearOffset;
		/* 0x2C */ public float WaterEffectRearBackOffset;
		/* 0x30 */ public float CharacterRotationOffsetY;
        /* 0x34 */ public float Unknown0x34;
        [NMS(Size = 0x80)]
        /* 0x38 */ public string CharacterFile;
        /* 0xB8 */ public GcSeed CharacterSeedOverride;
		/* 0xC8 */ public float DontShowCharacterWithinCameraDistance;
		/* 0xCC */ public float CharacterTurnSpeed;
        /* 0xD0 */ public float Unknown0xD0;
		/* 0xD4 */ public float CharacterJetpackTurnSpeed;
		/* 0xD8 */ public float CharacterJetpackTurnAimSpeed;
		/* 0xDC */ public float CharacterTurnAimSpeed;
		/* 0xE0 */ public float CharacterSwimmingTurnSpeed;
		/* 0xE4 */ public float CharacterSwimmingTurnAimSpeed;
		/* 0xE8 */ public float RocketBootsLandedTurnSpeed;
		/* 0xEC */ public float RocketBootsTurnSpeed;
		/* 0xF0 */ public float FeetShiftOnTurnSpeed;
		/* 0xF4 */ public float FeetShiftOnTurnMaxSpeed;
		/* 0xF8 */ public float MinTurnAngle;
		/* 0xFC */ public float YawPullSpeed;
		/* 0x100 */ public float GunRotationSpeed;
		/* 0x104 */ public float AimPitchAnimScale;
		/* 0x108 */ public float AimYawAnimScale;
		/* 0x10C */ public float AimPitchInterpSpeed;
		/* 0x110 */ public float MinSwimmingPitchRotation;
		/* 0x114 */ public float MaxSwimmingPitchRotation;
		/* 0x118 */ public float JetpackSwimmingPitchRotation;
		/* 0x11C */ public float MinSwimmingRollRotation;
		/* 0x120 */ public float MaxSwimmingRollRotation;
		/* 0x124 */ public float SwimmingSmoothTime;
		/* 0x128 */ public float SwimmingSmoothTimeWithWeapon;
		/* 0x12C */ public float SwimmingRollSmoothTime;
		/* 0x130 */ public float SwimmingRollSmoothTimeWithWeapon;
		/* 0x134 */ public float LadderDistanceToAutoMount;
		/* 0x138 */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x13C */ public byte[] Padding13C;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string LadderClimbIdle;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string LadderClimbUp;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string LadderClimbDown;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string LadderMountBottom;
        [NMS(Size = 0x10)]
        /* 0x180 */ public string LadderDismountBottom;
        [NMS(Size = 0x10)]
        /* 0x190 */ public string LadderMountTop;
        [NMS(Size = 0x10)]
        /* 0x1A0 */ public string LadderDismountTop;
		/* 0x1B0 */ public float SlopeAngleForUphillClimb;
		/* 0x1B4 */ public float SlopeAngleForDownhillClimb;
		/* 0x1B8 */ public float SlidingBrake;
		/* 0x1BC */ public float SlopeAngleForSlide;
		/* 0x1C0 */ public float UphillSpeedMultiplier;
		/* 0x1C4 */ public float TrudgeUphillSpeed;
		/* 0x1C8 */ public float MaxAnkleRotationAngle;
		/* 0x1CC */ public float RotateToFaceSlopeSpeed;
		/* 0x1D0 */ public float TimeNotOnGroundToBeConsideredInAir;
		/* 0x1D4 */ public float TimeNotOnGroundToUseFallingCamera;
		/* 0x1D8 */ public float TimeFallingUntilPanic;
		/* 0x1DC */ public float BankingMinimumSpeed;
		/* 0x1E0 */ public float BankingMaxStrength;
		/* 0x1E4 */ public float BankingSpeedForMaxStrength;
		/* 0x1E8 */ public float MinimumIdleToJogAnimSpeed;
		/* 0x1EC */ public float RootedAnimInterpolationTime;
		/* 0x1F0 */ public float IKLegStretchStrength;
		/* 0x1F4 */ public float IkBlendStrengthSpeed;
		/* 0x1F8 */ public float FootPlantedTolerance;
		/* 0x1FC */ public float FootPlantSpring;
		/* 0x200 */ public float BlendToNewFeetSpeed;
		/* 0x204 */ public float TimeAfterDeathRagdollIsEnabledForward;
		/* 0x208 */ public float TimeAfterDeathRagdollIsEnabledBackward;
		/* 0x20C */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
		/* 0x210 */ public float RagdollTau;
		/* 0x214 */ public float RagdollDamping;
		/* 0x218 */ public float RagdollConeLimit;
		/* 0x21C */ public float RagdollTwistLimit;
		/* 0x220 */ public float RagdollMotorFadeStart;
		/* 0x224 */ public float RagdollMotorFadeEnd;
		/* 0x228 */ public float MinStickForIntoJogAnim;
		/* 0x22C */ public float SmoothVelocitySpeed;
		/* 0x230 */ public float TimeToShowSplashEffect;
		/* 0x234 */ public float UnderwaterToAirTolerance;
		/* 0x238 */ public float WaterBottomSmoothPushUp;
		/* 0x23C */ public float WaterBottomSmoothPushUpDepth;
        /* 0x240 */ public float Unknown0x240;
        /* 0x244 */ public float Unknown0x244;
        /* 0x248 */ public int UnknownInt0x248;
        /* 0x24C */ public int UnknownInt0x24C;
        /* 0x250 */ public float Unknown0x250;
        /* 0x254 */ public float Unknown0x254;
        /* 0x258 */ public float Unknown0x258;
        /* 0x25C */ public float Unknown0x25C;
        /* 0x260 */ public float Unknown0x260;
        /* 0x264 */ public float Unknown0x264;
        /* 0x268 */ public float Unknown0x268;
        /* 0x26C */ public float Unknown0x26C;
        /* 0x270 */ public float Unknown0x270;
        /* 0x274 */ public float Unknown0x274;
        /* 0x278 */ public float Unknown0x278;
        /* 0x27C */ public float Unknown0x27C;
        /* 0x280 */ public float Unknown0x280;
        /* 0x284 */ public float Unknown0x284;
        /* 0x288 */ public float Unknown0x288;
        /* 0x28C */ public float Unknown0x28C;
        /* 0x290 */ public float Unknown0x290;
        /* 0x294 */ public float Unknown0x294;
        /* 0x298 */ public float Unknown0x298;
        /* 0x29C */ public float Unknown0x29C;
        /* 0x2A0 */ public float Unknown0x2A0;
        /* 0x2A4 */ public float Unknown0x2A4;
        /* 0x2A8 */ public float Unknown0x2A8;
        /* 0x2AC */ public float Unknown0x2AC;
        /* 0x2B0 */ public float Unknown0x2B0;
        /* 0x2B4 */ public float Unknown0x2B4;
        /* 0x2B8 */ public float Unknown0x2B8;
        /* 0x2BC */ public float Unknown0x2BC;
        /* 0x2C0 */ public float Unknown0x2C0;
        /* 0x2C4 */ public float Unknown0x2C4;
        /* 0x2C8 */ public float Unknown0x2C8;
        /* 0x2CC */ public float Unknown0x2CC;
        /* 0x2D0 */ public float Unknown0x2D0;
        /* 0x2D4 */ public float Unknown0x2D4;
        /* 0x2D8 */ public float Unknown0x2D8;
        /* 0x2DC */ public float Unknown0x2DC;
        /* 0x2E0 */ public float Unknown0x2E0;
        /* 0x2E4 */ public float Unknown0x2E4;
        /* 0x2E8 */ public float Unknown0x2E8;
        /* 0x2EC */ public float Unknown0x2EC;
        /* 0x2F0 */ public float Unknown0x2F0;
        /* 0x2F4 */ public float Unknown0x2F4;
        /* 0x2F8 */ public float Unknown0x2F8;
        /* 0x2FC */ public float Unknown0x2FC;
        /* 0x300 */ public float Unknown0x300;
        /* 0x304 */ public float Unknown0x304;
        /* 0x308 */ public float Unknown0x308;
        /* 0x30C */ public float Unknown0x30C;
        /* 0x310 */ public float Unknown0x310;
        /* 0x314 */ public float Unknown0x314;
        /* 0x318 */ public float Unknown0x318;
        /* 0x31C */ public float Unknown0x31C;
        /* 0x320 */ public float Unknown0x320;
        /* 0x324 */ public float Unknown0x324;
        /* 0x328 */ public float Unknown0x328;
        /* 0x32C */ public float Unknown0x32C;
        /* 0x330 */ public float Unknown0x330;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x334 */ public byte[] EndPadding;
    }
}
