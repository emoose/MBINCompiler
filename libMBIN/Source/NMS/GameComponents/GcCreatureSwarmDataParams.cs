using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BCB779856C3ADF6, NameHash = 0x691F170D5F26887A)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x10 */ public float Coherence;
        /* 0x14 */ public float Alignment;
        /* 0x18 */ public float SeparateStrength;
        /* 0x1C */ public float Spacing;
        /* 0x20 */ public float Follow;
        /* 0x24 */ public float Range;
        /* 0x28 */ public float MaxBankingAmount;
        /* 0x2C */ public float TurnRequiredForMaxBanking;
        /* 0x30 */ public float MaxPitchAmount;
        /* 0x34 */ public float UpwardMovementForMaxPitch;
        /* 0x38 */ public float FaceMoveDirStrength;
        /* 0x3C */ public bool FaceMoveDirYawOnly;
        /* 0x3D */ public bool CanLand;
        /* 0x40 */ public float LandAdjustDist;
        /* 0x44 */ public float LandClampBegin;
        /* 0x48 */ public float LandSlowDown;
        /* 0x4C */ public float TakeOffTime;
        /* 0x50 */ public float TakeOffStartSpeed;
        /* 0x54 */ public float TakeOffUpwardBoost;
        /* 0x58 */ public bool CanWalk;
        /* 0x5C */ public float WalkSpeed;
        /* 0x60 */ public float WalkTurnTime;
        /* 0x64 */ public float FlyTimeMin;
        /* 0x68 */ public float FlyTimeMax;
        /* 0x6C */ public float LandTimeMin;
        /* 0x70 */ public float LandTimeMax;
        /* 0x74 */ public float LandIdleTimeMin;
        /* 0x78 */ public float LandIdleTimeMax;
        /* 0x7C */ public float LandWalkTimeMin;
        /* 0x80 */ public float LandWalkTimeMax;
        /* 0x84 */ public float MaxSpeed;
        /* 0x88 */ public float AlignTime;
        /* 0x8C */ public float BankingTime;
        /* 0x90 */ public float SpringSmoothTime;
        /* 0x94 */ public bool ApplyScaleToSpeed;
    }
}
