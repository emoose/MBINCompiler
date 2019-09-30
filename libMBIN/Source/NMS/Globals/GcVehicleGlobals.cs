using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1A3ED2E360B2478E)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0000 */ public string VehicleStrongLaser;
        /* 0x0010 */ public bool ShowAllCheckpoints;
                     [NMS(Size = 0x03, Ignore = true)]
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
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x0045 */ public byte[] Padding45;
        /* 0x0048 */ public float TestAnimThrust;
        /* 0x004C */ public float TestAnimBoost;
        /* 0x0050 */ public float TestAnimTurn;
        /* 0x0054 */ public float VisualTurnUnderwaterSpring;
        /* 0x0058 */ public float VisualTurnSpring;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x005C */ public byte[] Padding5C;
        /* 0x0060 */ public Colour DefaultBoosterColour;
        /* 0x0070 */ public float WheelDustColourLightFactor;
        /* 0x0074 */ public float SubmarineMinSummonDepth;
        /* 0x0078 */ public float SubmarineEjectRadius;
        /* 0x007C */ public float SubmarineEjectDownOffset;
        /* 0x0080 */ public float UnderwaterBuoyancySurfaceOffset;
        /* 0x0084 */ public float UnderwaterBuoyancyRange;
        /* 0x0088 */ public float UnderwaterSummonSurfaceOffset;
        /* 0x008C */ public float UnderwaterSurfaceTension;
        /* 0x0090 */ public float UnderwaterSurfaceOffset;
        /* 0x0094 */ public float UnderwaterSurfaceGravity;
        /* 0x0098 */ public float UnderwaterFlattenMinDepth;
        /* 0x009C */ public float UnderwaterFlattenRange;
        /* 0x00A0 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        /* 0x00A4 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        /* 0x00A8 */ public float UnderwaterSurfaceSplashdownForce;
        /* 0x00AC */ public float UnderwaterSurfaceSplashdownMinSpeed;
        /* 0x00B0 */ public float UnderwaterJumpForce;
        /* 0x00B4 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x00D8 */ public byte[] PaddingD8;
                     [NMS(Size = 0x04)]
        /* 0x00E0 */ public Vector4f[] UnderwaterBubbleOffset;
        /* 0x0120 */ public float VehicleBoostSpeedMultiplierPercent;
        /* 0x0124 */ public float VehicleGarageHologramMinFadeRange;
        /* 0x0128 */ public float VehicleGarageHologramFadeRange;
        /* 0x012C */ public float CheckpointPlacementOffset;
        /* 0x0130 */ public float CheckpointPlacementRayLength;
        /* 0x0134 */ public float CheckpointDeleteDistance;
        /* 0x0138 */ public float CheckpointDeleteAngle;
        /* 0x013C */ public float BoostPadTime;
        /* 0x0140 */ public float BoostPadStrength;
        /* 0x0144 */ public float DisablePhysicsRange;
        /* 0x0148 */ public float RaceMultipleStartOffset;
        /* 0x014C */ public float RaceMultipleStartCaptureRange;
        /* 0x0150 */ public float MiningLaserDrainSpeed;
        /* 0x0154 */ public float ProjectileDrainPerShot;
        /* 0x0158 */ public float RaceStartSpawnUpOffset;
        /* 0x015C */ public float RaceInteractRespawnOffset;
        /* 0x0160 */ public float RaceInteractRespawnUpOffset;
        /* 0x0164 */ public float StickTurnReducer;
        /* 0x0168 */ public float StickTurnReducerAlt;
        /* 0x016C */ public float TravelSpeedReportReducer;
        /* 0x0170 */ public float HornScareRadius;
        /* 0x0174 */ public float HornScareFleeRadius;
        /* 0x0178 */ public float HornScareTime;
        /* 0x017C */ public float AttractAmount;
        /* 0x0180 */ public float AttractMaxSpeed;
        /* 0x0184 */ public float AttractAlign;
        /* 0x0188 */ public float AttractDirectionBrakeThresholdSq;
        /* 0x018C */ public float ExitStopTime;
        /* 0x0190 */ public float ExitStopForce;
        /* 0x0194 */ public float GunFireRate;
        /* 0x0198 */ public float MinTurretAngle;
        /* 0x019C */ public float SummoningRange;
        /* 0x01A0 */ public float CheckpointRadius;
        /* 0x01A4 */ public float RaceCooldown;
        /* 0x01A8 */ public float RaceResetFlashDuration;
        /* 0x01AC */ public float RaceResetFlashIntensity;
        /* 0x01B0 */ public float CheckpointFlashDuration;
        /* 0x01B4 */ public float CheckpointFlashIntensity;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x01B8 */ public byte[] Padding1B8;
        /* 0x01C0 */ public Colour CheckpointBeamColourActive;
        /* 0x01D0 */ public Colour CheckpointBeamColourNormal;
                     [NMS(Size = 0x01)]
        /* 0x01E0 */ public NMSString0x10[] DefaultBuggyLoadout;
                     [NMS(Size = 0x02)]
        /* 0x01F0 */ public NMSString0x10[] DefaultBikeLoadout;
                     [NMS(Size = 0x02)]
        /* 0x0210 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0x0230 */ public float CheckpointBeamSizeNormal;
        /* 0x0234 */ public float CheckpointBeamSizeActive;
        /* 0x0238 */ public float CheckpointBeamOffset;
        /* 0x023C */ public float SpawnRotation;
        /* 0x0240 */ public float MiningLaserRadius;
        /* 0x0244 */ public int MiningLaserMiningDamage;
        /* 0x0248 */ public int MiningLaserDamage;
        /* 0x024C */ public float MiningLaserSpeed;
        /* 0x0250 */ public int GunBaseDamage;
        /* 0x0254 */ public int GunBaseMiningDamage;
        /* 0x0258 */ public float ResourceCollectOffset;
        /* 0x025C */ public float VehicleWheelNoise;
        /* 0x0260 */ public float VehicleWheelNoiseScale;
        /* 0x0264 */ public float WheelSideVerticalFactor;
        /* 0x0268 */ public float SuspensionDamping;
        /* 0x026C */ public float SuspensionDampingAngularFactor;
        /* 0x0270 */ public bool ShowTempVehicleMesh;
        /* 0x0271 */ public bool ShowVehicleDebugging;
        /* 0x0272 */ public bool ShowVehicleWheelGuards;
        /* 0x0273 */ public bool ShowVehicleText;
        /* 0x0274 */ public float VehicleTextSize;
        /* 0x0278 */ public bool ShowVehicleParticleDebug;
        /* 0x0279 */ public bool VehicleDrawAudioDebug;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x027A */ public byte[] Padding27A;
        /* 0x027C */ public float VehicleSuspensionAudioSpacing;
        /* 0x0280 */ public float VehicleSuspensionAudioDelay;
        /* 0x0284 */ public float VehicleSuspensionAudioScale;
        /* 0x0288 */ public float VehicleSuspensionAudioTrigger;
        /* 0x028C */ public float VehicleFadeTime;
        /* 0x0290 */ public float VehicleMinSummonDistance;
        /* 0x0294 */ public float VehicleMaxSummonDistance;
        /* 0x0298 */ public float VehicleMaxSummonDistanceUnderwater;
        /* 0x029C */ public float VehicleDeactivateRange;
        /* 0x02A0 */ public float VehicleBoostFuelRate;
        /* 0x02A4 */ public float VehicleBoostFuelRateSurvival;
        /* 0x02A8 */ public float VehicleFuelRate;
        /* 0x02AC */ public float VehicleFuelRateSurvival;
        /* 0x02B0 */ public float VehicleFuelRateTruckMultiplier;
        /* 0x02B4 */ public float VehicleJumpTimeMin;
        /* 0x02B8 */ public float VehicleJumpTimeMax;
        /* 0x02BC */ public float VehicleJumpCooldown;
        /* 0x02C0 */ public float VehicleMotionDeadZone;
        /* 0x02C4 */ public float WheelForceHalflife;
        /* 0x02C8 */ public bool ThrottleButtonCamRelative;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x02C9 */ public byte[] Padding2C9;
        /* 0x02CC */ public float StickReverseTurnThreshold;
        /* 0x02D0 */ public float StickReverseTurnStiffness;
        /* 0x02D4 */ public GcScanData VehicleScan;
        /* 0x02E8 */ public GcScanData VehicleLocalScan;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x02FC */ public byte[] Padding2FC;
                     [NMS(Size = 0x06, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x0300 */ public GcVehicleData[] VehicleDataTable;
    }
}
