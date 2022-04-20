using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x210, GUID = 0x6075C2A7B0560FAF, NameHash = 0x0D3C0DCB43542B48)]
    public class GcPlayerSquadronConfig : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 SquadName;
        /* 0x020 */ public NMSString0x10 AttackDefinition;
        [NMS(Size = 0x4)]
        /* 0x030 */ public Vector2f[] PilotRankTraitRanges;
        /* 0x050 */ public float SummonArriveTime;
        /* 0x054 */ public float SummonArriveTimeIntervalMin;
        /* 0x058 */ public float SummonArriveTimeIntervalMax;
        /* 0x05C */ public float SummonStartSpeed;
        /* 0x060 */ public float SummonLimitTurningTime;
        /* 0x064 */ public float MinSpeedForSummonInMoveDir;
        /* 0x068 */ public float SummonSpaceSpawnRangeMin;
        /* 0x06C */ public float SummonSpaceSpawnRangeMax;
        /* 0x070 */ public float SummonSpaceSpawnAngleMin;
        /* 0x074 */ public float SummonSpaceSpawnAngleMax;
        /* 0x078 */ public float SummonPlanetPitchMin;
        /* 0x07C */ public float SummonPlanetPitchMax;
        /* 0x080 */ public float SummonPlanetYawMin;
        /* 0x084 */ public float SummonPlanetYawMax;
        /* 0x088 */ public float SummonPlanetDistance;
        /* 0x08C */ public bool SummonInFormation;
        /* 0x090 */ public float SummonInFormationFwdOffset;
        /* 0x094 */ public float LeavingForceScaleDistMin;
        /* 0x098 */ public float LeavingForceScaleDistMax;
        /* 0x09C */ public float LeavingMaxForceMultiplier;
        /* 0x0A0 */ public float LeavingFromPlanetOrbitWarpDist;
        /* 0x0A4 */ public float LeavingFromPlanetOrbitMinIncline;
        /* 0x0A8 */ public float LeavingFromPlanetOrbitMaxSpeed;
        /* 0x0AC */ public float LeavingFromSpaceWarpDist;
        /* 0x0B0 */ public float LeavingFromSpaceAngleFromFwdMin;
        /* 0x0B4 */ public float LeavingFromSpaceAngleFromFwdMax;
        /* 0x0B8 */ public float FormationOffsetRotationPeriod;
        /* 0x0BC */ public float FormationOffsetRotationMaxSpeed;
        /* 0x0C0 */ public float FormationOffsetZOffsetVarianceMinSpeedScale;
        /* 0x0C4 */ public float FormationOffsetZOffsetVarianceMaxSpeedScale;
        /* 0x0C8 */ public float FormationOffsetZOffsetVariancePeriod;
        /* 0x0CC */ public float FormationOffsetZOffsetVarianceMin;
        /* 0x0D0 */ public float FormationOffsetZOffsetVarianceMax;
        /* 0x0E0 */ public Vector3f FormationOffset;
        /* 0x0F0 */ public float FormationOffsetCylinderWidth;
        /* 0x0F4 */ public float FormationOffsetCylinderHeight;
        /* 0x0F8 */ public float FormationOffsetCylinderLength;
        /* 0x100 */ public Vector3f FormationOffsetThirdPerson;
        /* 0x110 */ public float FormationOffsetCylinderWidthThirdPerson;
        /* 0x114 */ public float FormationOffsetCylinderHeightThirdPerson;
        /* 0x118 */ public float FormationOffsetCylinderLengthThirdPerson;
        /* 0x120 */ public Vector3f CombatFormationOffset;
        /* 0x130 */ public float CombatFormationOffsetCylinderWidth;
        /* 0x134 */ public float CombatFormationOffsetCylinderHeight;
        /* 0x138 */ public float CombatFormationOffsetCylinderLength;
        /* 0x140 */ public Vector3f CombatFormationOffsetThirdPerson;
        /* 0x150 */ public float CombatFormationOffsetCylinderWidthThirdPerson;
        /* 0x154 */ public float CombatFormationOffsetCylinderHeightThirdPerson;
        /* 0x158 */ public float CombatFormationOffsetCylinderLengthThirdPerson;
        /* 0x15C */ public float MaintainFormationStrengthVariance;
        /* 0x160 */ public float MaintainFormationInCombatMinTime;
        /* 0x164 */ public float MaintainFormationInCombatMaxTime;
        /* 0x168 */ public float MaintainFormationStartSmoothTime;
        /* 0x16C */ public float MaintainFormationMaxForce;
        /* 0x170 */ public float MaintainFormationLockStrength;
        /* 0x174 */ public float MaintainFormationLockStrengthCombat;
        /* 0x178 */ public float MaintainFormationLockStrengthBoosting;
        /* 0x17C */ public float MaintainFormationPostBoostSmoothTime;
        /* 0x180 */ public float MaintainFormationLockAlignStrength;
        /* 0x184 */ public float MaintainFormationLockRollAlignStrength;
        /* 0x188 */ public float MaintainFormationAlignMinDist;
        /* 0x18C */ public float MaintainFormationAlignMaxDist;
        /* 0x190 */ public float MaintainFormationAlignMinSpeed;
        /* 0x194 */ public float MaintainFormationAlignMaxSpeed;
        /* 0x198 */ public float MaintainFormationSharpTurnMinSpeed;
        /* 0x19C */ public float MaintainFormationSharpTurnMinSpeedForce;
        /* 0x1A0 */ public float JoinFormationMaxForce;
        /* 0x1A4 */ public float JoinFormationOffset;
        /* 0x1A8 */ public float JoinFormationArrivalTolerance;
        /* 0x1AC */ public float JoinFormationBoostMaxSpeed;
        /* 0x1B0 */ public float JoinFormationBoostMinDist;
        /* 0x1B4 */ public float JoinFormationBoostMaxDist;
        /* 0x1B8 */ public float JoinFormationBoostAlignStrength;
        /* 0x1BC */ public float JoinFormationBrakeAlignStrength;
        /* 0x1C0 */ public float JoinFormationBrakeDist;
        /* 0x1C4 */ public float JoinFormationMinSpeed;
        /* 0x1C8 */ public float JoinFormationMaxSpeedBrake;
        /* 0x1CC */ public float BreakFormationTime;
        /* 0x1D0 */ public float BreakFormationMaxForce;
        /* 0x1D4 */ public float BreakFormationMinTurnAngle;
        /* 0x1D8 */ public float BreakFormationMaxTurnAngle;
        /* 0x1DC */ public float MinTimeBetweenFormationBreaks;
        /* 0x1E0 */ public int MinShipsInFormationDuringCombat;
        /* 0x1E4 */ public int MaxShipsInFormationDuringCombat;
        /* 0x1E8 */ public float OutOfFormationMinTime;
        /* 0x1EC */ public float OutOfFormationMaxTime;
        /* 0x1F0 */ public List<GcAISpaceshipModelData> RandomSpaceshipResources;
        /* 0x200 */ public List<NMSString0x80> RandomPilotNPCResources;
    }
}
