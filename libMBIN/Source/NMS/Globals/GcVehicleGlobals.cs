using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xBC8FE511DDCD0705)]
    public class GcVehicleGlobals : NMSTemplate
    {
                     [NMS(Size = 0x10)]
        /* 0x0000 */ public string VehicleStrongLaser;
        /* 0x0010 */ public bool ShowAllCheckpoints;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0011 */ public byte[] Padding11;
        /* 0x0014 */ public float TestFrictionStat;
        /* 0x0018 */ public float TestSkidFrictionStat;
        /* 0x001C */ public bool TestAnims;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x001D */ public byte[] Padding1D;
        /* 0x0020 */ public float TestAnimThrust;
        /* 0x0024 */ public float TestAnimBoost;
        /* 0x0028 */ public float TestAnimTurn;
        /* 0x002C */ public float VisualTurnUnderwaterSpring;
        /* 0x0030 */ public float VisualTurnSpring;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x0034 */ public byte[] Padding34;
        /* 0x0040 */ public Colour DefaultBoosterColour;
        /* 0x0050 */ public float WheelDustColourLightFactor;
        /* 0x0054 */ public float SubmarineMinSummonDepth;
        /* 0x0058 */ public float SubmarineEjectRadius;
        /* 0x005C */ public float SubmarineEjectDownOffset;
        /* 0x0060 */ public float UnderwaterBuoyancySurfaceOffset;
        /* 0x0064 */ public float UnderwaterBuoyancyRange;
        /* 0x0068 */ public float UnderwaterSummonSurfaceOffset;
        /* 0x006C */ public float UnderwaterSurfaceTension;
        /* 0x0070 */ public float UnderwaterSurfaceOffset;
        /* 0x0074 */ public float UnderwaterSurfaceGravity;
        /* 0x0078 */ public float UnderwaterFlattenMinDepth;
        /* 0x007C */ public float UnderwaterFlattenRange;
        /* 0x0080 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        /* 0x0084 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        /* 0x0088 */ public float UnderwaterSurfaceSplashdownForce;
        /* 0x008C */ public float UnderwaterSurfaceSplashdownMinSpeed;
        /* 0x0090 */ public float UnderwaterJumpForce;
        /* 0x0094 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x00B8 */ public byte[] PaddingB8;
                     [NMS(Size = 0x04)]
        /* 0x00C0 */ public Vector4f[] UnderwaterBubbleOffset;
        /* 0x0100 */ public float VehicleBoostSpeedMultiplierPercent;
        /* 0x0104 */ public float VehicleGarageHologramMinFadeRange;
        /* 0x0108 */ public float VehicleGarageHologramFadeRange;
        /* 0x010C */ public float CheckpointPlacementOffset;
        /* 0x0110 */ public float CheckpointPlacementRayLength;
        /* 0x0114 */ public float CheckpointDeleteDistance;
        /* 0x0118 */ public float CheckpointDeleteAngle;
        /* 0x011C */ public float BoostPadTime;
        /* 0x0120 */ public float BoostPadStrength;
        /* 0x0124 */ public float DisablePhysicsRange;
        /* 0x0128 */ public float RaceMultipleStartOffset;
        /* 0x012C */ public float RaceMultipleStartCaptureRange;
        /* 0x0130 */ public float MiningLaserDrainSpeed;
        /* 0x0134 */ public float ProjectileDrainPerShot;
        /* 0x0138 */ public float RaceStartSpawnUpOffset;
        /* 0x013C */ public float RaceInteractRespawnOffset;
        /* 0x0140 */ public float RaceInteractRespawnUpOffset;
        /* 0x0144 */ public float StickTurnReducer;
        /* 0x0148 */ public float StickTurnReducerAlt;
        /* 0x014C */ public float TravelSpeedReportReducer;
        /* 0x0150 */ public float HornScareRadius;
        /* 0x0154 */ public float HornScareFleeRadius;
        /* 0x0158 */ public float HornScareTime;
        /* 0x015C */ public float AttractAmount;
        /* 0x0160 */ public float AttractMaxSpeed;
        /* 0x0164 */ public float AttractAlign;
        /* 0x0168 */ public float AttractDirectionBrakeThresholdSq;
        /* 0x016C */ public float ExitStopTime;
        /* 0x0170 */ public float ExitStopForce;
        /* 0x0174 */ public float GunFireRate;
        /* 0x0178 */ public float MinTurretAngle;
        /* 0x017C */ public float SummoningRange;
        /* 0x0180 */ public float CheckpointRadius;
        /* 0x0184 */ public float RaceCooldown;
        /* 0x0188 */ public float RaceResetFlashDuration;
        /* 0x018C */ public float RaceResetFlashIntensity;
        /* 0x0190 */ public float CheckpointFlashDuration;
        /* 0x0194 */ public float CheckpointFlashIntensity;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0198 */ public byte[] Padding198;
        /* 0x01A0 */ public Colour CheckpointBeamColourActive;
        /* 0x01B0 */ public Colour CheckpointBeamColourNormal;
                     [NMS(Size = 0x01)]
        /* 0x01C0 */ public NMSString0x10[] DefaultBuggyLoadout;
                     [NMS(Size = 0x02)]
        /* 0x01D0 */ public NMSString0x10[] DefaultBikeLoadout;
                     [NMS(Size = 0x02)]
        /* 0x01F0 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0x0210 */ public float CheckpointBeamSizeNormal;
        /* 0x0214 */ public float CheckpointBeamSizeActive;
        /* 0x0218 */ public float CheckpointBeamOffset;
        /* 0x021C */ public float SpawnRotation;
        /* 0x0220 */ public float MiningLaserRadius;
        /* 0x0224 */ public int MiningLaserMiningDamage;
        /* 0x0228 */ public int MiningLaserDamage;
        /* 0x022C */ public float MiningLaserSpeed;
        /* 0x0230 */ public int GunBaseDamage;
        /* 0x0234 */ public int GunBaseMiningDamage;
        /* 0x0238 */ public float ResourceCollectOffset;
        /* 0x023C */ public float VehicleWheelNoise;
        /* 0x0240 */ public float VehicleWheelNoiseScale;
        /* 0x0244 */ public float WheelSideVerticalFactor;
        /* 0x0248 */ public float SuspensionDamping;
        /* 0x024C */ public float SuspensionDampingAngularFactor;
        /* 0x0250 */ public bool ShowTempVehicleMesh;
        /* 0x0251 */ public bool ShowVehicleDebugging;
        /* 0x0252 */ public bool ShowVehicleWheelGuards;
        /* 0x0253 */ public bool ShowVehicleText;
        /* 0x0254 */ public float VehicleTextSize;
        /* 0x0258 */ public bool ShowVehicleParticleDebug;
        /* 0x0259 */ public bool VehicleDrawAudioDebug;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x025A */ public byte[] Padding25A;
        /* 0x025C */ public float VehicleSuspensionAudioSpacing;
        /* 0x0260 */ public float VehicleSuspensionAudioDelay;
        /* 0x0264 */ public float VehicleSuspensionAudioScale;
        /* 0x0268 */ public float VehicleSuspensionAudioTrigger;
        /* 0x026C */ public float VehicleFadeTime;
        /* 0x0270 */ public float VehicleMinSummonDistance;
        /* 0x0274 */ public float VehicleMaxSummonDistance;
        /* 0x0278 */ public float VehicleMaxSummonDistanceUnderwater;
        /* 0x027C */ public float VehicleDeactivateRange;
        /* 0x0280 */ public float VehicleBoostFuelRate;
        /* 0x0284 */ public float VehicleBoostFuelRateSurvival;
        /* 0x0288 */ public float VehicleFuelRate;
        /* 0x028C */ public float VehicleFuelRateSurvival;
        /* 0x0290 */ public float VehicleFuelRateTruckMultiplier;
        /* 0x0294 */ public float VehicleJumpTimeMin;
        /* 0x0298 */ public float VehicleJumpTimeMax;
        /* 0x029C */ public float VehicleJumpCooldown;
        /* 0x02A0 */ public float VehicleMotionDeadZone;
        /* 0x02A4 */ public float WheelForceHalflife;
        /* 0x02A8 */ public bool ThrottleButtonCamRelative;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x02A9 */ public byte[] Padding2A9;
        /* 0x02AC */ public float StickReverseTurnThreshold;
        /* 0x02B0 */ public float StickReverseTurnStiffness;
        /* 0x02B4 */ public GcScanData VehicleScan;
        /* 0x02C8 */ public GcScanData VehicleLocalScan;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x02DC */ public byte[] Padding2DC;
                     [NMS(Size = 0x06, EnumValue = new[] { "Bike", "Buggy", "Truck", "WheeledBike", "Hovercraft", "Submarine" })]
        /* 0x02E0 */ public GcVehicleData[] VehicleDataTable;
    }
}
