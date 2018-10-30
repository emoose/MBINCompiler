using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x780A566AD70FB20D)]
    public class GcVehicleGlobals : NMSTemplate
    {
		[NMS(Size = 0x10)]
		/* 0x0 */ public string VehicleStrongLaser;
		/* 0x10 */ public bool ShowAllCheckpoints;
		/* 0x14 */ public float TestFrictionStat;
		/* 0x18 */ public float TestSkidFrictionStat;
		/* 0x1C */ public bool TestAnims;
		/* 0x20 */ public float TestAnimThrust;
		/* 0x24 */ public float TestAnimBoost;
		/* 0x28 */ public float TestAnimTurn;

		/* 0x2C */ public float VisualTurnUnderwaterSpring;
		/* 0x30 */ public float VisualTurnSpring;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x34 */ public byte[] Padding34;
		/* 0x40 */ public Colour DefaultBoosterColour;
		/* 0x50 */ public float WheelDustColourLightFactor;
		/* 0x54 */ public float SubmarineMinSummonDepth;
		/* 0x58 */ public float SubmarineEjectRadius;
		/* 0x5C */ public float SubmarineEjectDownOffset;
		/* 0x60 */ public float UnderwaterBuoyancySurfaceOffset;
		/* 0x64 */ public float UnderwaterBuoyancyRange;
		/* 0x68 */ public float UnderwaterSummonSurfaceOffset;
		/* 0x6C */ public float UnderwaterSurfaceTension;
		/* 0x70 */ public float UnderwaterSurfaceOffset;
		/* 0x74 */ public float UnderwaterSurfaceGravity;
		/* 0x78 */ public float UnderwaterFlattenMinDepth;
		/* 0x7C */ public float UnderwaterFlattenRange;
		/* 0x80 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
		/* 0x84 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
		/* 0x88 */ public float UnderwaterSurfaceSplashdownForce;
		/* 0x8C */ public float UnderwaterSurfaceSplashdownMinSpeed;
		/* 0x90 */ public float UnderwaterJumpForce;
        /* 0x94 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xB8 */ public byte[] PaddingB8;
        [NMS(Size = 0x4)]
        /* 0xC0 */ public Vector4f[] UnderwaterBubbleOffset;
		/* 0x100 */ public float VehicleBoostSpeedMultiplierPercent;
		/* 0x104 */ public float VehicleGarageHologramMinFadeRange;
		/* 0x108 */ public float VehicleGarageHologramFadeRange;
		/* 0x10C */ public float CheckpointPlacementOffset;
		/* 0x110 */ public float CheckpointPlacementRayLength;
		/* 0x114 */ public float CheckpointDeleteDistance;
		/* 0x118 */ public float CheckpointDeleteAngle;
		/* 0x11C */ public float BoostPadTime;
		/* 0x120 */ public float BoostPadStrength;
		/* 0x124 */ public float DisablePhysicsRange;
		/* 0x128 */ public float RaceMultipleStartOffset;
		/* 0x12C */ public float RaceMultipleStartCaptureRange;
		/* 0x130 */ public float MiningLaserDrainSpeed;
		/* 0x134 */ public float ProjectileDrainPerShot;
		/* 0x138 */ public float RaceStartSpawnUpOffset;
		/* 0x13C */ public float RaceInteractRespawnOffset;
		/* 0x140 */ public float RaceInteractRespawnUpOffset;
		/* 0x144 */ public float StickTurnReducer;
		/* 0x148 */ public float TravelSpeedReportReducer;
		/* 0x14C */ public float HornScareRadius;
		/* 0x150 */ public float HornScareFleeRadius;
		/* 0x154 */ public float HornScareTime;
		/* 0x158 */ public float AttractAmount;
		/* 0x15C */ public float AttractMaxSpeed;
		/* 0x160 */ public float AttractAlign;
		/* 0x164 */ public float AttractDirectionBrakeThresholdSq;
		/* 0x168 */ public float ExitStopTime;
		/* 0x16C */ public float ExitStopForce;
		/* 0x170 */ public float GunFireRate;
		/* 0x174 */ public float MinTurretAngle;
		/* 0x178 */ public float SummoningRange;
		/* 0x17C */ public float CheckpointRadius;
		/* 0x180 */ public float RaceCooldown;
		/* 0x184 */ public float RaceResetFlashDuration;
		/* 0x188 */ public float RaceResetFlashIntensity;
		/* 0x18C */ public float CheckpointFlashDuration;
		/* 0x190 */ public float CheckpointFlashIntensity;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x194 */ public byte[] Padding194;
		/* 0x1A0 */ public Colour CheckpointBeamColourActive;
        /* 0x1B0 */ public Colour CheckpointBeamColourNormal;
        [NMS(Size = 0x10)]
        /* 0x1C0 */ public string DefaultBuggyLoadout;
        [NMS(Size = 0x2)]
        /* 0x1D0 */ public NMSString0x10[] DefaultBikeLoadout;
        [NMS(Size = 0x2)]
        /* 0x1F0 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0x210 */ public float CheckpointBeamSizeNormal;
		/* 0x214 */ public float CheckpointBeamSizeActive;
		/* 0x218 */ public float CheckpointBeamOffset;
		/* 0x21C */ public float SpawnRotation;
		/* 0x220 */ public float MiningLaserRadius;
		/* 0x224 */ public int MiningLaserMiningDamage;
		/* 0x228 */ public int MiningLaserDamage;
		/* 0x22C */ public float MiningLaserSpeed;
		/* 0x230 */ public int GunBaseDamage;
		/* 0x234 */ public int GunBaseMiningDamage;
		/* 0x238 */ public float ResourceCollectOffset;
		/* 0x23C */ public float VehicleWheelNoise;
		/* 0x240 */ public float VehicleWheelNoiseScale;
		/* 0x244 */ public float WheelSideVerticalFactor;
		/* 0x248 */ public float SuspensionDamping;
		/* 0x24C */ public float SuspensionDampingAngularFactor;
		/* 0x250 */ public bool ShowTempVehicleMesh;
		/* 0x251 */ public bool ShowVehicleDebugging;
		/* 0x252 */ public bool ShowVehicleWheelGuards;
		/* 0x253 */ public bool ShowVehicleText;
		/* 0x254 */ public float VehicleTextSize;
		/* 0x258 */ public bool ShowVehicleParticleDebug;
		/* 0x259 */ public bool VehicleDrawAudioDebug;
		/* 0x25C */ public float VehicleSuspensionAudioSpacing;
		/* 0x260 */ public float VehicleSuspensionAudioDelay;
		/* 0x264 */ public float VehicleSuspensionAudioScale;
		/* 0x268 */ public float VehicleSuspensionAudioTrigger;
		/* 0x26C */ public float VehicleFadeTime;
		/* 0x270 */ public float VehicleMinSummonDistance;
		/* 0x274 */ public float VehicleMaxSummonDistance;
		/* 0x278 */ public float VehicleMaxSummonDistanceUnderwater;
		/* 0x27C */ public float VehicleDeactivateRange;
		/* 0x280 */ public float VehicleBoostFuelRate;
		/* 0x284 */ public float VehicleBoostFuelRateSurvival;
		/* 0x288 */ public float VehicleFuelRate;
		/* 0x28C */ public float VehicleFuelRateSurvival;
		/* 0x290 */ public float VehicleFuelRateTruckMultiplier;
		/* 0x294 */ public float VehicleJumpTimeMin;
		/* 0x298 */ public float VehicleJumpTimeMax;
		/* 0x29C */ public float VehicleJumpCooldown;
		/* 0x2A0 */ public float WheelForceHalflife;
		/* 0x2A4 */ public bool ThrottleButtonCamRelative;
		/* 0x2A8 */ public float StickReverseTurnThreshold;
		/* 0x2AC */ public float StickReverseTurnStiffness;
        /* 0x2B0 */ public GcScanData VehicleScan;
        /* 0x2C4 */ public GcScanData VehicleLocalScan;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2D8 */ public byte[] Padding2D8;
        [NMS(Size = 0x6, EnumValue = new[] { "Bike", "Buggy", "Truck", "WheeledBike", "Hovercraft", "Submarine" })]
        /* 0x2E0 */ public GcVehicleData[] VehicleDataTable;

    }
}
