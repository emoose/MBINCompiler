using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x57BB1E57380C0B53)]
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
        [NMS(Size = 0x80)]
        /* 0x34 */ public string CharacterFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xB4 */ public byte[] PaddingB4;
        /* 0xB8 */ public GcSeed CharacterSeedOverride;
		/* 0xC8 */ public float DontShowCharacterWithinCameraDistance;
		/* 0xCC */ public float CharacterTurnSpeed;
		/* 0xD0 */ public float CharacterJetpackTurnSpeed;
		/* 0xD4 */ public float CharacterJetpackTurnAimSpeed;
		/* 0xD8 */ public float CharacterTurnAimSpeed;
		/* 0xDC */ public float CharacterSwimmingTurnSpeed;
		/* 0xE0 */ public float CharacterSwimmingTurnAimSpeed;
		/* 0xE4 */ public float RocketBootsLandedTurnSpeed;
		/* 0xE8 */ public float RocketBootsTurnSpeed;
		/* 0xEC */ public float FeetShiftOnTurnSpeed;
		/* 0xF0 */ public float FeetShiftOnTurnMaxSpeed;
		/* 0xF4 */ public float MinTurnAngle;
		/* 0xF8 */ public float YawPullSpeed;
		/* 0xFC */ public float GunRotationSpeed;
		/* 0x100 */ public float AimPitchAnimScale;
		/* 0x104 */ public float AimYawAnimScale;
		/* 0x108 */ public float AimPitchInterpSpeed;
		/* 0x10C */ public float MinSwimmingPitchRotation;
		/* 0x110 */ public float MaxSwimmingPitchRotation;
		/* 0x114 */ public float JetpackSwimmingPitchRotation;
		/* 0x118 */ public float MinSwimmingRollRotation;
		/* 0x11C */ public float MaxSwimmingRollRotation;
		/* 0x120 */ public float SwimmingSmoothTime;
		/* 0x124 */ public float SwimmingSmoothTimeWithWeapon;
		/* 0x128 */ public float SwimmingRollSmoothTime;
		/* 0x12C */ public float SwimmingRollSmoothTimeWithWeapon;
		/* 0x130 */ public float LadderDistanceToAutoMount;
		/* 0x134 */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Size = 0x10)]
        /* 0x138 */ public string LadderClimbIdle;
        [NMS(Size = 0x10)]
        /* 0x148 */ public string LadderClimbUp;
        [NMS(Size = 0x10)]
        /* 0x158 */ public string LadderClimbDown;
        [NMS(Size = 0x10)]
        /* 0x168 */ public string LadderMountBottom;
        [NMS(Size = 0x10)]
        /* 0x178 */ public string LadderDismountBottom;
        [NMS(Size = 0x10)]
        /* 0x188 */ public string LadderMountTop;
        [NMS(Size = 0x10)]
        /* 0x198 */ public string LadderDismountTop;
		/* 0x1A8 */ public float SlopeAngleForUphillClimb;
		/* 0x1AC */ public float SlopeAngleForDownhillClimb;
		/* 0x1B0 */ public float SlidingBrake;
		/* 0x1B4 */ public float SlopeAngleForSlide;
		/* 0x1B8 */ public float UphillSpeedMultiplier;
		/* 0x1BC */ public float TrudgeUphillSpeed;
		/* 0x1C0 */ public float MaxAnkleRotationAngle;
		/* 0x1C4 */ public float RotateToFaceSlopeSpeed;
		/* 0x1C8 */ public float TimeNotOnGroundToBeConsideredInAir;
		/* 0x1CC */ public float TimeNotOnGroundToUseFallingCamera;
		/* 0x1D0 */ public float TimeFallingUntilPanic;
		/* 0x1D4 */ public float BankingMinimumSpeed;
		/* 0x1D8 */ public float BankingMaxStrength;
		/* 0x1DC */ public float BankingSpeedForMaxStrength;
		/* 0x1E0 */ public float MinimumIdleToJogAnimSpeed;
		/* 0x1E4 */ public float RootedAnimInterpolationTime;
		/* 0x1E8 */ public float IKLegStretchStrength;
		/* 0x1EC */ public float IkBlendStrengthSpeed;
		/* 0x1F0 */ public float FootPlantedTolerance;
		/* 0x1F4 */ public float FootPlantSpring;
		/* 0x1F8 */ public float BlendToNewFeetSpeed;
		/* 0x1FC */ public float TimeAfterDeathRagdollIsEnabledForward;
		/* 0x200 */ public float TimeAfterDeathRagdollIsEnabledBackward;
		/* 0x204 */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
		/* 0x208 */ public float RagdollTau;
		/* 0x20C */ public float RagdollDamping;
		/* 0x210 */ public float RagdollConeLimit;
		/* 0x214 */ public float RagdollTwistLimit;
		/* 0x218 */ public float RagdollMotorFadeStart;
		/* 0x21C */ public float RagdollMotorFadeEnd;
		/* 0x220 */ public float MinStickForIntoJogAnim;
		/* 0x224 */ public float SmoothVelocitySpeed;
		/* 0x228 */ public float TimeToShowSplashEffect;
		/* 0x22C */ public float UnderwaterToAirTolerance;
		/* 0x230 */ public float WaterBottomSmoothPushUp;
		/* 0x234 */ public float WaterBottomSmoothPushUpDepth;
    }
}
