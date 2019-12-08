using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4B8AD9586BC71CA)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0000 */ public string VehicleStrongLaser;
        /* 0x0010 */ public bool ShowAllCheckpoints;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0011 */ public byte[] Padding11;
        /* 0x0014 */ public float Unknown0x14;
        /* 0x0018 */ public float Unknown0x18;
        /* 0x001C */ public float Unknown0x1C;
        /* 0x0020 */ public float Unknown0x20;
        /* 0x0024 */ public float Unknown0x24;
        /* 0x0028 */ public float Unknown0x28;
        /* 0x002C */ public float Unknown0x2C;
        /* 0x0030 */ public float Unknown0x30;
        /* 0x0034 */ public int UnknownInt0x34;
        /* 0x0038 */ public float Unknown0x38;
        /* 0x003C */ public float TestFrictionStat;
        /* 0x0040 */ public float TestSkidFrictionStat;
        /* 0x0044 */ public bool TestAnims;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0045 */ public byte[] Padding45;
        /* 0x0048 */ public float TestAnimThrust;
        /* 0x004C */ public float TestAnimBoost;
        /* 0x0050 */ public float TestAnimTurn;
        /* 0x0054 */ public float VisualTurnUnderwaterSpring;
        /* 0x0058 */ public float VisualTurnSpring;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x005C */ public byte[] Padding5C;
        /* 0x0060 */ public Colour DefaultBoosterColour;
        /* 0x0070 */ public float WheelDustColourLightFactor;
        /* 0x0074 */ public float SubmarineMinSummonDepth;
        /* 0x0078 */ public float SubmarineEjectRadius;
        /* 0x007C */ public float SubmarineEjectDownOffset;
        /* 0x080 */ public float Unknown0x80;
        /* 0x084 */ public float Unknown0x84;
        /* 0x088 */ public float Unknown0x88;
        /* 0x08C */ public float Unknown0x8C;
        /* 0x090 */ public float Unknown0x90;
        /* 0x094 */ public float Unknown0x94;
        /* 0x098 */ public float Unknown0x98;
        /* 0x09C */ public float Unknown0x9C;
        /* 0x0A0 */ public float Unknown0xA0;
        /* 0x0A4 */ public float Unknown0xA4;
        /* 0x0A8 */ public float Unknown0xA8;
        /* 0x0AC */ public float Unknown0xAC;
        /* 0x00B0 */ public float UnderwaterBuoyancySurfaceOffset;
        /* 0x00B4 */ public float UnderwaterBuoyancyRange;
        /* 0x00B8 */ public float UnderwaterSummonSurfaceOffset;
        /* 0x00BC */ public float UnderwaterSurfaceTension;
        /* 0x00C0 */ public float UnderwaterSurfaceOffset;
        /* 0x00C4 */ public float UnderwaterSurfaceGravity;
        /* 0x00C8 */ public float UnderwaterFlattenMinDepth;
        /* 0x00CC */ public float UnderwaterFlattenRange;
        /* 0x00D0 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        /* 0x00D4 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        /* 0x00D8 */ public float UnderwaterSurfaceSplashdownForce;
        /* 0x00DC */ public float UnderwaterSurfaceSplashdownMinSpeed;
        /* 0x00E0 */ public float UnderwaterJumpForce;
        /* 0x00B4 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00D8 */ public byte[] PaddingD8;
        [NMS(Size = 0x4)]
        /* 0x00E0 */ public Vector4f[] UnderwaterBubbleOffset;

        /* 0x0150 */ public bool Unknown0x150;
        /* 0x0154 */ public float Unknown0x154;
        /* 0x0158 */ public float Unknown0x158;
        /* 0x015C */ public float VehicleBoostSpeedMultiplierPercent;
        /* 0x0160 */ public float VehicleGarageHologramMinFadeRange;
        /* 0x0164 */ public float VehicleGarageHologramFadeRange;
        /* 0x0168 */ public float CheckpointPlacementOffset;
        /* 0x016C */ public float CheckpointPlacementRayLength;
        /* 0x0170 */ public float CheckpointDeleteDistance;
        /* 0x0174 */ public float CheckpointDeleteAngle;
        /* 0x0178 */ public float BoostPadTime;
        /* 0x017C */ public float BoostPadStrength;
        /* 0x0180 */ public float DisablePhysicsRange;
        /* 0x0184 */ public float RaceMultipleStartOffset;
        /* 0x0188 */ public float RaceMultipleStartCaptureRange;
        /* 0x018C */ public float MiningLaserDrainSpeed;
        /* 0x0190 */ public float ProjectileDrainPerShot;
        /* 0x0194 */ public float RaceStartSpawnUpOffset;
        /* 0x0198 */ public float RaceInteractRespawnOffset;
        /* 0x019C */ public float RaceInteractRespawnUpOffset;
        /* 0x01A0 */ public float StickTurnReducer;
        /* 0x01A4 */ public float StickTurnReducerAlt;
        /* 0x01A8 */ public float TravelSpeedReportReducer;
        /* 0x01AC */ public float HornScareRadius;
        /* 0x01B0 */ public float HornScareFleeRadius;
        /* 0x01B4 */ public float HornScareTime;
        /* 0x01B8 */ public float AttractAmount;
        /* 0x01BC */ public float AttractMaxSpeed;
        /* 0x01C0 */ public float AttractAlign;
        /* 0x01C4 */ public float AttractDirectionBrakeThresholdSq;
        /* 0x01C8 */ public float ExitStopTime;
        /* 0x01CC */ public float ExitStopForce;
        /* 0x01D0 */ public float GunFireRate;
        /* 0x01D4 */ public float MinTurretAngle;
        /* 0x01D8 */ public float SummoningRange;
        /* 0x01DC */ public float CheckpointRadius;
        /* 0x01E0 */ public float RaceCooldown;
        /* 0x01E4 */ public float RaceResetFlashDuration;
        /* 0x01E8 */ public float RaceResetFlashIntensity;
        /* 0x01EC */ public float CheckpointFlashDuration;
        /* 0x01F0 */ public float CheckpointFlashIntensity;
        /* 0x01F4 */ public float Unknown0x1F4;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01F8 */ public byte[] Padding1F8;
        /* 0x0200 */ public Colour CheckpointBeamColourActive;
        /* 0x0210 */ public Colour CheckpointBeamColourNormal;
        [NMS(Size = 0x1)]
        /* 0x0220 */ public NMSString0x10[] DefaultBuggyLoadout;
        [NMS(Size = 0x2)]
        /* 0x0230 */ public NMSString0x10[] DefaultBikeLoadout;
        [NMS(Size = 0x2)]
        /* 0x0250 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0x0270 */ public float CheckpointBeamSizeNormal;
        /* 0x0274 */ public float CheckpointBeamSizeActive;
        /* 0x0278 */ public float CheckpointBeamOffset;
        /* 0x027C */ public float SpawnRotation;
        /* 0x0280 */ public float MiningLaserRadius;
        /* 0x0284 */ public int MiningLaserMiningDamage;
        /* 0x0288 */ public int MiningLaserDamage;
        /* 0x028C */ public float MiningLaserSpeed;
        /* 0x0290 */ public int GunBaseDamage;
        /* 0x0294 */ public int GunBaseMiningDamage;
        /* 0x0298 */ public float ResourceCollectOffset;
        /* 0x029C */ public float VehicleWheelNoise;
        /* 0x02A0 */ public float VehicleWheelNoiseScale;
        /* 0x02A4 */ public float WheelSideVerticalFactor;
        /* 0x02A8 */ public float SuspensionDamping;
        /* 0x02AC */ public float SuspensionDampingAngularFactor;
        /* 0x02B0 */ public bool ShowTempVehicleMesh;
        /* 0x02B1 */ public bool ShowVehicleDebugging;
        /* 0x02B2 */ public bool ShowVehicleWheelGuards;
        /* 0x02B3 */ public bool ShowVehicleText;
        /* 0x02B4 */ public float VehicleTextSize;
        /* 0x02B8 */ public bool ShowVehicleParticleDebug;
        /* 0x02B9 */ public bool VehicleDrawAudioDebug;
        [NMS(Size = 0x02, Ignore = true)]
        /* 0x02BA */ public byte[] Padding2BA;
        /* 0x02BC */ public float VehicleSuspensionAudioSpacing;
        /* 0x02C0 */ public float VehicleSuspensionAudioDelay;
        /* 0x02C4 */ public float VehicleSuspensionAudioScale;
        /* 0x02C8 */ public float VehicleSuspensionAudioTrigger;
        /* 0x02CC */ public float VehicleFadeTime;
        /* 0x02D0 */ public float VehicleMinSummonDistance;
        /* 0x02D4 */ public float VehicleMaxSummonDistance;
        /* 0x02D8 */ public float VehicleMaxSummonDistanceUnderwater;
        /* 0x02DC */ public float VehicleDeactivateRange;
        /* 0x02E0 */ public float VehicleBoostFuelRate;
        /* 0x02E4 */ public float VehicleBoostFuelRateSurvival;
        /* 0x02E8 */ public float VehicleFuelRate;
        /* 0x02EC */ public float VehicleFuelRateSurvival;
        /* 0x02F0 */ public float VehicleFuelRateTruckMultiplier;
        /* 0x02F4 */ public float VehicleJumpTimeMin;
        /* 0x02F8 */ public float VehicleJumpTimeMax;
        /* 0x02FC */ public float VehicleJumpCooldown;
        /* 0x0300 */ public float VehicleMotionDeadZone;
        /* 0x0304 */ public float WheelForceHalflife;
        /* 0x0308 */ public bool ThrottleButtonCamRelative;
        /* 0x030C */ public float StickReverseTurnThreshold;
        /* 0x0310 */ public float StickReverseTurnStiffness;
        /* 0x0314 */ public GcScanData VehicleScan;
        /* 0x0328 */ public GcScanData VehicleLocalScan;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x033C */ public byte[] Padding33C;
        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x0340 */ public GcVehicleData[] VehicleDataTable;
    }
}
