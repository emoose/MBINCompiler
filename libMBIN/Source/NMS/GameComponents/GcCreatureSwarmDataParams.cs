using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8009A5557F407142, NameHash = 0x53731F3E)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        [NMS(Index = 45)]
        /* 0x00 */ public NMSString0x10 AnimThrustCycleAnim;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 11)]
        /* 0x20 */ public float Alignment;
        [NMS(Index = 15)]
        /* 0x24 */ public float AlignTime;
        [NMS(Index = 48)]
        /* 0x28 */ public float AnimThrustCycleEnd;
        [NMS(Index = 49)]
        /* 0x2C */ public float AnimThrustCycleMax;
        [NMS(Index = 50)]
        /* 0x30 */ public float AnimThrustCycleMin;
        [NMS(Index = 47)]
        /* 0x34 */ public float AnimThrustCyclePeak;
        [NMS(Index = 46)]
        /* 0x38 */ public float AnimThrustCycleStart;
        [NMS(Index = 16)]
        /* 0x3C */ public float BankingTime;
        [NMS(Index = 10)]
        /* 0x40 */ public float Coherence;
        [NMS(Index = 24)]
        /* 0x44 */ public float FaceMoveDirStrength;
        [NMS(Index = 34)]
        /* 0x48 */ public float FlyTimeMax;
        [NMS(Index = 33)]
        /* 0x4C */ public float FlyTimeMin;
        [NMS(Index = 14)]
        /* 0x50 */ public float Follow;
        [NMS(Index = 27)]
        /* 0x54 */ public float LandAdjustDist;
        [NMS(Index = 28)]
        /* 0x58 */ public float LandClampBegin;
        [NMS(Index = 38)]
        /* 0x5C */ public float LandIdleTimeMax;
        [NMS(Index = 37)]
        /* 0x60 */ public float LandIdleTimeMin;
        [NMS(Index = 29)]
        /* 0x64 */ public float LandSlowDown;
        [NMS(Index = 36)]
        /* 0x68 */ public float LandTimeMax;
        [NMS(Index = 35)]
        /* 0x6C */ public float LandTimeMin;
        [NMS(Index = 40)]
        /* 0x70 */ public float LandWalkTimeMax;
        [NMS(Index = 39)]
        /* 0x74 */ public float LandWalkTimeMin;
        [NMS(Index = 17)]
        /* 0x78 */ public float MaxBankingAmount;
        [NMS(Index = 20)]
        /* 0x7C */ public float MaxPitchAmount;
        [NMS(Index = 1)]
        /* 0x80 */ public float MaxSpeed;
        [NMS(Index = 19)]
        /* 0x84 */ public float MinPitchAmount;
        [NMS(Index = 12)]
        /* 0x88 */ public float SeparateStrength;
        [NMS(Index = 13)]
        /* 0x8C */ public float Spacing;
        [NMS(Index = 22)]
        /* 0x90 */ public float SpeedForMaxPitch;
        [NMS(Index = 21)]
        /* 0x94 */ public float SpeedForMinPitch;
        [NMS(Index = 8)]
        /* 0x98 */ public float SteeringSpringSmoothTime;
        [NMS(Index = 4)]
        /* 0x9C */ public float SwimAnimSpeedMax;
        [NMS(Index = 3)]
        /* 0xA0 */ public float SwimAnimSpeedMin;
        [NMS(Index = 2)]
        /* 0xA4 */ public float SwimFastSpeedMul;
        [NMS(Index = 5)]
        /* 0xA8 */ public float SwimMaxAcceleration;
        [NMS(Index = 6)]
        /* 0xAC */ public float SwimTurn;
        [NMS(Index = 31)]
        /* 0xB0 */ public float TakeOffStartSpeed;
        [NMS(Index = 30)]
        /* 0xB4 */ public float TakeOffTime;
        [NMS(Index = 32)]
        /* 0xB8 */ public float TakeOffUpwardBoost;
        [NMS(Index = 18)]
        /* 0xBC */ public float TurnRequiredForMaxBanking;
        [NMS(Index = 23)]
        /* 0xC0 */ public float UpwardMovementForMaxPitch;
        [NMS(Index = 42)]
        /* 0xC4 */ public float WalkSpeed;
        [NMS(Index = 43)]
        /* 0xC8 */ public float WalkTurnTime;
        [NMS(Index = 7)]
        /* 0xCC */ public bool ApplyScaleToSpeed;
        [NMS(Index = 9)]
        /* 0xCD */ public bool ApplyScaleToSteeringSmoothTime;
        [NMS(Index = 26)]
        /* 0xCE */ public bool CanLand;
        [NMS(Index = 41)]
        /* 0xCF */ public bool CanWalk;
        [NMS(Index = 25)]
        /* 0xD0 */ public bool FaceMoveDirYawOnly;
        [NMS(Index = 44)]
        /* 0xD1 */ public bool UseAnimThrustCycle;
    }
}
